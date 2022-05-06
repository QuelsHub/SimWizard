using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimWizard
{
    class Sim
    {

        public string ID { get; set; }
        public string Pin { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int NumberOfActivations { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }


        public override string ToString()
        {
            return $"{ID}, {Status}, {Type}, {Name}, {ValidFrom}";
        }

    }

}

