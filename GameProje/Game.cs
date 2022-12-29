using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Price { get; set; }//price : fiyat
    }
}
