using System;
using System.Collections.Generic;
using System.Text;

namespace Assimatpolymorphism.Classes
{
    //public class InternationalShipment:Shipment
    //{
    //    #region Attribute
    //    private string destinationcountry;
    //    private decimal customsfee;

    //    #endregion
    //    #region constructor
    //    public InternationalShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, string destinationcountry,decimal customsfee):base(trackingcode,description,weight,deliveryfee,destination)
    //    {
    //        DestinationCountry = destinationcountry;
    //        CustomFee= customsfee;
    //    }
    //    #region properity
    //    public string DestinationCountry {  get;  set; }
        
    //    public decimal CustomFee {  get; set; }
        

    //    #endregion
    //    public override decimal EstimatedCost
    //    {
    //        get {return Deliveryfee + (Weight * 5) +CustomFee; }
    //    }

    //    #endregion
    //    public override void Printshipment()

    //    {
    //        Console.WriteLine();
    //        Console.WriteLine("International Shipment");
    //        Console.WriteLine($"Tracking Code   : {Trackingcode}");
    //        Console.WriteLine($"Description     : {Description}");
    //        Console.WriteLine($"Weight          : {Weight} KG");
    //        Console.WriteLine($"Delivery Fee    : {Deliveryfee} EGP");
    //        Console.WriteLine($"Destination Country :{DestinationCountry}");
    //        Console.WriteLine($"Customs Fee      :{CustomFee}");

    //        Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
    //    }
    //    public virtual void GenerateCustomsReport()
    //    {
    //        Console.WriteLine($"Customs Report for Country: {DestinationCountry}");

    //    }
    //}
}
