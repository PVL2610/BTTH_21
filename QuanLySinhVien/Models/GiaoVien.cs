using System;
using System.Collections.Generic;

namespace QuanLySinhVien.Models;

public partial class GiaoVien
{
    public string Magv { get; set; } = null!;

    public string? Hotengv { get; set; }

    public DateOnly? Dob { get; set; }

    public bool? Gioitinh { get; set; }

    public string? Diachi { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Emaildct { get; set; }

    public string? Madv { get; set; }

    public string? Hocvi { get; set; }

    public string? Chucdanh { get; set; }

    public string? Chucvu { get; set; }

    public string? Password { get; set; }

    public string? Website { get; set; }

    public string? Tenviet { get; set; }

    public string? Status { get; set; }

    public string? Accriht { get; set; }
}
