using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3.Models
{
    internal class Servicio
    {

        #region atributos
        public string Nombre0;
        public int NroLibreta0;
        public string Nombre1;
        public int NroLibreta1;
        public string Nombre2;
        public int NroLibreta2;
        private int Orden=0;
        #endregion

        #region metodos
        public void RegistrarNombreYNumeroLibreta(int nroLibreta, string nombre) 
        {
            if (Orden == 0)
            {
                NroLibreta0 = nroLibreta;
                Nombre0 = nombre;
            } 
            else if (Orden == 1)
            {
                if (nroLibreta < NroLibreta0)
                {
                    NroLibreta1 = NroLibreta0;
                    Nombre1 = Nombre0;
                    NroLibreta0 = nroLibreta;
                    Nombre0 = nombre;
                }
                else 
                {
                    NroLibreta1 = nroLibreta;
                    Nombre1 = nombre;
                }
            }
            else if (Orden==2) 
            {
                if (nroLibreta<NroLibreta0) 
                {
                    NroLibreta2 = NroLibreta1;
                    Nombre2 = Nombre1;
                    NroLibreta1= NroLibreta0;
                    Nombre1 = Nombre0;
                    NroLibreta0 = nroLibreta;
                    Nombre0 = nombre;
                }
                else if (nroLibreta < NroLibreta1)
                {
                    NroLibreta2 = NroLibreta1;
                    Nombre2 = Nombre1;
                    NroLibreta1 = nroLibreta;
                    Nombre1 = nombre;
                }
                else 
                {
                    NroLibreta2 = nroLibreta;
                    Nombre2 = nombre;
                }
            }

            Orden++;

        }
        #endregion

    }
}
