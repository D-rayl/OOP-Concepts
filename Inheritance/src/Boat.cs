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
    //Boat inherits vehicle 
    class Boat : Vehicle
    {
        //Properties specific to a boat
        private int length;
        private string hullType;

        //Get and set methods for altering the private methods
        public int gsLength
        {
            get { return length; }
            set { length = value; }
        }

        public string gsHullType
        {
            get { return hullType; }
            set { hullType = value; }
        }

        //Default boat constructor
        public Boat() : base() {
            newVehicle();
        }

        //Overloaded boat constructor, set all the properties
        public Boat(string VMake, string VModel, int VYear, string reg, int VLength, string VHullType) : base()
        {
            vehicleMake = VMake;
            vehicleModel = VModel;
            vehicleYear = VYear;
            regNum = reg;
            length = VLength;
            hullType = VHullType;
            store();
        }

        public override void newVehicle()
        {
            base.newVehicle();
            Console.Write("Enter boat length in feet: ");
            gsLength = int.Parse(Console.ReadLine());
            Console.Write("Enter boat hull type: ");
            gsHullType = Console.ReadLine();
            vList.Add(this);
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Length:             " + gsLength);
            Console.WriteLine("Hull type:          " + gsHullType);
            Console.WriteLine("");
        }
    }
}
