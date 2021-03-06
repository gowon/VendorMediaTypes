﻿namespace WebApiExample.Queries
{
    using MediatR;
    using Models;
    using VendorMediaTypes;

    [MediaType("application/vnd.ping+json", "application/vnd.health-check+json")]
    public class Ping : IRequest<Pong>
    {
        public string Message { get; set; }
    }
}