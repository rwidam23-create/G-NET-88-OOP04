using System;
using System.Collections.Generic;
using System.Text;

namespace Assimatpolymorphism.Classes
{
    //public class Shipment
    //{
    //    #region  Attribute
    //    private string trackingcode;
    //    private string description;
    //    private decimal weight;
    //    private decimal deliveryfee;
    //    #endregion

    //    #region constructores
    //    public Shipment(string trackingcode)
    //    {
    //        Trackingcode = trackingcode;
    //        Description = "Unknown";
    //        Weight = 1;
    //        Deliveryfee = 50;
    //        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    //    }
    //    public Shipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
    //    {
    //        Trackingcode = trackingcode;
    //        Description = description;
    //        Weight = (decimal)weight;
    //        Deliveryfee = deliveryfee;
    //        Destination = destination;

    //    }






    //    public string Trackingcode
    //    {
    //        get { return trackingcode; }
    //        private set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                trackingcode = value;
    //        }



    //    }
    //    public string Description
    //    {
    //        get { return description; }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                description = value;
    //        }



    //    }
    //    public decimal Weight
    //    {
    //        get { return weight; }
    //        set
    //        {
    //            if (value > 0)
    //                weight = value;
    //        }


    //    }

    //    public decimal Deliveryfee
    //    {
    //        get { return deliveryfee; }
    //        private set
    //        {
    //            if (value > 0)
    //                deliveryfee = value;
    //        }
    //    }
    //    public DeliveryAddress Destination { get; set; }
    //    public virtual decimal EstimatedCost
    //    {
    //        get { return Deliveryfee + (Weight * 5); }
    //    }




    //    public void UpdateDeliveryFee(decimal newfee)
    //    {
    //        if (newfee > 0) deliveryfee = newfee;

    //    }
    //    public virtual void Printshipment()
    //    {
    //        Console.WriteLine($"Tracking Code: {Trackingcode}");
    //        Console.WriteLine($"Description: {Description}");
    //        Console.WriteLine($"Weight: {Weight}");
    //        Console.WriteLine($"Delivery Fee: {Deliveryfee}");
    //        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
    //        Console.WriteLine($"Estimated Cost: {EstimatedCost}");
    //    }


    //    public void UpdateWeight(decimal newweight)
    //    {
    //        if (newweight > 0)
    //            weight = newweight;
    //    }
    //    public void UpdateWeight(decimal newweight, decimal extrapackingweight)
    //    {
    //        if (newweight > 0)
    //            weight = newweight + extrapackingweight;
    //    } 
    //}
}


       
        

    
