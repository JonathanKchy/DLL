using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdenarNumeros;

namespace EjemploDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrdenadorNumerico objOrdenador=new OrdenadorNumerico();
            List<int> listaDesordenada = new List<int>();
            listaDesordenada.Add(1);
            listaDesordenada.Add(3);
            listaDesordenada.Add(5);
            listaDesordenada.Add(7);
            listaDesordenada.Add(2);
            listaDesordenada.Add(4);
            listaDesordenada.Add(6);
            Console.WriteLine("Lista desordenada:");
            Console.WriteLine();
            for(int i = 0; i < listaDesordenada.Count; i++)
            {
                Console.WriteLine(listaDesordenada[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Lista ordenada desendente:");
            Console.WriteLine();

            listaDesordenada=objOrdenador.ordenarDescendente(listaDesordenada);

            for (int i = 0; i < listaDesordenada.Count; i++)
            {
                Console.WriteLine(listaDesordenada[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Lista ordenada ascendente:");
            Console.WriteLine();

            listaDesordenada = objOrdenador.ordenarAscendente(listaDesordenada);

            for (int i = 0; i < listaDesordenada.Count; i++)
            {
                Console.WriteLine(listaDesordenada[i].ToString());
            }

            Console.ReadKey();

        }
    }
}
