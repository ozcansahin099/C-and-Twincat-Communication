using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCommunication.Models
{
    //Struct data
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MyStruct
    {
        public bool boEnable { get; set; }
        public bool boStart { get; set; }
        public double lrPosition { get; set; }
        public double lrVelocity { get; set; }
        public double lrAcceleration { get; set; }
        public double lrDeceleration { get; set; }
        public double lrJerk { get; set; }

        public double lrActualPos { get; set; }
        public double lrActualVelo { get; set; }
        public double lrActualAcc { get; set; }
    }

}
