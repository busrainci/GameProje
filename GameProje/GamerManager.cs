using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class GamerManager : IGameService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer) ///override void yerine
        {
            if (_userValidationService.Validation(gamer) == true)
            {

                Console.WriteLine("doğrulama başarılı ve kayıt oluşturuldu. \n tebrikler...", gamer.FirstName);

            }
            else
            {
                Console.WriteLine("doğrulama başarısız.");
            }
           
        }

        public void Add(Game game)
        {
            throw new NotImplementedException();
        }

        //buradan sonrası  yok
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("oyuncunun kayıtı silindi. \n üzgünüz... ", gamer.FirstName);
        }

        public void delete(Game game)
        {
            throw new NotImplementedException();
        }

        //public void Seel(Gamer gamer, Product product)
        //{
        //    Console.WriteLine(gamer.FirstName, product.GameName ,"oyun satın alındı.");
        //}

        public void Update(Gamer gamer)
        {
            Console.WriteLine("oyuncu  güncellendi. \n başarılar...",gamer.FirstName);
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
