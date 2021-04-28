//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreFront.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int ID { get; set; }
        public int GenreID { get; set; }
        public int BandID { get; set; }
        public int StudioID { get; set; }
        public int Length { get; set; }
        public int Tracks { get; set; }
        public Nullable<System.DateTime> YearRecorded { get; set; }
        public int StockStatus { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual StockStatu StockStatu { get; set; }
        public virtual Studio Studio { get; set; }
        public virtual Band Band { get; set; }
    }
}
