using AutoMapper;
using Core.DTO;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public class AutoEntityMapper : Profile
    {
        public AutoEntityMapper()
        {
            //from db
            CreateMap<GamesEntity, GamesDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.GamesYear, opt => opt.MapFrom(src => src.GamesYear))
                .ForMember(dest => dest.GamesName, opt => opt.MapFrom(src => src.GamesName))
                .ForMember(dest => dest.Season, opt => opt.MapFrom(src => src.Season));
        
            CreateMap<ISet<GamesCompetitorEntity>, List<PersonEventMedalDto>>().AfterMap(
                (src, dest) =>
                {
                    foreach (var gp in src)
                    {
                        foreach (var gp2 in gp.CompetitorEvents)
                        {
                            dest.Add(new PersonEventMedalDto()
                            {
                                Event = gp2.Event.EventName,
                                Person = gp.Person.FullName,
                                MedalId = gp2.MedalId,
                            });
                        }
                    }
                });
            CreateMap<ISet<GamesCompetitorEntity>, List<PersonDto>>()
                .AfterMap((src, dest) =>
                {
                    foreach (var gp in src)
                    {
                        dest.Add(new PersonDto()
                        {
                            Id = gp.Person.Id,
                            FullName = gp.Person.FullName
                        });
                    }
                });
            CreateMap<ISet<GamesCompetitorEntity>, List<EventDto>>()
                .AfterMap((src, dest) =>
                {
                    foreach (var gp in src)
                    {
                        foreach (var gp2 in gp.CompetitorEvents)
                        {
                            dest.Add(new EventDto()
                            {
                                Id = gp2.Event.Id,
                                EventName = gp2.Event.EventName
                            });
                        }
                    }
                });
            //to db
            CreateMap<NewGameDto, GamesEntity>()
                .ForMember(dest => dest.GamesName, opt => opt.MapFrom(src => src.GamesName))
                .ForMember(dest => dest.Season, opt => opt.MapFrom(src => src.Season));
        }
    }
}
