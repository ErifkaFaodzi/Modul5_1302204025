using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_13022040205
{
    internal class SayaTubeVideo
    {
        int ID;
        string Title;
        int PlayCount;

        public SayaTubeVideo()
        {
            Random generate = new Random();
            this.ID = generate.Next(0, 100000);
            this.PlayCount = 0;
        }
        public void IncreaseplayCount(int Angka)
        {
            PlayCount = PlayCount + Angka;
        }
        public int GetPlayCount()
        {
            return PlayCount;
        }
        public string getTitle()
        {
            return Title;
        }
        public void printVideoDetails(object PlayCount)
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("PlayCount : " + PlayCount);
        }
    }
}
