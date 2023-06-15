using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit_And_Acceptanstestning
{
    public class Calculation
    {
        public string CalType { get; set; }
        public decimal NumberOne { get; set; }
        public decimal NumberTwo { get; set; }
        public decimal Result { get; set; }

        public Calculation(string calType, decimal numberOne, decimal numberTwo, decimal result)
        {
            this.CalType = calType;
            this.NumberOne = numberOne;
            this.NumberTwo = numberTwo;
            this.Result = result;
        }
    }
}
