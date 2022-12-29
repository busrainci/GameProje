using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal interface ISalesService
    {
        void Add(Sales sales, Gamer gamer, Game game,Campaing campaing);
        void AddWithCampaing(Sales sales, Gamer gamer, Game game, Campaing campaing);
        void Delete(Sales sales, Gamer gamer, Game game, Campaing campaing);
        void GetAll(List<Sales> salesList);
    }
}
