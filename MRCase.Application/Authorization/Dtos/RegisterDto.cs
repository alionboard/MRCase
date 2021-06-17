﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCase.Application.Authorization.Dtos
{
    public class RegisterDto : BaseAuthDto
    {
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }
    }
}
