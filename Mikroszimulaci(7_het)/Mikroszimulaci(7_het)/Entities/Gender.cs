using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulaci_7_het_.Entities
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    
    public class Person
    {
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int NbrOfChildren { get; set; }
        public bool IsAlive { get; set; }

        public Person()
        {
            IsAlive = true;
        }
    }
    public class BirthProbability
    {
        public int Age { get; set; }
        public int NbrOfChildren { get; set; }
        public double Birthprobability { get; set; }
               
    }
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int NbrOfChildren { get; set; }
        public double Deathprobability { get; set; }

    }

}
