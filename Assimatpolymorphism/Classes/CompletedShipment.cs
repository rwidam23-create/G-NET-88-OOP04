using System;
using System.Collections.Generic;
using System.Text;

namespace Assimatpolymorphism.Classes
{
    public sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(string trackingcode, string description, double weight, decimal deliveryfee, DeliveryAddress destination):base(trackingcode, description, weight, deliveryfee, destination)
        {
            
        }

    }
}
