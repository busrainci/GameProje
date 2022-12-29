using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Saved to db : " + campaing.Name);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Delete to db : ", campaing.Name);
        }

        public void GetAll(List<Campaing> campaings)
        {
            foreach (var campaing in campaings)
            {
                Console.WriteLine("Kampanya Adı : {0}, Kampanya Oranı : %1",campaing.Name, campaing.CampaingRate);
            }
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Updated to db : " + campaing.Name);
        }
    }
}
