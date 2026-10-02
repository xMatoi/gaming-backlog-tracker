using Microsoft.AspNetCore.Mvc;
using GamingBacklogTracker.Application.Interfaces;
using GamingBacklogTracker.Domain.Entities;

namespace GamingBacklogTracker.API.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class HabitosController : ControllerBase {
    private readonly IGamingRepository _repository;

   
    public HabitosController(IGamingRepository repository) {
        _repository = repository; 
    }

    
    [HttpGet]
    public async Task<IActionResult> GetHabitos() {
        var backlog = await _repository.GetAllAsync();
        return Ok(backlog); // HTTP 200 OK
    }

    
    [HttpPost]
    public async Task<IActionResult> CrearHabito([FromBody] GamingGlobal habito) {
        if (string.IsNullOrWhiteSpace(habito.Nombre)) {
            return BadRequest("El nombre del hábito es obligatorio."); // HTTP 400 Bad Request
        }

        var nuevoJuego = await _repository.AddAsync(habito);
        
        // HTTP 201 Created: Devuelve el recurso recién creado por cortesía RESTful
        return CreatedAtAction(nameof(GetHabitos), new { id = nuevoJuego.Id }, nuevoJuego);
    }
}
