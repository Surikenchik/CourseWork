//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseworkv5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair
    {
        public int RepairId { get; set; }
        public int TrainId { get; set; }
        public string Repair1 { get; set; }
        public Nullable<System.DateTime> DateOfRepair { get; set; }
    
        public virtual Trains Trains { get; set; }
    }
}
