using AnimaisEInterface.Interface2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimaisEInterface.Dominio2
{
    class Elefante : ICompeticao
    {
        public string Nome { get ; set ; }
        public int Forca { get ; set; }

        public string AnimalAtaque()
        {
            return "Sopro";
        }
    }
}
