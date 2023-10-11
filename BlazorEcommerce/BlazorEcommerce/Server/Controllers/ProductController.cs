﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laranja",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque mi est, bibendum non consequat in, feugiat sit amet nisi. Nam mattis interdum sapien a egestas.",
                ImageUrl = "https://images.unsplash.com/photo-1611080626919-7cf5a9dbab5b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1935&q=80",
                Price = 1.00m
            },
             new Product
            {
                Id = 2,
                Name = "Cebola",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque mi est, bibendum non consequat in, feugiat sit amet nisi. Nam mattis interdum sapien a egestas.",
                ImageUrl = "https://images.unsplash.com/photo-1618512496248-a07fe83aa8cb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1887&q=80",
                Price = 0.99m
            },
             new Product
            {
                Id = 3,
                Name = "Alface",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque mi est, bibendum non consequat in, feugiat sit amet nisi. Nam mattis interdum sapien a egestas.",
                ImageUrl = "https://plus.unsplash.com/premium_photo-1675011288480-abee1adc561d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1887&q=80",
                Price = 1.99m
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}