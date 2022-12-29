using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProje
{
    internal interface IUserValidationService //kullanıcı doğrulama interfacesı oluşturduk
    {
       bool Validation(Gamer gamer);  //oyuncunun doğrulamasını çalıştır
    }
}
