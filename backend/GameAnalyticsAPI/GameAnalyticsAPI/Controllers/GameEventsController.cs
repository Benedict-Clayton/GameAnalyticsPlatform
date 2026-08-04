using GameAnalyticsAPI.Models;
using GameAnalyticsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameAnalyticsAPI.Controllers;

/* 
 * A controller is the part of your application that receives requests from outside and decides what should happen. 
 * A client (Unity game, website, mobile app, etc!) sends a HTTP request. The controller receives that request, processes it, and returns a response.
 * 
 * In Unity terms, a Controller is like a GameManager that only handles incoming messages from outside the game. 
 * It should receive the request, then pass the work to another system that's dedicated to doing that task.
 * 
 * Unlike Unity, which reacts to things inside the program itself, this reacts to things happening OUTSIDE the project.
 * 
 */

[ApiController]
[Route("api/[controller]")]
public class GameEventsController : ControllerBase
{
    private readonly GameEventService gameEventService;

    public GameEventsController(GameEventService gameEventService)
    {
        this.gameEventService = gameEventService;
    }

    [HttpGet] // "When someone wants the events, run this method."
    public ActionResult<List<GameEvent>> GetEvents() 
    {
        return Ok(gameEventService.GetEvents());
    }

    [HttpPost] // "Someone wants to give new information. Basically like a new thing to record."
    public ActionResult<GameEvent> CreateEvent(GameEvent gameEvent)
    {
        gameEventService.CreateEvent(gameEvent);

        return CreatedAtAction(
            nameof(GetEvents),
            new { id = gameEvent.Id },
            gameEvent
        );
    }
}