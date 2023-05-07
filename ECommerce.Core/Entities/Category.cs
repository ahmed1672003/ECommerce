using ECommerce.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities;

public class Category : Base<string>
{

    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; }

    public Category()
    {
        Products = new HashSet<Product>();
    }
}
