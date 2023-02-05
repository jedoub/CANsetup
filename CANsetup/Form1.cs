using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Kvaser.CanLib;
using CANsetup;


// REVISION NOTES
// SEE the ReleaseNotesForm.

namespace Kv_DeviceDemo
{
    public partial class Form1 : Form
    {
        private static string SWvers = "2.0.0.2";
        
        CANsetupForm idNselcCAN_HW = new CANsetupForm();
        
        ReleaseNotesForm versionHistory = new ReleaseNotesForm();

        OSSForm aboutOSL = new OSSForm();

        private static Canlib.canStatus can_status;   //A KVASER CANLIBRARY OBJECT
        private static int dlc = 8, flag;
        private static long time, GUIinterval = 0, GUIintervalPV = 0, execTime = 0;

        private static string PersonalDirPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CANsetup";

        private static int EEC1_X_E = 0xCF00400;                                                // J1939 Message on the BB1subnet & BB2subnet that contains Engine Speed signal.
        private static byte[] EEC1msg = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };     // EMS EEC1 MSG

        private static int PM21_X_E = 0xCFF1500;                                                // J1939 Message on the ESNsubnet that contains Engine Speed signal.
        private static byte[] PM21msg = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };     // EMS PM21 MSG

        private static int PM24_X_E = 0xCFF1800;                                                // J1939 Message on the PWTsubnet that contains Engine Speed signal.
        private static byte[] PM24msg = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };     // EMS PM24 MSG
        
        /* NOT USED I had used these variables to demonstrate an alternative method to schedule CAN messages without using a Timer ***************************
        private static int AMBCxV = 0x18FEF511;
        private static int AMBCxIC = 0x18FEF517;
        private static byte[] AMBCxVmsg = { 0xFF, 0xFF, 0xFF, 0x40, 0x25, 0xFF, 0xFF, 0xFF };

        private static int VP2xV = 0xCFF0211;
        private static byte[] VP2xVmsg = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3F, 0xFF };
        ******************************************************************************************************************************************************/
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            // CALL to link the FORM1 REFERENCE to OBJECTS by CREATING an instance of the FORM1
            InitializeComponent();

            // I found this solution on StackOverflow. This triggers the form to close when clicking on the Window's upper-right corner [X].
            // Delegate the event to a handler using this style of statement
            this.FormClosing += this.MainWin_FormClosing;
        }

        /// <summary>
        /// This main form is used to "call" the CANsetup Form.
        /// It is a template/example how the CANsetup is to be used by other CAN based applications needing a flexible CAN setup form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.richTextBox1.Font = new Font("Lucida Console", 7);

            //ConfigPathLbl.Text = "CONFIG File path: " + PersonalDirPath;
            SWversLbl.Text = "SWvers: " + SWvers;

            
            // This statement calls the CANsetup Form.
            if (idNselcCAN_HW.ShowDialog() == DialogResult.OK)
            {
                // Depending on the button used to return from the CANsetup do the following in the main Form
                CANstatus_cB.Enabled = true;
                CANstatus_cB.Checked = true;
                CANstatus_cB.ForeColor = Color.Green;
                CANstatus_cB.Font = new Font("Lucida Console", 7);
                CANstatus_cB.Text = CANsetupForm.txtCAN_HW;
            }
            else //if (DialogResult == DialogResult.Abort)
            {
                MainWin_FormClosing(null, null);
            }

            // Virtual button click to start GUI TIMER
            button1_Click(null, null);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Stop the timers and Kill all the processes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWin_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void sWVersionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(PersonalDirPath + "SWvers: " + SWvers, "CAN Setup Version");
        }

        private void kvaserDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This APP was developed using 8.27.776 The current version is:\r\n" + CANsetupForm.kvDrvrString, "KVASER STATUS BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void configHintsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The CANconfig.txt file is in: " + PersonalDirPath, "Help");
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (versionHistory.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 
            Copyright (c) 2011-2017 GitHub Inc.

            Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

            The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

            THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
            */
            if (aboutOSL.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void createANewConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = PersonalDirPath + @"\CANconfig.txt";

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);

                MessageBox.Show("CONFIGURATION FILE DELETED.", "Check Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (idNselcCAN_HW.ShowDialog() == DialogResult.OK)
            {
                CANstatus_cB.Checked = true;
            }
            else if (DialogResult == DialogResult.Abort)
            {
                MainWin_FormClosing(null, null);
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                MainWin_FormClosing(null, null);
            }
        }

        private void viewCANMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(CANsetupForm.txtCAN_HW, "CANsetup Info", 3500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Contains("Start"))
            {
                //MessageBox.Show("CODE TO FOLLOW GOES HERE.", "INFO");
                // For this example I start a timer that periodically updates the GUI's text box object found on the main Form.
                if (CANsetupForm.txtCAN_HW.Contains(CANsetupForm.subNetName[1]))
                    Canlib.canFlushReceiveQueue(CANsetupForm.CAN1hnd);
                if (CANsetupForm.txtCAN_HW.Contains(CANsetupForm.subNetName[2]))
                    Canlib.canFlushReceiveQueue(CANsetupForm.CAN2hnd);
                if (CANsetupForm.txtCAN_HW.Contains(CANsetupForm.subNetName[3]))
                    Canlib.canFlushReceiveQueue(CANsetupForm.CAN3hnd);
                if (CANsetupForm.txtCAN_HW.Contains(CANsetupForm.subNetName[4]))
                    Canlib.canFlushReceiveQueue(CANsetupForm.CAN4hnd);
                if (CANsetupForm.txtCAN_HW.Contains(CANsetupForm.subNetName[5]))
                    Canlib.canFlushReceiveQueue(CANsetupForm.CAN5hnd);                

                button1.Text = "OnLine";
                GUItimer.Enabled = true;
                GUItimer.Start();
            }
            else
            {
                button1.Text = "Start";
                richTextBox1.Clear();
            }
        }

        private void GUItimer_Tick(object sender, EventArgs e)
        {
            string[] textBuffer = new string[9];

            GUIintervalPV = GUIinterval;

            //OLD method GUIinterval = Canlib.canReadTimer(CANsetupForm.CAN1hnd);
            can_status = Canlib.kvReadTimer64(CANsetupForm.CAN1hnd, out GUIinterval);    // Update the time every loop.

            if (button1.Text.Contains("OnLine"))
            {
                if (CANsetupForm.chn1ConfigSuccess)
                {
                    // Read the EEC1 message on CAN1
                    can_status = Canlib.canReadSpecificSkip(CANsetupForm.CAN1hnd, EEC1_X_E, EEC1msg, out dlc, out flag, out time);

                    if (can_status == Canlib.canStatus.canOK)
                    {
                        // Display the ENGINE SPEED
                        textBuffer[0] = "CAN1.EEC1xE.EngSpd: " + ((EEC1msg[4] * 256 + EEC1msg[3]) * 0.125).ToString("F1");

                        textBuffer[1] += Environment.NewLine;
                    }
                    else
                    {
                        // Display the ENGINE SPEED
                        textBuffer[0] = "CAN1.EEC1xE.EngSpd: ";

                        textBuffer[1] += Environment.NewLine;
                    }
                }

                if (CANsetupForm.chn2ConfigSuccess)
                {
                    // Read the Engine Speed in PM21xE message on CAN2
                    can_status = Canlib.canReadSpecificSkip(CANsetupForm.CAN2hnd, PM21_X_E, PM21msg, out dlc, out flag, out time);
                    if (can_status == Canlib.canStatus.canOK)
                    {
                        // Display the ENGINE SPEED
                        textBuffer[2] += "CAN2.PM21xE.EngSpd: " + ((PM21msg[3] * 256 + PM21msg[2]) * 0.125).ToString("F1");

                        textBuffer[3] += Environment.NewLine;
                    }
                    else
                    {
                        // Display the ENGINE SPEED
                        textBuffer[2] += "CAN2.PM21xE.EngSpd: ";

                        textBuffer[3] += Environment.NewLine;
                    }
                }

                if (CANsetupForm.chn3ConfigSuccess)
                {
                    // Read the EEC1 message on CAN3
                    can_status = Canlib.canReadSpecificSkip(CANsetupForm.CAN3hnd, EEC1_X_E, EEC1msg, out dlc, out flag, out time);
                    if (can_status == Canlib.canStatus.canOK)
                    {
                        // Display the ENGINE SPEED
                        textBuffer[4] += "CAN3.EEC1xE.EngSpd: " + ((EEC1msg[4] * 256 + EEC1msg[3]) * 0.125).ToString("F1");

                        textBuffer[5] += Environment.NewLine;
                    }
                    else
                    {
                        // Display the ENGINE SPEED
                        textBuffer[4] += "CAN3.EEC1xE.EngSpd: ";

                        textBuffer[5] += Environment.NewLine;
                    }
                }

                if (CANsetupForm.chn4ConfigSuccess)
                {
                    // Read the Engine Speed in PM24xE message on CAN4
                    can_status = Canlib.canReadSpecificSkip(CANsetupForm.CAN4hnd, PM24_X_E, PM24msg, out dlc, out flag, out time);
                    if (can_status == Canlib.canStatus.canOK)
                    {
                        // Display the ENGINE SPEED
                        textBuffer[6] += "CAN4.PM24xE.EngSpd: " + ((PM24msg[2] * 256 + PM24msg[1]) * 0.125).ToString("F1");
                    }
                    else
                    {
                        // Display the ENGINE SPEED
                        textBuffer[6] += "CAN4.PM24xE.EngSpd: ";
                    }
                }

                if (CANsetupForm.chn5ConfigSuccess)
                {
                    textBuffer[7] += Environment.NewLine;

                    // Read the EEC1 message on CHN5
                    can_status = Canlib.canReadSpecificSkip(CANsetupForm.CAN5hnd, EEC1_X_E, EEC1msg, out dlc, out flag, out time);
                    if (can_status == Canlib.canStatus.canOK)
                    {
                        // Display the ENGINE SPEED
                        textBuffer[8] += "CAN5.EEC1xE.EngSpd: " + ((EEC1msg[4] * 256 + EEC1msg[3]) * 0.125).ToString("F1");
                    }
                }
                else
                {
                    if (CANsetupForm.chn5ConfigSuccess)
                    {
                        textBuffer[7] += Environment.NewLine;

                        // Display the ENGINE SPEED
                        textBuffer[8] += "CAN5.EEC1xE.EngSpd: ";
                    }
                }
                richTextBox1.Lines = textBuffer;
            }
            else
            {
                // Virtual button click to start GUI TIMER
                button1_Click(null, null);
            }

            if (CANsetupForm.txtCAN_HW.Contains("BB1"))
                Canlib.canFlushReceiveQueue(CANsetupForm.CAN1hnd);
            if (CANsetupForm.txtCAN_HW.Contains("ESN"))
                Canlib.canFlushReceiveQueue(CANsetupForm.CAN2hnd);
            if (CANsetupForm.txtCAN_HW.Contains("BB2"))
                Canlib.canFlushReceiveQueue(CANsetupForm.CAN3hnd);
            if (CANsetupForm.txtCAN_HW.Contains("PWT"))
                Canlib.canFlushReceiveQueue(CANsetupForm.CAN4hnd);
            if (CANsetupForm.txtCAN_HW.Contains("ISN"))
                Canlib.canFlushReceiveQueue(CANsetupForm.CAN5hnd);

            //execTime = Canlib.canReadTimer(CANsetupForm.CAN1hnd);
            can_status = Canlib.kvReadTimer64(CANsetupForm.CAN1hnd, out execTime);    // Update the time at the end of the method.

            updateIntervalLbl.Text = "GUI Timer Interval: " + (GUIinterval - GUIintervalPV).ToString("D4") + " ms";
            updateIntervalLbl.Text += "  Execution Time: " + (execTime - GUIinterval).ToString("D4") + " ms";
        }
    }
}
