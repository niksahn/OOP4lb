using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1lb.Data.Services
{
    internal class WaterService
    {
        const int PersonK = 5;
        const int AreaK = 10;
        public float CalculatePrice(double persons, float area)
        {   
            return PersonK * (float) persons + AreaK * area; 
        }
    }
}
