using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite
{
    public interface ICommando
    {
        public List<Mission> Missions { get; set; }
    }
}
