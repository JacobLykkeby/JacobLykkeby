using System;

namespace Geometri_CSharp
{
    public class Square
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
        }
        
        public Square()
        {
            this.side = side;
        }

        static void SquareMethod()
        {
            return side * 4;

        }

        static void AreaMethod()
        {
            return side * side;
        }

    class Program
    {
        static void Main(string[] args)
        {
                Square Side = new Square();
                Console.WriteLine($"SquareMethod: {Side.SquareMethod()}" + $"AreaMethod: {Side.AreaMethod()}");
            
      
        }



    }


}
