﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Application.Products.Categories.Queries;
using OnlineStore.Domain.Entities.Product;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<Category>> Get(int currentTotal, int pageSize)
        {
            return await _mediator.Send(new GetCategories.Query{ CurrentTotal = currentTotal, PageSize = pageSize });
        }
    }
}