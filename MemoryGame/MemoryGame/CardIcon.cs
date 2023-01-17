using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class CardIcon
    {
        protected List<string> cards;
        
        public CardIcon()
        {
            cards = new List<string>()//lista cu "imaginile" cartilor
            {
                "e","Z", "s", "+" ,"Q" ,"j", "d", "b", "c", "l" ,"k", "V", "8", "O", "Y", "x",
                 "e","Z", "s", "+" ,"Q" ,"j", "d", "b", "c", "l" ,"k", "V", "8", "O", "Y", "x"
            };
        }
    }
}
