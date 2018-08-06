using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dicionario
    {
        private static Dictionary<Tipos, Type> _ClasseEscritor;
        public static Dictionary<Tipos, Type> ClasseEscritor
        {
            get
            {
                _ClasseEscritor = new Dictionary<Tipos, Type>();
                _ClasseEscritor.Add(Tipos.Letra, typeof(EscritorLetra));
                _ClasseEscritor.Add(Tipos.Numero, typeof(EscritorNumero));
                _ClasseEscritor.Add(Tipos.XXX, typeof(EscritorX));
                return _ClasseEscritor;
            }
        }
    }
}
