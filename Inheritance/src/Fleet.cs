using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Daryl Crosbie
 * ID: P453055
 * Q: AT1.3
 * 
 * Write 3 derived classes to allow a user to enter the details of three types of Vehicles with their
    attributes. The 4th class is the base class Vehicle which contains the shared attributes and methods.
        • Car (make, model, year, bodyType)
        • Airplane (make, model, year, noEngines, engineType)
        • Boat (make, model, year, length, hullType)
    Make all attributes either private (in derived classes) or protected (in base class) and write accessor
    methods for each attribute.
    Write 2 constructors for each derived class. One with no arguments and the other which accepts
    the values of the attributes in the derived class as arguments.
    Write a Console Application called Fleet.cs which creates and displays 2 of each Vehicle type
*/

namespace Fleet
{
    class Fleet
    {
        static void Main(string[] args)
        {

            Car c2= new Car("BMW", "M3", 1998, "Coupe", "C1234");
            Boat b2 = new Boat("Tugger", "T2", 2010, "B1234", 24, "Big Boy");
            Airplane a2 = new Airplane("Boeing", "A780", 2000, "A1234", 4, "Rolls Royce");
            Vehicle v = new Vehicle();
            //AddCar();
            //AddBoat();
            //AddPlane();

            displayAll(v);
            Console.ReadLine();
        }

        public static void displayAll(object v)
        {
            foreach (Vehicle i in Vehicle.vList)
            {
                i.display();    
            }
        }

        // Display only of type
        public static void display(object v)
        {
            if(v.GetType() == typeof(Car))
            {
                foreach (Vehicle i in Vehicle.vList)
                {
                    if (i.GetType() == typeof(Car))
                    {
                        i.display();
                    }
                }
            }
            else if(v.GetType() == typeof(Boat))
            {
                foreach (Vehicle i in Vehicle.vList)
                {
                    if (i.GetType() == typeof(Boat))
                    {
                        i.display();
                    }
                }
            }
            else
            {
                foreach (Vehicle i in Vehicle.vList)
                {
                    if (i.GetType() == typeof(Airplane))
                    {
                        i.display();
                    }
                }
            } 
        }

        public static void AddCar()
        {
            Car c = new Car();
        }

        public static void AddBoat()
        {
            Boat b = new Boat();
        }

        public static void AddPlane()
        {
            Airplane a = new Airplane();
        }
    }
}
