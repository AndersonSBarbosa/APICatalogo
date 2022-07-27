using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductTypeController(AppDbContext context)
        {
            _context=context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ProductType>> Get()
        {
            var productsType = _context.ProductTypes.ToList();
            return productsType;
        }

        [HttpGet("{id:int}", Name = "ObterTipoProduto")]
        public ActionResult<ProductType> Get(int Id)
        {
            var productsType = _context.ProductTypes.FirstOrDefault(p => p.Id == Id);
            if (productsType is null)
            {
                return NotFound("Produto não encontrado");
            }
            return productsType;
        }
        [HttpPost]
        public ActionResult Post(ProductType productsType)
        {
            if (productsType is null)
                return BadRequest();

            _context.ProductTypes.Add(productsType);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterTipoProduto", new { id = productsType.Id }, productsType);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int Id, ProductType productsType)
        {
            if (Id != productsType.Id)
            {
                return BadRequest();
            }

            _context.Entry(productsType).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(productsType);
        }
        [HttpDelete("{id:int}")]
        public ActionResult<ProductType> Delete(int Id)
        {
            var productsType = _context.ProductTypes.FirstOrDefault(p => p.Id == Id);

            if (productsType is null)
            {
                return NotFound("Tipo de produto não encontrado");
            }


            _context.ProductTypes.Remove(productsType);
            _context.SaveChanges();
            return Ok();
        }

    }
}
