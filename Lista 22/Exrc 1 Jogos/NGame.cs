using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_1_Jogos
{
    class NGame
    {
        private List<Game> v = new List<Game>();
        private Game g = new Game();
        private PGame p;
        public List<Game> Select() //Lista todos os jogos em ordem alfabética; usar List.OrderBy
        {
            return v.OrderBy(); // Não sei como continuar
        }
        public List<Game> SelectData() //Lista todos os jogos por ordem de compra;
        {
            return v.OrderBy();
        }
        public List<Game> Top10() //Lista os 10 melhores jogos
        {

        }
        public void Insert(Game g) { v.Add(g); }
        public void Update(Game g) { v.Insert(v.IndexOf(g), g); }
        public void Delete(Game g) { v.Remove(g); }
    }
}
