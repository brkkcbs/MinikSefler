//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinikSefler.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int Id { get; set; }
        public Nullable<int> EntryDate { get; set; }
        public Nullable<int> EntryTime { get; set; }
        public string EntryBy { get; set; }
        public Nullable<int> UpdateDate { get; set; }
        public Nullable<int> UpdateTime { get; set; }
        public string UpdateBy { get; set; }
        public int UserId { get; set; }
        public int OrderDate { get; set; }
        public Nullable<int> DeliveryDate { get; set; }
        public string OrderNo { get; set; }
        public int AddressId { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public int PaymentType { get; set; }
        public string ShipTrackNo { get; set; }
        public Nullable<double> ShipFee { get; set; }
    }
}