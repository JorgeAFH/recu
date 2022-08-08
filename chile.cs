using System;
namespace Recuperacion
{
    public class chile : Decorador
    {
        public double precioc=0.5;
        public chile(OrdenBase orden) : base(orden)
        {
            this.orden = orden;
        }

        public override double Calcular()
        {

            var Adicion = base.Calcular() + 0.50;

            return Adicion;


        }
    }
}