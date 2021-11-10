namespace OODemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Base class ref variable can hold derived type objects or its own objects


            //Shape s = new Shape();
            //s.H = 10;
            //s.W = 5;
            //GetArea(s);

            IShape s = new Rectangle();
            s.H = 10;
            s.W = 5;
            GetArea(s);
            s.Draw();

            s = new Triangle();
            s.H = 10;
            s.W = 5;
            GetArea(s);
            s.Draw();
          


           

        }
        static void GetArea(IShape s)
        {
            System.Console.WriteLine(s.CalculateArea());
        }
    }

    

    interface IShape 
    {
        int H { get; set; }
        int W { get; set; }

          double CalculateArea();
    //    {
    //        System.Console.WriteLine("Calculating area of the Shape");
    //        return H* W;
    //}

    void Draw();
       

    }

     class Rectangle : IShape // IS-A - Realization
    {
        public int H { get; set; }
        public int W { get; set; }

        public double CalculateArea()
        {
            System.Console.WriteLine("Calculating area of Rectangle");
            return H * W;
        }

        public  void Draw()
        {
            System.Console.WriteLine("Drawing Rectangle");
        }
    }

    class Triangle : IShape // IS-A - Realization
        
    {
        public int H { get; set; }
        public int W { get; set;}

        public  double CalculateArea() // non polymarphic
        {
            System.Console.WriteLine("Calculating area of the Triangle");
            return H*W / 2;
        }

        public  void Draw()
        {
            System.Console.WriteLine("Drawing Triangle");
        }
    }
}
