using System;

namespace Sphere_WRM
{
    class Program
    {
        static void Main(string[] args)
        {
			Sphere sphere1 = new Sphere();
            Console.WriteLine("Testing program for Class Sphere");
			Console.WriteLine("Type in Sphere's diameter:");
			String diameter = Console.ReadLine();
			sphere1.setDiameter(int.Parse(diameter));
			Console.WriteLine("Diameter: " + sphere1.getDiameter());
			Console.WriteLine("Surface Area: " + sphere1.getSurfaceArea());
			Console.WriteLine("Volume: " + sphere1.getVolume());
			Console.WriteLine("ToString test: " + sphere1.ToString());
		}

		/**
 * This class models a sphere object
 * @author Wade Muncy
 * @version 1.0
 * 
 * 
 */
		public class Sphere
		{

			private double diameter;

			/**
			 * Empty-argument constructor to put object
			 * into a consistent state.
			 */
			public Sphere()
			{
				diameter = 2.0;
			}//end constructor

			/**
			 * Constructor accepts value of diameter.
			 * Preferred constructor.
			 * @param diameter
			 */
			public Sphere(double diameter)
			{

				this.setDiameter(diameter);

			}//end constructor

			/**
			 * Calculates the volume of the sphere.
			 * @return volume
			 */
			public double getVolume()
			{

				return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

			}//end getVolume

			/**
			 * Calculates the surface area of the sphere.
			 * @return - surface area
			 */
			public double getSurfaceArea()
			{

				return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
			}//end getSurfaceArea


			/**
			 * Getter for diameter
			 * @return
			 */
			public double getDiameter()
			{
				return diameter;
			}//end getDiameter

			/**
			 * Setter for diameter. Checks bound on
			 * formal parameter and resets to 2 if
			 * the value is less than 2.
			 * @param diameter
			 */
			public void setDiameter(double diameter)
			{
				if (diameter < 2)
					this.diameter = 2;
				else
					this.diameter = diameter;
			}//end setDiameter

			
			override public String ToString()
			{
				return "Sphere [diameter=" + diameter + "]";
			}//end toString

		}//end class
	}
}
