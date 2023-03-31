using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEcommerceApp.Data.Models;
public class UserDetail
{
    public int Id { get; set; }
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public int UserId { get; set; }
    public User? User { get; set; }
}