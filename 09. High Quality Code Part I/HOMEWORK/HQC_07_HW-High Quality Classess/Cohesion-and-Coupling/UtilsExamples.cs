using CohesionAndCoupling.Utils;
using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine("Test: Extracting the file extension from a given string: ");
            Console.Write(" - from given string 'example': ");
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.Write(" - from given string 'example.pdf': ");
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.Write(" - from given string 'example.new.pdf': ");
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));
            Console.WriteLine();

            Console.WriteLine("Test: Extracting the file name from a given string: ");
            Console.Write(" - from given string 'example': ");
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.Write(" - from given string 'example.pdf': ");
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.Write(" - from given string 'example.new.pdf': ");
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));
            Console.WriteLine();

            Console.WriteLine("Test: Calculating distance: ");
            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                FigureUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                FigureUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));
            Console.WriteLine();

            Console.WriteLine("Test: Calculating for a 3D figure with a width of 3, height of 4, and depth of 5: ");
            FigureUtils.Width = 3;
            FigureUtils.Height = 4;
            FigureUtils.Depth = 5;
            Console.Write(" - calculating volume: ");
            Console.WriteLine("Volume = {0:f2}", FigureUtils.CalcVolume());
            Console.Write(" - calculating XYZ diagonal: ");
            Console.WriteLine("Diagonal XYZ = {0:f2}", FigureUtils.CalcDiagonalXYZ());
            Console.Write(" - calculating XY diagonal: ");
            Console.WriteLine("Diagonal XY = {0:f2}", FigureUtils.CalcDiagonalXY());
            Console.Write(" - calculating XZ diagonal: ");
            Console.WriteLine("Diagonal XZ = {0:f2}", FigureUtils.CalcDiagonalXZ());
            Console.Write(" - calculating YZ diagonal: ");
            Console.WriteLine("Diagonal YZ = {0:f2}", FigureUtils.CalcDiagonalYZ());
        }
    }
}
