using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_5_Exercises
{
    class Vehichle : Tyres
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public List<Tyres> Tyre { get; }
        public Vehichle()
        {
            Tyre = new List<Tyres>();
        }

        public void AddTyre(Tyres tyres)
        {
            Tyre.Add(tyres);
        }


        public override string ToString()
        {
            string sVehichle = "Vehicle Name: " + Name + "Model " + Model + "Tyres \n";
            foreach (Tyres tyre in Tyre)
            {
                sVehichle += tyre.ToString() + "\n";
            }

            return sVehichle;



        }


    }
}