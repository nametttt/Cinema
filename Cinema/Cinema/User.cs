//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

        public User(string email, string userPassword, string userRole)
        {
            Email = email;
            UserPassword = userPassword;
            UserRole = "Покупатель";
        }
        public User() { }
    }
}