﻿using Microsoft.AspNetCore.Http;
using System;

namespace Extensions.SessionExtensions
{
    public static class MyHttpContext
    {
        private static IHttpContextAccessor _accessor;

        public static HttpContext Current => _accessor.HttpContext;

        internal static void Configure(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
    }
}
