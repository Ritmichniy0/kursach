//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRepair
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repair()
        {
            this.DetailRepair = new HashSet<DetailRepair>();
        }
    
        public int ID_Repair { get; set; }
        public System.DateTime DateRepairBegin { get; set; }
        public Nullable<System.DateTime> DateRepairEnd { get; set; }
        public decimal TotalPrice { get; set; }
        public int Car_ID { get; set; }
    
        public virtual Car Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailRepair> DetailRepair { get; set; }
    }
}
