﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceBryanEcommerce.Shared
{
    public class UserRegister
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required,EmailAddress]
        public string Email { get; set; }=string.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }=string.Empty;
        [Compare("Password",ErrorMessage ="Las Contraseñas no son iguales.")]
        public string ConfirmPassword { get; set; }=string.Empty;

    }
}
