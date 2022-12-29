
using GameProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Console.WriteLine("---------- YENİ OYUNCU -------------");

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Büşra",
                LastName = "İNCİ",
                NationalityId = 123456789,
                BrithYear = 1999,

            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Yaser",
                LastName = "ULUTÜRK",
                NationalityId = 987654321,
                BrithYear = 1998,


            };
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            Console.WriteLine("---------YENİ OYUN---------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game() { Id = 1, GameName = "Pubg", Price = "100"};
            Game game2 = new Game() { Id = 2, GameName = "Okey", Price = "50" };
            Game game3 = new Game() { Id = 3, GameName = "Monopoly", Price = "250"};
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Console.WriteLine( "--------KAMPANYA EKLEME VE GÜNCELLEME---------");

            CampaingManager campaingManager = new CampaingManager();
            Campaing campaing = new Campaing {Id = 5, Name = "yeni oyuncu", CampaingRate = 6 };
            campaingManager.Update(campaing);

            Console.WriteLine("----------YENİ SATIŞLAR-----------");
            SalesManager salesManager = new SalesManager();
            Sales sales1 = new Sales { Id=101, CampaingName = campaing.Name, GameName= game1.GameName, 
                GamerName = gamer1.LastName, DiscountRate= campaing.CampaingRate, GamePrice= game1.Price};

            salesManager.Add(sales1, gamer1, game1, campaing);

            Console.WriteLine("---------KAMPANYA GÜNCELLEMESİ---------");

            campaingManager.Update(new Campaing { Name = campaing.Name, CampaingRate = 15 });

            Console.WriteLine("----------KAMPANYA SİLİNMESİ----------");

            campaingManager.Delete(campaing);


            Console.ReadLine();
        }
    }
}
