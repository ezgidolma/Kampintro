using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo
{
    internal class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
       
        if (gamer.DoğumYılı==2001&& gamer.Ad=="Ezgi"&&gamer.Soyad=="Dolma"&&gamer.TcNo==12345)
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
