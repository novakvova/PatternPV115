using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Builder.Concrate
{
    /// <summary>
    /// Будівльний будує скутери
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "50 кубіків";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2 колеса";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0 немає дверей";
        }
    }
}
