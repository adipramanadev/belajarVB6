using System;
using System.Collections.Generic;

namespace simpleapi.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Nama { get; set; } = null!;

    public string Harga { get; set; } = null!;
}
