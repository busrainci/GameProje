using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class SalesManager : ISalesService
    {
        public void Add(Sales sales, Gamer gamer, Game game,Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu" + game.GameName + "adlı oyunu" + sales.Id +"satış numarasıyla almıştır.");
        }

        public void AddWithCampaing(Sales sales, Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu" + game.GameName + "adlı oyunu" + campaing.Name + "adlı kampanya ile" +sales.Id + "satış numarasıyla almıştır.");
        }

        public void Delete(Sales sales, Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu" + game.GameName + "adlı oyunu" + campaing.Name + "adlı kampanya ile" + sales.Id + "satış numarasıyla aldığı ürünü iptal etmiştir.");
        }

        public void GetAll(List<Sales> salesList)
        {
            foreach (var sales in salesList)
            {
                Console.WriteLine("oyun : " + sales);
            }
        }
    }
}
