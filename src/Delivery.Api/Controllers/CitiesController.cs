﻿using Delivery.Api.Entities;
using Delivery.Api.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Api.Controllers;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    private readonly DataContext _dbContext;

    public CitiesController(DataContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    [HttpGet("retrieve-cities-collection")]
    public async Task<IActionResult> GetCitiesCollection()
    {
        var cities = await _dbContext.Cities.ToListAsync();
        return Ok(cities);
    }

    [HttpGet("retrieve-city-by-id/{id}")]
    public async Task<IActionResult> GetCityById(int id)
    {
        var cities = await _dbContext.Cities.FindAsync(id);
        return Ok(cities);
    }
}
