﻿using System;
using System.Collections.Generic;

namespace ClassLibrary.Core.Data;

public partial class Role
{
    public int Roleid { get; set; }

    public string Rolename { get; set; } = null!;

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();
}
