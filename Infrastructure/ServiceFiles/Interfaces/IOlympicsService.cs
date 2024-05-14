using Core.DTO;
using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ServiceFiles.Interfaces
{
    public interface IOlympicsService
    {
        GamesDto? FindGameById(int id);
        PagingList<GamesDto>? FindGamesByGamesNamePaged(int page, int size, string gamesName);
        GamesEntity AddGame(NewGameDto gameDto);
        bool DeleteGameById(int id);
    }
}
