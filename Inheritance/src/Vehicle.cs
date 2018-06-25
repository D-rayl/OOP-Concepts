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
    class Vehicle
    {
        public static List<Vehicle> vList = new List<Vehicle>();

        //Declared properties for vehicles
        //Set to protected to allow inheriting class to access them
        protected string vehicleMake;
        protected string vehicleModel;
        protected int vehicleYear;
        protected string regNum;

        //Methods, for getting and setting the values
        public string gsMake
        {
            get { return vehicleMake; }
            set { vehicleMake = value; }
        }

        public string gsModel
        {
            get { return vehicleModel; }
            set { vehicleModel = value; }
        }

        public int gsYear
        {
            get { return vehicleYear; }
            set { vehicleYear = value; }
        }

        public string gsReg
        {
            get { return regNum; }
            set { regNum = value; }
        }

        public virtual void newVehicle()
        {
            Console.Write("Enter make: ");
            gsMake = Console.ReadLine();
            Console.Write("Enter model: ");
            gsModel = Console.ReadLine();
            Console.Write("Enter year: ");
            gsYear = int.Parse(Console.ReadLine());
            Console.Write("Enter registration number: ");
            gsReg = Console.ReadLine();
        }

        public void store() {
            vList.Add(this);
        }

        public virtual void display()
        {
            Console.WriteLine("Make:               " + gsMake);
            Console.WriteLine("Model:              " + gsModel);
            Console.WriteLine("Year:               " + gsYear);
            Console.WriteLine("Registration:       " + gsReg);
        }
        
    }
}
