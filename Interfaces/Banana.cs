using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Banana : IFruit
    {
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; set; }
        public Banana()
        {

        }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            IsPeeled = true;
            return $"I peeled a {Name}";
        }

        //these extra classes should go in there their own file
    }
    public class Orange : IFruit
    {
        public string Name { get { return "Orange"; } }

        public bool IsPeeled { get; set; }
        public Orange()
        {

        }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            return "You peeled an orange";
        }
        public string Squeeze()
        {
            return "You squeezed the orange";
        }
    }
    public class Grape : IFruit
    {
        public string Name { get { return "Grape"; } } //readonly

        public bool IsPeeled { get; set; } //false by default since it was not stated


        public string Peel()
        {
            return "Who eats grapes";
        } 
        
    }

}
