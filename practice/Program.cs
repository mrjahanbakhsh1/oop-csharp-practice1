using System;
namespace program
{
    class circle 
    {
        private double pi = 3.14;
        private double r;

        public double Radius
        {
            get{return r;}
            set{r = value;}
        }
        
        public double circlePrtimeter() {
            return 2*pi*r;
        }

        public double circleArea() {
            return pi*r*r;
        }
    }

    class square
    {
        private int a;

        public int side
        {
            get{return a;}
            set{a = value;}
        }

        public double squarePrtimeter() {
            return 4*a;
        }

        public double squareArea() {
            return a*a;
        }
    }

    class triangle
    {
        private int a;
        private int b;
        private int c;

        public int aSide
        {
            get{return a;}
            set{a = value;}
        }

        public int bSide
        {
            get{return b;}
            set{b = value;}
        }

        public int cSide
        {
            get{return c;}
            set{c = value;}
        }

        public int trianglePerimeter() {
            return a+b+c;
        }

        public double triangleArea() {
            double p = a+b+c/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }

    class trapezius
    {
        private int baseA;
        private int baseB;
        private int c;
        private int d;
        private int h;

        public trapezius(int Aside, int Bside, int Cside, int Dside, int H)
        {
            baseA = Aside;
            baseB = Bside;
            c = Cside;
            d = Dside;
            h = H;
        }

        public int aSide
        {
            get{return baseA;}
            set{baseA = value;}
        }

        public int bSide
        {
            get{return baseB;}
            set{baseB = value;}
        }

        public int cSide
        {
            get{return c;}
            set{c = value;}
        }

        public int dSide
        {
            get{return d;}
            set{d = value;}
        }

        public int height
        {
            get{return h;}
            set{h = value;}
        }

        public int TrapeziusPerimeter() {
            return baseA+baseB+c+d;
        }

        public double TrapeziusArea() {
            return ((baseA+baseB)*h)/2;
        }
        
    }

    class mainProgram
    {
        public static void Main() {
            Console.Write("Enetr => circle:1 - Square:2 - triangle:3 - Trapezius:4 = ");
            int shape = Convert.ToInt32(Console.ReadLine());

            if(shape == 1) {
                int r = Convert.ToInt32(Console.ReadLine());

                circle circ = new circle(); 
                circ.Radius = r;
                Console.WriteLine("Perimeter : " + circ.circlePrtimeter());
                Console.WriteLine("Arae : " + circ.circleArea());

            }else if(shape == 2) {
                int a = Convert.ToInt32(Console.ReadLine());

                square sqr = new square(); 
                sqr.side = a;
                Console.WriteLine("Perimeter : " + sqr.squarePrtimeter());
                Console.WriteLine("Arae : " + sqr.squareArea());

            }else if(shape == 3) {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                if(a+b>c && a+c> b && b+c>a) {
                    triangle tri = new triangle();
                    tri.aSide = a;
                    tri.bSide = b;
                    tri.cSide = c;
                    Console.WriteLine("Perimeter : " + tri.trianglePerimeter());
                    Console.WriteLine("Arae : " + tri.triangleArea());
                }else {
                    Console.WriteLine("It is not triangle!!");
                }

            }else if(shape == 4) {
                int baseA = Convert.ToInt32(Console.ReadLine());
                int baseB = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());

                trapezius trap = new trapezius(baseA,baseB,c,d,height); // way*

                // ! or we can give one by one to our field or the top way(way*) we can use !

                // trap.trapezius(baseA,baseB,c,d,height);
                // trap.aSide = baseA;
                // trap.bSide = baseB;
                // trap.cSide = c;              // another way. we can use this way for all of our classes
                // trap.dSide = d;
                // trap.height = height;

                Console.WriteLine("Perimeter : " + trap.TrapeziusPerimeter());
                Console.WriteLine("Arae : " + trap.TrapeziusArea());
            }else {
                Console.WriteLine("Error!");
            }
        }
    }

}
// created by Mohammad reza jahanbakhsh