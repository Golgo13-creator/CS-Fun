using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //this is our contract
    //anything that implements IFruit must do all of its methods and have all of its properties etc. 
    interface IFruit
    {
        string Name { get; } //readonly
        bool IsPeeled { get; set; }
        string Peel();

       
    }
}
