//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NeNavredi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderService = new HashSet<OrderService>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int StatusId { get; set; }
        public int Time { get; set; }
        public int ClientId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public int Code { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual StatusId StatusId1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderService> OrderService { get; set; }
    }
}
