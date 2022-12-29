using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void delete(Game game);
    }
}
