using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessModify
{
   public class ModAddress
    {
        public enum Types { Byte, Short, Float, Double };

        public Int32 address;
        public int type;
        public string name;

        public double min;
        public double max;
        public double value;

        public ModAddress(Int32 address, int type, string name)
        {
            this.address = address;
            this.type = type;
            this.name = name;

            min = 0;
            max = 255;
            value = 255;
        }

        public ModAddress(Int32 address,string name,double min,double max,double value,int type)
        {
            this.address = address;
            this.type = type;
            this.name = name;

            this.min = min;
            this.max = max;
            this.value = value;
        }
    }
}
