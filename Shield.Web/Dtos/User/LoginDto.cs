﻿using System.ComponentModel.DataAnnotations;

namespace Shield.Web.Dtos.User;

public class LoginDto
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}