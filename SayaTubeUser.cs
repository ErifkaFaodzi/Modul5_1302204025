using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_13022040205
{
    internal class SayaTubeUser
    {
        int ID;
        List<SayaTubeVideo>UploadedVideos;
        string Username;

        public SayaTubeUser(string profile)
        {
            this.Username = profile;
            Random generate = new Random();
            this.ID = generate.Next(0, 100000);
            List SayaTubeVideo = new List<SayaTubeVideo>();
            UploadedVideos = sayaTubeVideos;
        }
        public void getTotalVideoPlayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo video in this.UploadedVideos)
            {
                dataplayCount = dataplayCount + video.GetPlayCount();
            }
        }
        public void addVideo(SayaTubeVideo data)
        {
            UploadedVideos.Add(data);
        }
        public void printAllVideoPlayCount()
        {
            for(int i = 0; i < this.UploadedVideos.Count; i++)
            {
                Console.WriteLine("Username : " + Username);
                Console.WriteLine("Video : " + (i + 1) + " : " + UploadedVideos[i]);
            }
        }
    }
}
