using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrdenarNumeros
{
    public class OrdenadorNumerico
    {
        public List<int> ordenarDescendente(List<int> listaNumeros)
        {
            List<int> ordenados = listaNumeros;
            ordenados.Sort((a, b) =>b.CompareTo(a));
            return ordenados;
        }
        public List<int> ordenarAscendente(List<int> listaNumeros)
        {
            List<int> ordenados = listaNumeros;
            ordenados.Sort((a, b) => a.CompareTo(b));
            return ordenados;
        }
    }
}