using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Büşra" && gamer.LastName == "İNCİ" && gamer.NationalityId == 123456789 && gamer.BrithYear == 1999) 
            {
                return true;
            }
            else
            {
                return false;
            }

           


           


        }
        
    }
}

