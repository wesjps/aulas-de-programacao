using System;
using System.Collections.Generic;
using System.Text;

namespace HR2.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee (string name, int hours, double valuePerHour,double additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            base.Payment();
            return (Hours * ValuePerHour) + (1.1 * AdditionalCharge);
            
        }

    }
}
