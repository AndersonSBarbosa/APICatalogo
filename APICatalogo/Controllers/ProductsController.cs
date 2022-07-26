﻿using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = _context.Products.ToList();

            if(products is null)
            {
                return NotFound("Produtos não encontrado");
            }
                return products;
        }

        [HttpGet("{id:int}", Name ="ObterProduto")]
        public ActionResult<Product> Get(int Id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == Id);
            if (product is null)
            {
                return NotFound("Produto não encontrado");
            }
            return product;
        }
        [HttpPost]
        public ActionResult Post(Product product)
        {
            if (product is null)
                return BadRequest();

            _context.Products.Add(product);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto", new { id = product.Id }, product);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int Id, Product product)
        {
            if (Id != product.Id)
            {
                return BadRequest();
            }    

            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(product);
        }
        [HttpDelete("{id:int}")]
        public ActionResult<Product> Delete(int Id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == Id);

            if (product is null)
            {
                return NotFound("produto não encontrado");
            }
                

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }

    }
}
