using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_JuanGonzalez
{
    class Pantalon : Prenda
    {
        public bool esBermuda;

        public Pantalon(int cantidad, bool calidad, double precio_Base, bool esBermuda) : base(cantidad, calidad, precio_Base)
        {
            this.Cantidad = cantidad;
            this.Calidad = calidad;
            this.precio_Base = precio_Base;
            this.esBermuda = esBermuda;
        }

        public bool Calidad_Prenda { get; internal set; }

        public override double Calcular_precio()
        {
            double Precio_Final = precio_Base;

            if (esBermuda == true)
            {
                Precio_Final -= (precio_Base * .20);
            }
            if (Calidad == true)
            {
                Precio_Final = Precio_Final * Cantidad;
            }
            else if (Calidad == false)
            {
                Precio_Final = (precio_Base * .30) + (Precio_Final * Cantidad);
            }


            return Precio_Final;
        }
    }
}
