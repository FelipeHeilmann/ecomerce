﻿using Application.Abstractions;
using Domain.Products;
using Domain.Shared;

namespace Application.Products.Query;

public record GetProductByIdQuery(Guid ProductId) : IQuery<Product>;
