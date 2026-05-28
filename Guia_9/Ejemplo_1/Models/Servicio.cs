using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1.Models
{
    

    internal class Servicio
    {
        #region atributos
        int Acumulador = 0;
        public int Contador = 0;
        public int Maximo = 0;
        public int Minimo = 0;
        #endregion


        #region metodos

        public Servicio() 
        {
            Acumulador = 0;
            Contador = 0;
        }

        public double CalcularPromedio()
        {
            return (double)Acumulador / Contador;
        }

        public void RegistrarValor(int valor)
        {
            Acumulador += valor;
            Contador++;
            if (Contador == 1)
            {
                Maximo = valor;
                Minimo = valor;
            }
            else
            {
                if (valor > Maximo)
                {
                    Maximo = valor;
                }

                if (valor < Minimo)
                {
                    Minimo = valor;
                }
            }
        }

        #endregion



    }
}
