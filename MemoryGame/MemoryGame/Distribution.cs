using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class Distribution : CardIcon
    {
        private List<string> lista = new List<string>();
        

        public void DistributeItems() //se ia random  cate o carte din lista
        {
          
            Random random = new Random();
            for (int i = 0; i < 32; i++)
            {
                //creeam o variabila "poz" care contine un numar aleator ce corespunde
                //uneia dintre cartile din lista
                //next returneaza poz
                int poz = random.Next(0, cards.Count);
              
                lista.Add(cards[poz]);
               
                cards.RemoveAt(poz);
            }
        }
        internal  string Get(int i)
        {
            return lista[i];

        }
    }
}
