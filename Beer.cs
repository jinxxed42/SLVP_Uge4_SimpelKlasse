using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Uge4_SimpelKlasse
{
    internal class Beer
    {
        public string name;
        public int size;
        public int price;

        public Beer(string name, int size, int price)
        {
            this.name = name;
            this.size = size;
            this.price = price;
        }



        public string ToString()
        {
            return "Navn: " + name + " Størrelse: " + size + "cL. Pris: " + price + "kr.";
        }

        public int GetPrice()
        {
            return price;
        }

    }
}
