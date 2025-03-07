using Microsoft.AspNetCore.Mvc;
using WiredBrainApi.Services;

namespace WiredBrainApi.Controllers;

[ApiController]
[Route("[controller]")]
public class InventoryController(IInventoryService inventoryService) : ControllerBase
{
    private readonly IInventoryService _inventoryService = inventoryService;

    [HttpGet("{id}")]
    public ActionResult<LocationInventory> Get(int id)
    {
        var inventory = _inventoryService.GetLocationInventory(id);
        if (inventory == null)
        {
            return NotFound();
        }

        return inventory;
    }
}
