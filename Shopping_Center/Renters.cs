//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopping_Center
{
    using System;
    using System.Collections.Generic;
    
    public partial class Renters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renters()
        {
            this.Rents = new HashSet<Rents>();
        }
    
        public int id_renter { get; set; }
        public string Name_renter { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Additional_info { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rents> Rents { get; set; }
    }
}
