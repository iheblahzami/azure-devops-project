﻿using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
           
            _logger = logger ;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            
          return ProductContext.Products; 
                
        }

    }
}

