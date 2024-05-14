using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using Core.Entities;
using Infrastructure;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<PeopleController> _logger;
        private readonly ApplicationDbContext _context;

        public PeopleController(ILogger<PeopleController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonDetails(int id)
        {
            var person = _context.Persons
                                 .Where(p => p.Id == id)
                                 .Select(p => new
                                 {
                                     fullName = p.FullName,
                                     weight = p.Weight,
                                     height = p.Height,
                                     //events = p.GamesCompetitors.CompetitorEvents
                                               //.Select(ce => new
                                               //{
                                               //    medalName = ce.Medal.MedalName,
                                               //    gameName = ce.GamesCompetitors.Games.GamesName,
                                              //     eventName = ce.Event.EventName
                                              // }).FirstOrDefault()
                                 })
                                 .FirstOrDefault();

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

    }
}
