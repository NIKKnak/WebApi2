using WebApi2.Abstractions;
using WebApi2.Models.Dto;

namespace WebApi2.Query
{
    public class WarehouseItemQuery
    {
        public List<WarehouseItem> GetItems(int warehouseId, [Service] IWarehouseService warehouseService)
        {
            return warehouseService.GetItems(warehouseId);
        }
    }
}
