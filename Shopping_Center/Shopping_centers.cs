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
    
    public partial class Shopping_centers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shopping_centers()
        {
            this.Pavilions = new HashSet<Pavilions>();
        }
    
        public int id_shopping_center { get; set; }
        public string Name_shopping_center { get; set; }
        public Nullable<int> Quantity_pavilions { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public double Coeff_add_price { get; set; }
        public int Number_floors { get; set; }
        public byte[] Photo { get; set; }
        public double Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pavilions> Pavilions { get; set; }
    }
}
