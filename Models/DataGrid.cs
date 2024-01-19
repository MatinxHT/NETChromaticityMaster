using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETChromaticityMaster.Models
{
    public  class DataGrid
    {
        public struct DataGridValue
        {
            public int Channel;
            public double ciex;
            public double ciey;
            public double cieu;
            public double ciev;
            public string? TestTime;
        }
    }
}
