//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cursach1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Processes
    {
        public int IdProcess { get; set; }
        public int MaterialId { get; set; }
        public int ProductType { get; set; }
        public int DepartmentNumber { get; set; }
        public System.DateTime StartDateWork { get; set; }
        public System.DateTime EndDateWork { get; set; }
        public string IsCompleted { get; set; }
    
        public virtual Departments Departments { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual ProductTypes ProductTypes { get; set; }
    }
}
