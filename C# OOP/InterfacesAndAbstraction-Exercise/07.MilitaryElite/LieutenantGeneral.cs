using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>();
        }

        public List<Private> Privates { get; set; }

        public override string ToString()
        {
            if (Privates.Count > 0)
            {
                return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Privates:{Environment.NewLine}{string.Join(Environment.NewLine, Privates)}";
            }
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}{Environment.NewLine}Privates:";

        }
    }
}
