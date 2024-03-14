
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    //Derive from controller base
    //Use dependancy injection to get our store context inside here so that we get access to our products table 
    public class ProductsController : ControllerBase
    {
        //Create a private field in our class and assign that private field to our context 
       
        private readonly StoreContext _context;

        //Create a constructor for our dependancy injection
        public ProductsController(StoreContext context)
        {
            _context = context;
            
        }

        //Create an end point get products from this method
        [HttpGet]

        //Sync Method
        //public actionResult<List<Product>>GetProducts()

        //Var products = context.products.ToList();

        //Return ok(products);

        //Async Method 
        public async Task<ActionResult<List<Product>>>GetProducts() //Public whatever you returning
        {
            //products var will contain a list of products here 
            return await _context.Products.ToListAsync();
        }


        //This will get an individual product
        //Specify id as the parameter we going to get from the route
        [HttpGet("{id}")] //api/products/3

        //public actionresult <product>> GetProduct (int id)
        //{ return.context.Products.Find(id);

        
        public async Task<ActionResult<Product>>GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}