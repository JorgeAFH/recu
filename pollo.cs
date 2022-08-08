using System;
namespace Recuperacion
{
    public class pollo:Decorador
    {
        public double preciop=1.0;
        public pollo(OrdenBase orden) : base(orden)
        {
            this.orden= orden;
        }

        public override double Calcular()
        {
            var Adicion = base.Calcular()+1.00;
            return Adicion;
        }

    }
}
