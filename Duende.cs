using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaRPG
{
    public class Duende : SerMitologico, IRecompensable
    {
        public Duende()
        {
            Nombre = "Duende";
            Vida = 50;
        }
        public override void Atacar ()
        {
            Console.WriteLine("El duende lanza una piedra");
        }
        public void SoltarBotin()
        {
            Console.WriteLine("El duende solto 20 monedas de oro");
        }
    }
}
