using WebApi2.Models.Dto;

namespace WebApi2.Abstractions
{
    public class IWarehouseService
    {
        List<WarehouseItem> GetItems(int warehouseId);
    }
}
