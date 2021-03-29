using AnimaisEInterface.Interface2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimaisEInterface.Dominio2
{
    class Girafa : ICompeticao
    {
        public string Nome { get; set ; }
        public int Forca { get; set ; }
        public int Tamanho { get; set; }

        public string AnimalAtaque()
        {
            return "Coice";
        }
    }
}
