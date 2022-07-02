using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo
{
    internal class GameManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GameManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Upload(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
