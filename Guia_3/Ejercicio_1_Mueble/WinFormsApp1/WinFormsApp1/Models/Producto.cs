using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    abstract public class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

        abstract public double CalcularPrecio(); /*el abstrac solo se nombra*/

        virtual public string VerDetalle()
        {
            string material = "NN";
            if (tipoMaterial == 0)
            {
                material = "Pino";
            }
            else if (tipoMaterial == 1)
            {
                material = "Algarrobo";
            }
            else
            {
                material = "Caoba";
            }
            return $"{descripcion,15}{material,10}{precioBase,10:f2}";
        }









    }
}
