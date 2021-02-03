using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImpl
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
