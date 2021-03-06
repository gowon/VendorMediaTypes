﻿namespace VendorMediaTypes.DependencyInjection
{
    using Microsoft.Extensions.DependencyInjection;

    public class VendorMediaTypesBuilder : IVendorMediaTypesBuilder
    {
        internal VendorMediaTypesBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}