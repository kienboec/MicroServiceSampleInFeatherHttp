// add nuget "Microsoft.AspNetCore.App" to a console project
// https://github.com/featherhttp/framework/tree/master/src/FeatherHttp

using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var app = WebApplication.Create(args);
app.MapGet("/", async http =>
{
    await http.Response.WriteAsync(DateTime.Now.ToString("s"));
});

await app.RunAsync();

// curl http://localhost:5000/