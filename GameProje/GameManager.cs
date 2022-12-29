using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class GameManager : IGameService
    {
        private string gameName;


        public void Add(Game game)
        {
            Console.WriteLine("add to db : " + gameName);
        }

      

        public void delete(Game game)
        {
            Console.WriteLine("delete to db : " + gameName);
        }

       

        public void Update(Game game)
        {
            Console.WriteLine("update to db : " + gameName);

        }
    }
}
