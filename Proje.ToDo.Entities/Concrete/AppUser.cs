﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int >
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Work> Works { get; set; }

    }
}
