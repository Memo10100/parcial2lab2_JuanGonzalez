using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_JuanGonzalez
{
    abstract class Prenda
    {
        protected Prenda(int cantidad, bool calidad, double precio_Base)
        {
            Cantidad = cantidad;
            Calidad = calidad;
            this.precio_Base = precio_Base;
        }

        public int Cantidad { get; internal set; }
        public bool Calidad { get; internal set; }
        public double precio_Base { get; internal set; }


        public abstract double Calcular_precio();
        //double Precio_Base, int Cantidad, bool Calidad, bool esManga_Corta

    }
}
