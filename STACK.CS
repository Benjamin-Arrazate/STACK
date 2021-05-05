using System; 
using System.Collections.Generic; 

namespace STACK
{
    class STACKNOTAS 
    {
        List<string> notas = new List<string>(); 



        public int Count
        {
            get => this.notas.Count; 
        }



        public void Push(string nota)
        {
            this.notas.Add(nota); 
        }

        public string Pop()
        {
            if (this.notas.Count == 0)
            {
                return null;
            }

            string value = this.notas[this.notas.Count - 1];

            this.notas.RemoveAt(this.notas.Count - 1); 

            return value; 

        }

        public string Peak()
        {

            if (this.notas.Count == 0)
            {
                Console.WriteLine("No hay elemnetos en el Stack"); 
                return null; 
            }
            else
            {
                return this.notas[this.notas.Count - 1];

            }
        }

        public void PrintStack()
        {
            for (int i = this.notas.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(notas[i]); 
            }
        }


    }
}
