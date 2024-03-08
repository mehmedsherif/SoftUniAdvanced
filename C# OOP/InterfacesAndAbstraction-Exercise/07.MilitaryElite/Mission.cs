using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite
{
    public class Mission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }
        public string CodeName { get; set; }
        public string State { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
