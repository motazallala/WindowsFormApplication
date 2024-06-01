﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassFactory.Data.Model;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }
}