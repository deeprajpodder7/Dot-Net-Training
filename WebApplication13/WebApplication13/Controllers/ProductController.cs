using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
        {
        IProductDetails m_productDetails;
        public ProductController(IProductDetails productDetails)   ///new productDetails()
            {
            m_productDetails = productDetails;
            }
        //GET:api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
            {
            return m_productDetails.GetProducts();   //localhost:1234/api/employees 
            }
        }
    }
