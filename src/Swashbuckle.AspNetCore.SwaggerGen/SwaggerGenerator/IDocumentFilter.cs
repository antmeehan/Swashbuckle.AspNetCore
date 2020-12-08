﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.SwaggerGen
{
    public interface IDocumentFilter
    {
        void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context);
    }

    public class DocumentFilterContext
    {
        public DocumentFilterContext(
            IEnumerable<ApiDescription> apiDescriptions,
            ISchemaGenerator schemaGenerator,
            SchemaRepository schemaRepository,
            string documentName = null)
        {
            ApiDescriptions = apiDescriptions;
            SchemaGenerator = schemaGenerator;
            SchemaRepository = schemaRepository;
            DocumentName = documentName;
        }

        public IEnumerable<ApiDescription> ApiDescriptions { get; }

        public ISchemaGenerator SchemaGenerator { get; }

        public SchemaRepository SchemaRepository { get; }

        public string DocumentName { get; }
    }
}
