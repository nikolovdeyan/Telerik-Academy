using System;
using Kitchen.Contracts;
using Kitchen.Models;

namespace RefactorIfStatements
{
    public static class Startup
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato();

            // For the first part of the task there are many ways to do it, I used an extension method 
            // for the IIngredient of Task 1 to encapsulate what a potato needs in order for it to be cook-able
            Console.WriteLine("We got a fresh potato, let's check if we can cook it?");
            Console.WriteLine("Can this potato be cooked? {0}", CanBeCooked(potato));
            Console.WriteLine("Ok, let's try to trick it and pass no ingredient: {0}", CanBeCooked(null));
            Console.WriteLine("Let's try to cut it first then! We need a Chef!");

            Chef chefManchev = new Chef();
            chefManchev.Cut(potato);
            Console.WriteLine("Chef, you got it all wrong, you've got to peel the potato first...");
            chefManchev.Peel(potato);
            chefManchev.Cut(potato);
            Console.WriteLine("Can this potato be cooked again? {0}", CanBeCooked(potato));
            Console.WriteLine("Ah, finally! Thank you, Chef!");
            Console.WriteLine("Continue to second part of this task? (enter)");
            Console.ReadLine();

            // For the second part of this task, I extracted the checks into a meaningful method
            Console.WriteLine("Test a playfield of valid coordinates in the range 0, 10");
            Console.WriteLine(" - with coordinates 0, 0, true: {0}", MoveIsValid(0, 0, true));
            Console.WriteLine(" - with coordinates 10, 10, true: {0}", MoveIsValid(10, 10, true));
            Console.WriteLine("Test with invalid coordinates, or false flag for canVisitCell");
            Console.WriteLine(" - with coordinates 0, 0, false: {0}", MoveIsValid(0, 0, false));
            Console.WriteLine(" - with coordinates -1, 5, true: {0}", MoveIsValid(-1, 5, true));
            Console.WriteLine(" - with coordinates 5, -1, true: {0}", MoveIsValid(5, -1, true));
            Console.WriteLine(" - with coordinates 11, 5, true: {0}", MoveIsValid(11, 5, true));
        }

        private static bool CanBeCooked(this IIngredient ingredient)
        {
            bool isCookable = true;

            if (ingredient == null)
            {
                return false;
            }

            if (ingredient.IsRotten)
            {
                isCookable = false;
            }

            if (!ingredient.IsCut)
            {
                isCookable = false;
            }

            return isCookable;
        }

        private static bool MoveIsValid(int posX, int posY, bool canVisitCell)
        {
            const int MinX = 0;
            const int MaxX = 10;
            const int MinY = 0;
            const int MaxY = 10;

            bool posXValid = (posX >= MinX) && (posX <= MaxX);
            bool posYValid = (posY >= MinY) && (posY <= MaxY);

            // Only if all conditions are valid should a move be valid. 
            return canVisitCell && posXValid && posYValid;
        }
    }
}