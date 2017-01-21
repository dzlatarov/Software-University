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
            long totalPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long goodPicturesPercent = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalPicturesFilterTime = totalPictures * filterTime;
            decimal goodPicturesAfterFilter = Math.Ceiling((totalPictures * (goodPicturesPercent * 0.01m)));
            decimal totalUploadTime = uploadTime * goodPicturesAfterFilter;

            decimal totalSecondsNeeded = totalPicturesFilterTime + totalUploadTime;

            TimeSpan cat = TimeSpan.FromSeconds((double)totalSecondsNeeded);
            string answer = string.Format("{0:0}:{1:00}:{2:00}:{3:00}",
                cat.Days,
                cat.Hours,
                cat.Minutes,
                cat.Seconds);

            Console.WriteLine(answer);
        }
    }
}