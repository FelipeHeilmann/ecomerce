using ProjectionWorker.Context;
using ProjectionWorker.Gateway;
using ProjectionWorker.Queue;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IQueue, RabbitMQAdapter>(provider =>
{
    var rabbitMQAdapter = new RabbitMQAdapter(builder.Configuration);
    rabbitMQAdapter.Connect();
    return rabbitMQAdapter;
});

builder.Services.AddHostedService<QueueController>();
builder.Services.AddSingleton<OrderContext>();

builder.Services.AddSingleton<IOrderGeteway, OrderGatewayHttp>();

var host = builder.Build();
host.Run();
