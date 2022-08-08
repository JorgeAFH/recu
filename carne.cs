using System;
namespace Recuperacion
{
    public class carne:Decorador
    {
        public double preciocar=1.5;
        public carne(OrdenBase orden) : base(orden)
        {
            this.orden = orden;
        }

        public override double Calcular()
        {
            var Adicion = base.Calcular() + 1.5;
            return Adicion;
        }

    }
}
