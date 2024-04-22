using System;
using System.Collections.Generic;

namespace QuanLySinhVien.Models;

public partial class LopShSv
{
    public string? Masv { get; set; }

    public string? Malsh { get; set; }

    public int? Cursem { get; set; }

    public int? Tichluy { get; set; }

    public int? Gcp { get; set; }

    public int? Ecp { get; set; }

    public string? Status { get; set; }

    public string? Ghichu { get; set; }

    public bool? Cn2 { get; set; }

    public virtual LopSh? MalshNavigation { get; set; }

    public virtual SinhVien? MasvNavigation { get; set; }
}
