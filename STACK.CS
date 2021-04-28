using System; 
using System.Collections.Generic; 

namespace STACK
{
    class STACKNOTAS 
    {
        List<string> notas = new List<string>(); 




        public void push(string nota)
        {
            this.notas.Add(nota);
        }

        public string Peak()
        {
            return this.notas[this.notas.Count - 1];
        }


    }
}
