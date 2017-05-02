using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ozeki.Media.MediaHandlers;
using Ozeki.VoIP;
using Ozeki.VoIP.SDK;


namespace TIP
{
    public partial class Form1 : Form
    {

        private ISoftPhone softPhone;
        private IPhoneLine phoneLine;
        private RegState phoneLineInformation;
        private IPhoneCall call;
        private Microphone microphone = Microphone.GetDefaultDevice();
        private Speaker speaker = Speaker.GetDefaultDevice();
        MediaConnector connector = new MediaConnector();
        PhoneCallAudioSender mediaSender = new PhoneCallAudioSender();
        PhoneCallAudioReceiver mediaReceiver = new PhoneCallAudioReceiver();

        private bool inComingCall;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeSoftPhone()
        {
            try
            {
                softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750);
                InvokeGUIThread(() => { lb_Log.Items.Add("Softphone created!"); });

                softPhone.IncomingCall += new EventHandler<VoIPEventArgs<IPhoneCall>>(softPhone_inComingCall);

                SIPAccount sa = new SIPAccount(true, "1000", "1000", "1000", "1000", "192.168.1.154", 5060);
                InvokeGUIThread(() => { lb_Log.Items.Add("SIP account created! - " + sa.RegisterName); });

                phoneLine = softPhone.CreatePhoneLine(sa);
                phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                softPhone.RegisterPhoneLine(phoneLine);

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Local IP error!"); });
            }

        }

        private void StartDevices()
        {
            if (microphone != null)
            {
                microphone.Start();
                InvokeGUIThread(() => {lb_Log.Items.Add("Microphone Started."); });
            }
            if (speaker != null)
            {
                speaker.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }
        private void StopDevices()
        {
            if (microphone != null)
            {
                microphone.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }
            if (speaker != null)
            {
                speaker.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }

        private void ConnectMedia()
        {
            if (microphone != null)
            {
                connector.Connect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Connect(mediaReceiver, speaker);
            }
        }
        private void DisconnectMedia()
        {
            if (microphone != null)
            {
                connector.Disconnect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Disconnect(mediaReceiver, speaker);
            }
        }

        private void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }


        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString()); });

            call = e.Item;
            WireUpCallEvents();
            inComingCall = true;
        }


        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            phoneLineInformation = e.State;

            InvokeGUIThread(() =>
            {
                if (phoneLineInformation == RegState.RegistrationSucceeded)
                {
                    lb_Log.Items.Add("Registration succeeded - Online");
                }
                else
                {
                    lb_Log.Items.Add("Not registered - Offline: " + phoneLineInformation.ToString());
                }
            });
        }


        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString()); });

            if (e.State == CallState.Answered)
            {
                StartDevices();

                mediaReceiver.AttachToCall(call);
                mediaSender.AttachToCall(call);

                InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State.IsCallEnded() == true)
            {
                StopDevices();

                mediaReceiver.Detach();
                mediaSender.Detach();

                WireDownCallEvents();

                call = null;

                InvokeGUIThread(() => { lb_Log.Items.Add("Call ended."); });
            }
        }


        private void WireUpCallEvents()
        {
            call.CallStateChanged += (call_CallStateChanged);
        }

        private void WireDownCallEvents()
        {
            call.CallStateChanged -= (call_CallStateChanged);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSoftPhone();
        }

        private void lb_Log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (inComingCall)
            {
                inComingCall = false;
                call.Answer();

                InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
                return;
            }

            if (call != null)
            {
                return;
            }

            if (phoneLineInformation != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Registration Failed!"); });
                return;
            }

            call = softPhone.CreateCallObject(phoneLine,"1005");//lbl_NumberToDial.Text);
            WireUpCallEvents();
            call.Start();
        }

        private void btn_HangUp_Click(object sender, EventArgs e)
        {
            if (call != null)
            {
                if (inComingCall && call.CallState == CallState.Ringing)
                {
                    call.Reject();
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call rejected."); });
                }
                else
                {
                    call.HangUp();
                    inComingCall = false;
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call hanged up."); });
                }

                call = null;
            }

           // lbl_NumberToDial.Text = string.Empty;
        }
    }
    
}
