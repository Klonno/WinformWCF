using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWCF
{


    public partial class Form1 : Form
    {
        CancellationTokenSource _tokenSource = new CancellationTokenSource();
        CancellationToken _cancelToken;
        private delegate void SetCheckDelegate(RadioButton button, bool set);


        public Form1()
        {
            InitializeComponent();
            _cancelToken = _tokenSource.Token;
            Action blinkMethod = new Action(() => BlinkTheButton(this));
            Task blinker = new Task(blinkMethod, _cancelToken);
            blinker.Start();
        }

        private void BlinkTheButton(Form1 form)
        {
            bool state = true;

            while (WaitHandle.WaitAll(new WaitHandle[] { _cancelToken.WaitHandle }, 1000) == false)
            {
                if (state == true)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }
                SetBlinkButton(state);
            }
        }

        private void ThreadSafeSetCheck(RadioButton button, bool set)
        {
            button.Checked = set;
        }

        private void SetBlinkButton(bool check)
        {
            if (this.blinkButton.InvokeRequired)
            {
                SetCheckDelegate d = new SetCheckDelegate(ThreadSafeSetCheck);
                this.blinkButton.Invoke(d, new object[] { blinkButton, check });
            }
            else
            {
                this.blinkButton.Checked = check;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private void callServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                WinformWCF.TestWCFServiceReference.TestWCFServiceClient serviceClient = new TestWCFServiceReference.TestWCFServiceClient();

                string str = serviceClient.GetData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
