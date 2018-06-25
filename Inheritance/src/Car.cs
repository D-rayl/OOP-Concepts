using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Daryl Crosbie
 * ID: P453055
 * Q: AT1.3
 * */
namespace Fleet
{
    //Car inherits Vehicle
    class Car : Vehicle
    {
        //Car specific property
        private string bodyType;

        //Method for getting and setting the private property
        public string gsBodyType
        {
            get { return bodyType; }
            set { bodyType = value; }
        }

        //Default constructor
        public Car() : base() {
            newVehicle();
        }

        //Overloaded constructor setting all the properties
        public Car(string VMake, string VModel, int VYear, string reg, string VBodyType) : base()
        {
            vehicleMake = VMake;
            vehicleModel = VModel;
            vehicleYear = VYear;
            bodyType = VBodyType;
            regNum = reg;
            store();
        }

        //Methos, displays car details
        public void DisplayCar(Car c)
        {
            Console.WriteLine("Car make: " + gsMake);
            Console.WriteLine("Car model: " + gsModel);
            Console.WriteLine("Car year: " + gsYear);
            Console.WriteLine("Car body type: " + gsBodyType);
            Console.WriteLine("");
        }

        override public void newVehicle()
        {
            base.newVehicle();
            Console.Write("Enter car boby type: ");
            gsBodyType = Console.ReadLine();
            vList.Add(this);
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Body type:          " + gsBodyType);
            Console.WriteLine("");
        }
    }
}
