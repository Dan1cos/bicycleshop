﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class User:IdentityUser
    {
        public int Year { get; set; }

    }
}
