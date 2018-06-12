using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using MyProductsAPI.Models;

namespace MyProductsAPI.Controllers
{
    public class ValuesController : ApiController
    {
        Product[] products = new Product[]
{
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product { Id = 3, Name = "Drum", Category = "Toys", Price = 3.75M },
            new Product { Id = 4, Name = "Chair", Category = "Furniture", Price = 3.75M },
            new Product { Id = 5, Name = "XboX", Category = "Toys", Price = 3.75M },
            new Product { Id = 6, Name = "Hammer", Category = "Hardware", Price = 16.99M }
};

        // GET api/values
        [SwaggerOperation("GetAll")]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public HttpResponseMessage Get(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                //return NotFound();
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            //return Ok(product);
            return Request.CreateResponse<Product>(HttpStatusCode.OK, product);
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
