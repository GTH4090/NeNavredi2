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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.EnterHistory = new HashSet<EnterHistory>();
            this.UserService = new HashSet<UserService>();
        }
    
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Bookkeeper Bookkeeper { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnterHistory> EnterHistory { get; set; }
        public virtual ExplorerEmployee ExplorerEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserService> UserService { get; set; }
    }
}
