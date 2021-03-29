using AnimaisEInterface.Dominio2;
using AnimaisEInterface.Interface2;
using System;

namespace AnimaisEInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c1 = new Cachorro();
            c1.Nome = "Dog";
            c1.Forca = 7;

            Elefante e1 = new Elefante();
            e1.Nome = "Eleph";
            e1.Forca = 10;

            Girafa g1 = new Girafa();
            g1.Nome = "Gira";
            g1.Forca = 6;

            Leao l1 = new Leao();
            l1.Nome = "Lyon";
            l1.Forca = 9;

           

            UsarPersonagens(c1);
            UsarPersonagens(e1);
            UsarPersonagens(g1);
            UsarPersonagens(l1);
           
            Confronto(c1, l1);




            Console.ReadLine();
        }

        public static void UsarPersonagens(ICompeticao ani)
        {
            Console.WriteLine("Nome: " + ani.Nome + " Força: " + ani.);
            string ataque = ani.AnimalAtaque();
            Console.WriteLine("Atacando com " + ataque);

        }

        public static void Confronto(ICompeticao a1, ICompeticao a2)
        {
            Console.WriteLine("Competição entre " + a1.Nome + " e " + a2.Nome);
            string vencedor = "";
            int forca = 0;

            if (a1.Forca > a2.Forca)
            {
                vencedor = a1.Nome;
                forca = a1.Forca;

            }
            else
            {
                vencedor = a2.Nome;
                forca = a2.Forca;
            }

            Console.WriteLine("O vencedor é " + vencedor + " com a força de " + forca + " de competição. ");
        }


    }
    
}
