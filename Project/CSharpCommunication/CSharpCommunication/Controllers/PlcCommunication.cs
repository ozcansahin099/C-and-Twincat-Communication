using CSharpCommunication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace CSharpCommunication.Controllers
{
    public class PlcCommunication : IDisposable
    {
        private TcAdsClient adsClient;
        public event EventHandler<MyStruct> DataReceived;
        private int notificationHandle;

        public PlcCommunication()
        {
            adsClient = new TcAdsClient();
        }

        public void Connect()
        {
            adsClient.Connect("", 851);
            notificationHandle = adsClient.AddDeviceNotification(
                "GVL.stData",
                new AdsStream(Marshal.SizeOf(typeof(MyStruct))),
                AdsTransMode.OnChange,
                100,
                10,
                typeof(MyStruct)
            );
            adsClient.AdsNotification += AdsClient_AdsNotification;
        }

        private void AdsClient_AdsNotification(object sender, AdsNotificationEventArgs e)
        {
            AdsStream dataStream = (AdsStream)e.DataStream;
            MyStruct data = ByteArrayToStruct<MyStruct>(dataStream.ToArray());
            DataReceived?.Invoke(this, data);
        }

        public void WriteVariable(string variableName, object value)
        {
            int handle = adsClient.CreateVariableHandle(variableName);
            adsClient.WriteAny(handle, value);
            adsClient.DeleteVariableHandle(handle);
        }

        public void WriteVariableDouble(string variableName, string value)
        {
            if (double.TryParse(value, out double fValue))
            {
                int nVariableHandle = adsClient.CreateVariableHandle(variableName);
                fValue = Convert.ToDouble(value);
                adsClient.WriteAny(nVariableHandle, fValue);
                adsClient.DeleteVariableHandle(nVariableHandle);
            }
            else
            {
                MessageBox.Show("İnvalid value,please entrance a number.");
            }
        }

        private T ByteArrayToStruct<T>(byte[] byteArray) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(byteArray, GCHandleType.Pinned);
            T theStruct = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return theStruct;
        }

        public void Dispose()
        {
            adsClient?.Dispose();
        }
    }

}
