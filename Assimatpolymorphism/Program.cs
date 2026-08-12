using Assimatpolymorphism.Classes;

namespace Assimatpolymorphism
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region Question01
            #region(a)
            //Method overloading:same level(one person,same tasks) / static / It depends on Parent
            //Method overriding:multiable level(many person,same tasks) /dynamic/It depends on child
            #endregion
            #region(b)
            //static Binding:refrenece(compile time) / overloading(new)
            //dynamic Binding:object(RunTime)/ overriding(virtual/override)
            #endregion
            #endregion

            #region Question02
            #region(a)
            //The sealed keyword is used to prevent inheritance.
            #endregion
            #region(b)
            //sealed clas:Applied to the entire class/Prevents other classes from inheriting from it
            //Can be applied to standard classes
            //sealed Method:Applied to an individual method/Prevents child classes from overriding
            //(override) the method/Must be used with the override keyword on a inherited method
            #endregion
            #region(c)
            //No=>because:When you mark a method as sealed, you explicitly instruct the compiler to lock its implementation
            //so that any further derived classes cannot provide a new override for it
            //To:Enforces Design Intent/Security & Integrity/Performance.
            #endregion
            #endregion

            #region Part02
            //Console.WriteLine("======================================");
            //Console.WriteLine("Deliverycenter");
            //Console.WriteLine("======================================");
            //Driver drive=new Driver("Ahmed Mohamed");
            //Console.WriteLine($"Driver:{drive}");
            //Console.WriteLine("---------------------------------------");
            
            //DeliveryAddress add=new DeliveryAddress("Cairo","Elharam",10);
            //StandardShipment stand = new StandardShipment("SH001", "Laptop", 3, 80,add);

            
            //   stand.Printshipment();

            //Console.WriteLine("---------------------------");
            //ExpressShipment express = new ExpressShipment("SH002", "Mopile Phone", 2, 60, add,30);
            //express.Printshipment();
            //Console.WriteLine("-------------------------------");
            //InternationalShipment intern = new InternationalShipment("SH003", "Television", 8, 120, add, "Germany", 100);
            //intern.Printshipment();
            //Console.WriteLine("==========================");

            //DeliveryCenter center = new DeliveryCenter("maadi center");
            //center.Driver = drive;
            //center.AddShipment(stand);
            //center.AddShipment(express);
            //center.AddShipment(intern);

            //Console.WriteLine("Delivery Center");
            //Console.WriteLine("======================================");
            //center.Printallshipment ();

            //Console.WriteLine("==========================");
            //Console.WriteLine("Printing Using DeliveryHelper...");
            //Console.WriteLine();
            //DeliveryHelper.PrintShipmentDetails(stand);
            //DeliveryHelper.PrintShipmentDetails(express);
            //DeliveryHelper.PrintShipmentDetails(intern);

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Updating Weight...");
            //Console.WriteLine();
            //Console.WriteLine($"Original Weight : {stand.Weight} KG");
            //stand.UpdateWeight(5);
            //Console.WriteLine($"Updated Weight : {stand.Weight} KG");
            //stand.UpdateWeight(5, 0.5m);
            //Console.WriteLine($"Updated Weight After Packing : {stand.Weight} KG");
            //Console.WriteLine();

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Printing Using Shipment[]...");
            //Console.WriteLine();
            //Shipment[] mixedShipments = { stand, express, intern };
            //foreach (var sh in mixedShipments)
            //{
            //    sh.Printshipment ();
            //}

            //Console.WriteLine("==========================================");
            //Console.WriteLine("Demonstrating Sealed Class and Sealed Method...");
            //Console.WriteLine();
            //CompletedShipment completed = new CompletedShipment("SH004", "Documents", 1, 40, add);
            //completed.Printshipment();

            //PriorityInternationalShipment priority = new PriorityInternationalShipment(
            //    "SH005", "Machinery Part", 15, 200, add, "France", 150);
            //priority.GenerateCustomsReport();

            //Console.WriteLine("==========================================");
            //Console.ReadKey();


            #endregion
        }
    }
}
