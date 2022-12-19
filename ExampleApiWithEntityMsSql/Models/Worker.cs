using System;
using System.Collections.Generic;

namespace ExampleApiWithEntityMsSql.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }
}
