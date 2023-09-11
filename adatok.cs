using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    internal class balkezxd
    {
        public string playa {  get; set; }
        public string firstA { get; set; }
        public string lastA { get; set; }
        public int weight { get; set; }
        public int height { get; set; }

        public balkezxd(string playerName, string firstAppearance, string lastAppearance, int playerWeight, int playerHeight)
        {
            playa = playerName;
            firstA = firstAppearance;
            lastA = lastAppearance;
            weight = playerWeight;
            height = playerHeight;
        }
    }
}
