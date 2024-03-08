using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite
{
    public class Repair
    {
        public Repair(string partName, int houseWorked)
        {
            PartName = partName;
            HoursWorked = houseWorked;
        }
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
