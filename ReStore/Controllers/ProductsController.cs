using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReStore.Data;
using ReStore.Entities;

namespace ReStore.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }

        [HttpGet] // api/products
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();
        }

        [HttpGet("{id}")] // api/products/id
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            return await context.Products.FindAsync(id);
        }

    }
}
