using System;
namespace Recuperacion
{
    public class Decorador:OrdenBase
    {
        protected OrdenBase orden;
        public Decorador (OrdenBase orden)
        {
            this.orden = orden;
        }

        public virtual double Calcular()
        {
            return orden.Calcular();
        }
    }
}
