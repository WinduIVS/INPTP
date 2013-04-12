using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv3Zavody
{
    class Dog
    {
        Random random = new Random();
        double rychlost;    
        public string jmeno { get; set; }

        public Dog(string name)
        {
            jmeno = name;

        }
        
        public void nastavRychlost()
        {
            rychlost = random.Next(65, 90);            
        }

        
        

    }
}
