using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Decarotor
{

    abstract class Carbase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }
    class PersonalCar : Carbase
    {
        public override string Make { get; set; }

        public override string Model { get; set; }

        public override decimal HirePrice { get; set; }
    }
    class CommercialCar : Carbase
    {
        public override string Make { get; set; }

        public override string Model { get; set; }

        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecarotorBase : Carbase
    {
        Carbase _carBase;
        public CarDecarotorBase(Carbase carbase)
        {
            _carBase = carbase;

        }

    }
    class SpecialOffer : CarDecarotorBase
    {
        private readonly Carbase _carbase;
        public decimal DiscountPercentage { get; set; }
        public SpecialOffer(Carbase carbase)
            : base(carbase)
        {
            _carbase = carbase;
        }
        public override string Make { get; set; }

        public override string Model { get; set; }

        public override decimal HirePrice

        {
            get
            {
                return _carbase.HirePrice - (_carbase.HirePrice * (DiscountPercentage / 100));
            }
            set
            {

            }
        }
    }
}