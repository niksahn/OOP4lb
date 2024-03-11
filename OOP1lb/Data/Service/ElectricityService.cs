using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1lb.Data.Services
{
    internal class ElectricityService
    {
        const int PersonK = 10;
        const int AreaK = 100;

       public float CalculatePrice(double persons, float area)
       {
            return PersonK * (float) persons + AreaK * area;
       }
    }
}
