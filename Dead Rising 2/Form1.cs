using System;
using System.Drawing;
using System.Windows.Forms;
using PS3Lib;
using MetroFramework.Forms;

namespace Dead_Rising_2
{
    public partial class Form1 : MetroForm
    {
        PS3API PS3 = new PS3API();
        public Form1()
        {
            InitializeComponent();
            MLevel.Enabled = false;
            MMoney.Enabled = false;
            clip.Enabled = false;
            GOD.Enabled = false;
            speed.Enabled = false;
            weapons.Enabled = false;
            physics.Enabled = false;
        }
        bool Connection(SelectAPI API)
        {
            PS3.ChangeAPI(API);
            bool state = PS3.ConnectTarget();
            if (state)
            {
                ctext.Text = state ? "Connected" : "Not Connected";
                ctext.ForeColor = state ? Color.Blue : Color.Red;
                state = PS3.AttachProcess();
                if (state)
                {
                    atext.Text = state ? "Attached" : "Not Attached";
                    atext.ForeColor = state ? Color.Blue : Color.Red;
                    MLevel.Enabled = true;
                    MMoney.Enabled = true;
                    GOD.Enabled = true;
                    speed.Enabled = true;
                    weapons.Enabled = true;
                    physics.Enabled = true;
                    clip.Enabled = true;
                }
            }
            return state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool api = tmapi.Checked;
                Connection(api ? SelectAPI.TargetManager : SelectAPI.ControlConsole);
            }
            catch
            {
                MessageBox.Show("Please change API selection");
            }
        }
        byte[] wepon1 = { 0x60, 0x00, 0x00, 0x00 };
        byte[] wepon2 = { 0xD1, 0xA3, 0x00, 0xF4 };
        byte[] wepoff1 = { 0xEC, 0x00, 0x68, 0x28 };
        byte[] wepoff2 = { 0x39, 0x6B, 0xFF, 0xFF };
        byte[] wepoff3 = { 0xD3, 0xE3, 0x00, 0xF4 };
        byte[] godon = { 0xD1, 0xA3, 0x00, 0x2C };
        byte[] godoff1 = { 0x7C, 0x7E, 0x1B, 0x78 };
        byte[] godoff2 = { 0xD0, 0x03, 0x00, 0x2C };
        byte[] noclipon = { 0x40, 0x0F };
        byte[] noclipoff = { 0x3F, 0x80 };
        byte[] MAX = { 0x08, 0xCA, 0x5C, 0xFF };
        uint maxmoney = 0x33A01150;
        uint maxlevel1 = 0x33A01108;
        uint maxlevel2 = 0x33A01104;
        uint weapon1 = 0x003790EC;
        uint weapon2 = 0x00128200;
        uint weapon3 = 0x0035B5A4;
        uint god1 = 0x006E207C;
        uint god2 = 0x006E0864;
        uint noclip = 0x00CD60D8;


        UInt32[] Addresses = new UInt32[] { 0x00F2B800, 0x33A01114, 0x00CD60D8 };
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(Addresses[physics.SelectedIndex], speed.Value);
            value.Text = "Current Value: " + speed.Value.ToString();
            if (physics.Text == "Move Speed")
            {
                MOVE.Start();
            }
            else
            {
                MOVE.Stop();
            }
            if (physics.Text == "Jump Speed")
            {
                speed.Minimum = 04;
            }
            if (physics.Text == "Walk Through Walls")
            {
                clip.Enabled = false;
            }
            else
            {
                clip.Enabled = true;
            }

            speed.Maximum = 800;
        }
        private void weapons_CheckedChanged(object sender, EventArgs e)
        {
            if (weapons.Checked)
            {
                PS3.SetMemory(weapon1, wepon1);
                PS3.SetMemory(weapon2, wepon1);
                PS3.SetMemory(weapon3, wepon2);
            }
            else
            {
                PS3.SetMemory(weapon1, wepoff1);
                PS3.SetMemory(weapon2, wepoff2);
                PS3.SetMemory(weapon3, wepoff3);
            }
        }

        private void GOD_CheckedChanged(object sender, EventArgs e)
        {
            if (GOD.Checked)
            {
                PS3.SetMemory(god1, wepon1);
                PS3.SetMemory(god2, godon);
            }
            else
            {
                PS3.SetMemory(god1, godoff1);
                PS3.SetMemory(god2, godoff2);
            }
        }

        private void physics_SelectedIndexChanged(object sender, EventArgs e)
        {
            speed.Value = (Int32)PS3.Extension.ReadFloat(Addresses[physics.SelectedIndex]);
            value.Text = "Current Value: " + speed.Value.ToString();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(clip.Checked)
            {
                PS3.SetMemory(noclip, noclipon);
            }
            else
            {
                PS3.SetMemory(noclip, noclipoff);
            }
        }

        private void MMoney_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(maxmoney, MAX);
        }

        private void MLevel_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(maxlevel1, MAX);
            PS3.SetMemory(maxlevel2, MAX);
        }

        private void JUMP_Tick(object sender, EventArgs e)
        {
            PS3.Extension.WriteFloat(0x33A01114, speed.Value);
            
        }
    }
}
