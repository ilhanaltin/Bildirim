﻿using System;
using System.Linq;

namespace Bildirim.Common.Helpers
{
    public static class ExceptionHelper
    {
        public static string GetExceptionDetails(Exception exception)
        {
            var properties = exception.GetType()
                .GetProperties();
            var fields = properties
                .Select(property => new
                {
                    Name = property.Name,
                    Value = property.GetValue(exception, null)
                })
                .Select(x => String.Format(
                    "{0} = {1}",
                    x.Name,
                    x.Value != null ? x.Value.ToString() : String.Empty
                ));
            return String.Join("\n", fields);
        }
    }
}
