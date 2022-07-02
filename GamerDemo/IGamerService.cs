using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerDemo
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Upload(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
