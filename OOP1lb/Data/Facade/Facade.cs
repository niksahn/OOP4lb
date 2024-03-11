using OOP1lb.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1lb.Data.Facade
{
    internal class Facade
    {
        ElectricityService ElService;
        WaterService WaterService;
        Zheck zheck;
        public Facade (ElectricityService elService, WaterService waterService, Zheck z)
        {
            ElService = elService;
            WaterService = waterService;
            zheck = z;
        }

        public ServiceInfo GetInfo ()
        {
            return new ServiceInfo
            (
                ElService.CalculatePrice(zheck.NumberHabitians1,zheck.ServiceArea1),
                WaterService.CalculatePrice(zheck.NumberHabitians1, zheck.ServiceArea1)
            );
        }
    }

    internal class ServiceInfo
    {
        public float electricityPrice;
        public float waterPrice;
        public ServiceInfo(float electricityPrice1, float waterPrice1) { electricityPrice = electricityPrice1; waterPrice = waterPrice1; }
    }
}
