using Core.DTO;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.ServiceFiles.Interfaces;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class OlympicSportsController : ControllerBase
    {
        public IOlympicsService _olympicsService { get; set; }
        public OlympicSportsController(IOlympicsService olympicsService)
        {
            _olympicsService = olympicsService;
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<GamesDto> FindGameById(int id)
        {
            var gameDto = _olympicsService.FindGameById(id);
            return gameDto == null ? NotFound() : Ok(gameDto);
        }
        [HttpGet]
        [Route("/name/{gamesName}/paged/{size}/{page}")]
        public ActionResult<PagingList<GamesDto>> GetGameByGamesNamePaged(int page, int size, string gamesName)
        {
            if (size > 50 || size < 1)
                return BadRequest("Wrong Page Size!");
            var gamesDto = _olympicsService.FindGamesByGamesNamePaged(page, size, gamesName);
            return gamesDto == null ? NotFound() : Ok(gamesDto);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddGame(LinkGenerator link, NewGameDto gamesDto)
        {
            var game = _olympicsService.AddGame(gamesDto);
            return Created(link.GetUriByAction(HttpContext, nameof(FindGameById), null, new { id = game.Id }),
            game);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteGameById(int id)
        {
            var deleted = _olympicsService.DeleteGameById(id);
            return deleted == false ? NotFound() : Ok($"Game with id {id} was deleted succesfully!");
        }
    }
}