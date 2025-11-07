using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Hikkaba.Web.Controllers.Mvc;

[AllowAnonymous]
[Route("test")]
public sealed class TestController : Controller
{
    [HttpGet("status400")]
    public Results<Ok, BadRequest> Status400()
    {
        return TypedResults.BadRequest();
    }

    [HttpGet("status404")]
    public Results<Ok, NotFound> Status404()
    {
        return TypedResults.NotFound();
    }

    [HttpGet("status500")]
    public Results<Ok, InternalServerError> Status500()
    {
        return TypedResults.InternalServerError();
    }

    [HttpGet("exception")]
    public IActionResult Exception()
    {
        throw new InvalidOperationException("Test exception");
    }
}
