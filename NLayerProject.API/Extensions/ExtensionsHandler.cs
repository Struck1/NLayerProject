using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProject.API.DTOs;

namespace NLayerProject.API.Extensions
{
    public static class ExtensionsHandler
    {
        public static void Extensions(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async contex =>
                {
                    contex.Response.StatusCode = 500;
                    contex.Response.ContentType = "application/json";
                    var error = contex.Features.Get<IExceptionHandlerFeature>();

                    if (error != null)
                    {
                        var ex = error.Error;

                        ErrorDto errorDto = new ErrorDto();
                        errorDto.Status = 500;
                        errorDto.Errors.Add(ex.Message);

                        await contex.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));


                    }
                });
            });
        }
    }
}
