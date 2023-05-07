using ECommerce.Core.Common;

namespace ECommerce.Core.Entities;

public class Product : Base<string>
{
    public string Name { get; set; }

    public string MyProperty { get; set; }
}
