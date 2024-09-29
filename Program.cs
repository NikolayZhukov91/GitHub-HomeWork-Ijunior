using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityOfNumberOfImages = 3;
            int numberOfimagesInUserAlbum = 52;
            int fullFilledRows;
            int picturesBeyondMeasure;
            fullFilledRows = numberOfimagesInUserAlbum / capacityOfNumberOfImages;
            picturesBeyondMeasure = numberOfimagesInUserAlbum % capacityOfNumberOfImages;

            Console.WriteLine($"Всего заполенных рядов можно вывести: {fullFilledRows}, картинок сверх меры: {picturesBeyondMeasure}");
            Console.ReadKey();
        }
    }
}
