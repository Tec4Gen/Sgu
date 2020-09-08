using System;

namespace TaxiManager.Entities
{
    public class WorkItem
    {
        public DateTime WorkDate { get; set; }
        public Car Car { get; set; }
        public Driver Driver { get; set; }

    }
}
