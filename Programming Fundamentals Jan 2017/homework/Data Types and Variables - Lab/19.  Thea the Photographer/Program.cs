using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int goodPicturesPercent = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long totalPicturesFilterTime = totalPictures * filterTime;
            double goodPicturesAfterFilter = Math.Ceiling((totalPictures * (goodPicturesPercent * 0.01)));
            double totalUploadTime = uploadTime * goodPicturesAfterFilter;

            double totalSecondsNeeded = totalPicturesFilterTime + totalUploadTime;

            TimeSpan cat = TimeSpan.FromSeconds(totalSecondsNeeded);
            string answer = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                cat.Days,
                cat.Hours,
                cat.Minutes,
                cat.Seconds );

            Console.WriteLine(answer);
        }
    }
}
