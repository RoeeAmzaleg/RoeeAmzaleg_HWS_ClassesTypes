using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_ClassesTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exr 7
            person p1 = new person("Roee", 38); // כן ניתן ליצור מופעים ממחלקה סגורה
            p1.MyName(); // כן ניתן לקרוא לפונקציה ממחלקה סגורה

            //Exr 8
            //Console.WriteLine("hello from main");
            //Console.WriteLine(School.Type); // 8.e = הודפס הבנאי הסטטי


            //Exr 9
            VeihcleBase c1 = new Car("mazda", 4, 5);
            VeihcleBase c2 = new Car("subaru", 4, 5);
            VeihcleBase c3 = new Car("toyota", 4, 3);
            // c1.GetMaxNumOfPassangers();
            // c1.GetMaxSpeed();

            VeihcleBase m1 = new Motorcycle("kawasaki", 2, 1);
            VeihcleBase m2 = new Motorcycle("honda", 2, 1);
            VeihcleBase m3 = new Motorcycle("vespa", 2, 1);
            // m1.GetMaxNumOfPassangers();
            // m1.GetMaxSpeed();

            VeihcleBase[] vehicles = new VeihcleBase[6];
            vehicles[0] = c1;
            vehicles[1] = c2;
            vehicles[2] = c3;
            vehicles[3] = m1;
            vehicles[4] = m2;
            vehicles[5] = m3;

            Carrier CarrierArray = new Carrier(vehicles);
            foreach (VeihcleBase VehiclesArray in CarrierArray.Vehicles)
            {
                Console.WriteLine(VehiclesArray.ToString());
            }
        }

        #region EXR 7
        public sealed class person
        {
            public string name;
            public int age;
            public person(string name, int age)
            {
                this.name = name;
                this.age = age;

            }
            public void MyName()
            {
                Console.WriteLine("Roee");
            }
            public void MyAge()
            {
                Console.WriteLine(38);
            }
        }
        public class person2 : person // לא ניתן לרשת מחלקה סגורה
        {
            public override string Name; // לא ניתן לרשת שדות ממחלקה סגורה
            public override string Age; // לא ניתן לרשת שדות ממחלקה סגורה
        }
        #endregion


        #region Exr 8
        public static class School 
        {
            public static string Type { get; }

            static School()
            {
                Type = Type;
                Console.WriteLine("Im Static Class");
            }
            static void ClassRoom()
            {
            }
            static void Library()
            {
            }
        }
        #endregion


        #region EXR 9
        abstract class VeihcleBase
        {
            public int NumberOfWeels { get; set; }
            public string Model { get; set; }

            public VeihcleBase(string Model, int NumberOfWeels)
            {
                this.NumberOfWeels = NumberOfWeels;
                this.Model = Model;
            }

            public abstract int GetMaxNumOfPassangers();

            public abstract double GetMaxSpeed();

            public override string ToString()
            {
                return $"{Console.BackgroundColor = ConsoleColor.Red} Car Details: \n the model is: {Model}.\n number of wheels is:  {NumberOfWeels}. \n";
            }
        }
        class Car : VeihcleBase
        {
            public int NumberOfDoors { get; set; }
            double MaxSpeed;
            int MaxNumOfPassangers;

            public Car(string Model, int NumberOfWeels, int NumberOfDoors) : base(Model, NumberOfWeels)
            {
                this.NumberOfDoors = NumberOfDoors;
            }
            public override int GetMaxNumOfPassangers()
            {
                Console.WriteLine("enter number of passangers:");
                MaxNumOfPassangers = int.Parse(Console.ReadLine());
                return MaxNumOfPassangers;
            }
            public override double GetMaxSpeed()
            {
                Console.WriteLine("enter max speed:");
                MaxSpeed = int.Parse(Console.ReadLine());
                return MaxSpeed;
            }
            public override string ToString()
            {
                return base.ToString() + $" number of Doors is: {NumberOfDoors}.";
            }
        }
        class Motorcycle : VeihcleBase
        {
            double MaxSpeed;
            int MaxNumOfPassangers;
            public int NumberOfHandBrakes { get; set; }
            public Motorcycle(string Model, int NumberOfWeels, int NumberOfHandBrakes) : base(Model, NumberOfWeels)
            {
                this.NumberOfHandBrakes = NumberOfHandBrakes;
            }
            public override int GetMaxNumOfPassangers()
            {
                Console.WriteLine("enter number of passangers:");
                MaxNumOfPassangers = int.Parse(Console.ReadLine());
                return MaxNumOfPassangers;
            }
            public override double GetMaxSpeed()
            {
                Console.WriteLine("enter max speed:");
                MaxSpeed = int.Parse(Console.ReadLine());
                return MaxSpeed;
            }
            public override string ToString()
            {
                return base.ToString() + $" number of HandBrakes is: {NumberOfHandBrakes}.";
            }
        }
        class Carrier
        {
            public VeihcleBase[] Vehicles { get; set; }
            public Carrier()
            {

            }
            public Carrier(VeihcleBase[] VehiclesArray)
            {
                Vehicles = VehiclesArray;
            }
            public override string ToString()
            {
                string Str = "";
                foreach (VeihcleBase x in Vehicles)
                {
                    Str += Vehicles.ToString() + "\n";
                }
                return Str;
            }
        }
        #endregion

       

        //#region EXR Exepion
        //public class Costumer
        //{
        //    public static void OrderDish()
        //    {

        //        Costumer c = new Costumer();
        //        c.MakeDish("what is the dish?");
        //    }


        //    public class Chef
        //    {

        //        public static void MakeDish(string Dish)
        //        {
        //            try
        //            {
        //                if (Dish == "pita")
        //                    throw new PitaOutOfRangeExeption("thers not a lot of pitot")
        //            }
        //            catch (PitaOutOfRangeExeption ex)
        //            {

        //            }
        //        }


        //    }
        //}
        //#endregion
    
    }
}
