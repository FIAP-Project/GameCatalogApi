using GameCatalogApi.Data;
using GameCatalogApi.DTOs;
using GameCatalogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameCatalogApi.Controllers;

[ApiController]
[Route("api/v1/games")]
public class GamesController : ControllerBase
{
    private readonly AppDbContext _context;

    public GamesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Game>> GetAll()
    {
        return Ok(_context.Games);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Game> GetById(int id)
    {
        var game = _context.Games.FirstOrDefault(g => g.Id == id);

        if (game is null)
        {
            return NotFound();
        }

        return Ok(game);
    }

    [HttpPost]
    public ActionResult<Game> Create(GameRequest request)
    {
        var game = new Game
        {
            Id = _context.GetNextId(),
            Title = request.Title,
            Genre = request.Genre,
            Platform = request.Platform,
            Price = request.Price
        };

        _context.Games.Add(game);

        return CreatedAtAction(nameof(GetById), new { id = game.Id }, game);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, GameRequest request)
    {
        var game = _context.Games.FirstOrDefault(g => g.Id == id);

        if (game is null)
        {
            return NotFound();
        }

        game.Title = request.Title;
        game.Genre = request.Genre;
        game.Platform = request.Platform;
        game.Price = request.Price;

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var game = _context.Games.FirstOrDefault(g => g.Id == id);

        if (game is null)
        {
            return NotFound();
        }

        _context.Games.Remove(game);

        return NoContent();
    }
}
