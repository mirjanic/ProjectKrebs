using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKrebs
{
    class GameData
    {
        public int Money, Shirts,  LanePosition;
    }

    delegate void GameDataModifier(GameData gd);
}
