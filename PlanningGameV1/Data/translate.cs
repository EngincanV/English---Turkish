//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanningGameV1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class translate
    {
        public int id { get; set; }
        public string english { get; set; }
        public string turkish { get; set; }
        public string type { get; set; }
        public string sentence { get; set; }
        public Nullable<bool> IsTrue { get; set; }
        public Nullable<int> translateLevel { get; set; }
        public Nullable<System.DateTime> level1 { get; set; }
        public Nullable<System.DateTime> level2 { get; set; }
        public Nullable<System.DateTime> level3 { get; set; }
        public Nullable<System.DateTime> level4 { get; set; }
    }
}
