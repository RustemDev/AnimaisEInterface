using System;
using System.Collections.Generic;
using System.Text;

namespace AnimaisEInterface.Interface2
{
    public interface ICompeticao
    {
        string AnimalAtaque();

        string Nome { get; set; }
        int Forca { get; set; }
    }
}
