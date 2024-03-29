﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceBryanEcommerce.Shared
{
    public class UserChangePassword
    {
        [Required,StringLength(100,MinimumLength =6)]
        public string Password { get; set; } =string.Empty;
        [Compare("Password",ErrorMessage ="Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; } =string.Empty;  
    }
}
