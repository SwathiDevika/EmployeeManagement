//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagement.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manager
    {
        public int ManagerID { get; set; }
        public Nullable<int> PersonalID { get; set; }
        public Nullable<decimal> AnnualSalary { get; set; }
        public Nullable<decimal> MaxExpenseAmount { get; set; }
    
        public virtual PersonalDetail PersonalDetail { get; set; }
    }
}
