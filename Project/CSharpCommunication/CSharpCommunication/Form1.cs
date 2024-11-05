using CSharpCommunication.Controllers;
using CSharpCommunication.Models;
using CSharpCommunication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace CSharpCommunication
{


    public partial class Form1 : Form
    {
        private PlcCommunication plcComm;

        public Form1()
        {
            InitializeComponent();
            plcComm = new PlcCommunication();
            plcComm.DataReceived += PlcComm_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                plcComm.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        private void PlcComm_DataReceived(object sender, MyStruct data)
        {
            UIHelper.UpdateLabels(this, data);
            UIHelper.UpdateButtonColors(this, data);
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            plcComm.WriteVariable("GVL.stData.boEnable", true);
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            plcComm.WriteVariable("GVL.stData.boEnable", false);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            plcComm.WriteVariable("GVL.stData.boStart", true);
        }



        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {
            plcComm.WriteVariableDouble("GVL.stData.lrPosition", textBoxPosition.Text);
        }

        private void textBoxVelocity_TextChanged(object sender, EventArgs e)
        {
            plcComm.WriteVariableDouble("GVL.stData.lrVelocity", textBoxVelocity.Text);
        }

        private void textBoxAcceleration_TextChanged(object sender, EventArgs e)
        {
            plcComm.WriteVariableDouble("GVL.stData.lrAcceleration", textBoxAcceleration.Text);
        }

        private void textBoxDeceleration_TextChanged(object sender, EventArgs e)
        {
            plcComm.WriteVariableDouble("GVL.stData.lrDeceleration", textBoxDeceleration.Text);
        }

        private void textBoxJerk_TextChanged(object sender, EventArgs e)
        {
            plcComm.WriteVariableDouble("GVL.stData.lrJerk", textBoxJerk.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            plcComm.Dispose();
        }
    }
}
