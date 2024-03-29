﻿using Microsoft.Extensions.DependencyInjection;
using NewsApi.Core.AutoMapper;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core
{
    public static class ServiceExtensions
    {
        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperNewsProfile));
        }
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsService>();
        }

    }
}
