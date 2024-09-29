using System;
using System.Collections.Generic;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityImages = 3;
            int ImagesAlbum = 52;
            int fulldRows;
            int picturesMeasure;
            int fullRows = ImagesAlbum / capacityImages;
            picturesMeasure = ImagesAlbum % capacityImages;

            Console.WriteLine($"Всего заполенных рядов можно вывести: {fullRows}, картинок сверх меры: {picturesMeasure}");
            Console.ReadKey();
        }
    }
}
