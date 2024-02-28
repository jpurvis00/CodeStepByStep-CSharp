using CodeStepByStep_CSharp.Classes_and_Object;

//Write a class of objects named Circle that remembers information about a circle.
//You must include the following public members.It may help you to know that there
//is a constant named Math.PI storing the value of π, roughly 3.14159.

//member name	   type	            description
//new Circle(r)    constructor      constructs a new circle with the given radius as a real number
//Area	           property	        the area occupied by the circle (read-only)
//Circumference	   property	        the distance around the circle (read-only)
//Radius	       property	        the radius as a real number (read-write)
//ToString()	   method	        returns a string representation with radius rounded to 2 digits, such as "Circle(r=2.50)"

//You should define the entire class including the class heading, the private
//fields, and the declarations and definitions of all the public methods, properties,
//and constructor.

namespace CodeStepByStep_CSharp.Classes_and_Object
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * Math.Pow(radius, 2); 
        }

        private double Area { get; set; }
        
        private double Circumference { get; set; }
        
        public double Radius { get; set; }

        public override string ToString()
        {
            return $"Circle\nr={Math.Round(Radius, 2)}\nArea={Math.Round(Area, 2)}\nCircumference={Math.Round(2*Math.PI*Radius, 2)}";
        }
    }
}
