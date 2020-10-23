using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_JuanGonzalez
{
    class Camisa : Prenda
    {
        public bool esManga_Corta;

        public Camisa(int cantidad, bool calidad, double precio_Base, bool esManga_Corta) : base(cantidad, calidad, precio_Base)
        {
            this.Cantidad = cantidad;
            this.Calidad = calidad;
            this.precio_Base = precio_Base;
            this.esManga_Corta = esManga_Corta;
        }

        public override double Calcular_precio()
        {
            double Precio_Final = precio_Base;

            if (esManga_Corta)
            {
                Precio_Final = Precio_Final - (precio_Base * 10/100);
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
