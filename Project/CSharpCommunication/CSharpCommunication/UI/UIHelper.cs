using CSharpCommunication.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCommunication.UI
{
    public static class UIHelper
    {
        public static void UpdateLabels(Form form, MyStruct data)
        {
            if (form.InvokeRequired)
            {
                form.Invoke((MethodInvoker)(() => UpdateLabels(form, data)));
            }
            else
            {
                form.Controls["labelPosition"].Text = $"Position: {data.lrPosition}";
                form.Controls["labelVelocity"].Text = $"Velocity: {data.lrVelocity}";
                form.Controls["labelAcceleration"].Text = $"Acceleration: {data.lrAcceleration}";
                form.Controls["labelDeceleration"].Text = $"Deceleration: {data.lrDeceleration}";
                form.Controls["labelJerk"].Text = $"Jerk: {data.lrJerk}";
                form.Controls["labelActualPosition"].Text = $"Actual Position: {data.lrActualPos}";
                form.Controls["labelActualVelocity"].Text = $"Actual Velocity: {data.lrActualVelo}";
                form.Controls["labelActualAcceleration"].Text = $"Actual Acceleration: {data.lrActualAcc}";
            }
        }

        public static void UpdateButtonColors(Form form, MyStruct data)
        {
            Button buttonEnable = (Button)form.Controls["buttonEnable"];
            Button buttonDisable = (Button)form.Controls["buttonDisable"];
            Button buttonStart = (Button)form.Controls["buttonStart"];

            buttonEnable.BackColor = data.boEnable ? Color.LightGreen : Color.LightGray;
            buttonDisable.BackColor = data.boEnable ? Color.LightGray : Color.OrangeRed;
            buttonStart.BackColor = data.boStart ? Color.Green : Color.LightGray;
        }
    }
}
