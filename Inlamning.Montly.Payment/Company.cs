using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning.Montly.Payment
{
    public class Company
    {
        public string Name { get; set; }
        public double Price { get; set; }


        
        public Company(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string GetInfo()
        {
            return $"{Name}, {Price} kr";
        } 
        
        public override string ToString()
        {
            return GetInfo();
        }
        public string GetCSV()
        {
            return Name + ',' + Price;
        }
        
    }

}
