using System;
using System.Collections.Generic;

namespace ExampleApiWithEntityMsSql.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Worker> Workers { get; } = new List<Worker>();
}
