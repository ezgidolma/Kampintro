using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(new UserValidationManager());
            gameManager.Add(new Gamer { Ad = "Ezgi", Soyad = "Dolma", TcNo = 12345, DoğumYılı = 2001 });
        }
    }
}
