﻿using Application.Abstractions;
using Domain.Orders;
using Domain.Shared;

namespace Application.Orders.Query.GetCart;

public class GetCartQueryHandler : IQueryHandler<GetCartQuery, Order>
{
    private readonly IOrderRepository _repository;

    public GetCartQueryHandler(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Order>> Handle(GetCartQuery query, CancellationToken cancellationToken)
    {
        var orders = await _repository.GetAllAsync();

        var cart = orders.FirstOrDefault(o => o.Status == OrderStatus.Created);

        if (cart == null) return Result.Failure<Order>(OrderErrors.CartNotFound);

        return Result.Success(cart);
    }
}
