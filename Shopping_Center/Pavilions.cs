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
    
    public partial class Pavilions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pavilions()
        {
            this.Rents = new HashSet<Rents>();
        }
    
        public string Number_pavilion { get; set; }
        public int id_shopping_center { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public double Area { get; set; }
        public double Price_square_meter { get; set; }
        public double Coeff_add_price { get; set; }
    
        public virtual Shopping_centers Shopping_centers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rents> Rents { get; set; }
    }
}
