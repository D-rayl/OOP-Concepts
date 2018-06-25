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
    //Airplane inherits vehicle
    class Airplane : Vehicle
    {
        //Properties specific to an airplane
        private int numEngines;
        private string engineType;

        //Methods to get and set the private properties
        public int gsNumEngines
        {
            get { return numEngines; }
            set { numEngines = value; }
        }

        public string gsEngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }

        //Default airplane constructor
        public Airplane() : base() {
            newVehicle();
        }

        //Overloaded constructor setting all the properties
        public Airplane(string VMake, string VModel, int VYear, string reg, int VNumEngine, string VEngineType) : base() {
            vehicleMake = VMake;
            vehicleModel = VModel;
            vehicleYear = VYear;
            regNum = reg;
            numEngines = VNumEngine;
            engineType = VEngineType;
            store();
        }
       
        public override void newVehicle()
        {
            base.newVehicle();
            Console.Write("Enter airplane number of engines: ");
            gsNumEngines = int.Parse(Console.ReadLine());
            Console.Write("Enter airplane engine type: ");
            gsEngineType = Console.ReadLine();
            vList.Add(this);
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Number of engines:  "+ gsNumEngines);
            Console.WriteLine("Engine type:        "+gsEngineType);
            Console.WriteLine("");
        }
    }
}
