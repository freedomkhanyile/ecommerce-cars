using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ecommerce.Api.Filters
{
    public class CustomSwaggerDocumentAttribute : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Info = new OpenApiInfo
            {
                Title = "Ecommerce Api",
                Version = "v1.0.0",
                Description = "Services and apis",
                Contact = new OpenApiContact
                {
                    Name = "Freedom Khanyile",
                    Email = "freedom.khanyile1@gmail.com"
                }
            };
        }
    }
}
