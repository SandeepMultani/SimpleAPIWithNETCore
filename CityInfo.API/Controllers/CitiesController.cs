using AutoMapper;
using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {

        private ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            //return Ok(CitiesDataStore.Current.Cities);
            var cityEntities = _cityInfoRepository.GetCities();
            //var results = new List<CityWithoutPointsOfInterestDto>();

            /* foreach (var cityEntity in cityEntities)
            {
                results.Add(new CityWithoutPointsOfInterestDto()
                {
                    Id = cityEntity.Id,
                    Description = cityEntity.Description,
                    Name = cityEntity.Name
                });
            }
            */
            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities);
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            /* 
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
*/
            var city = _cityInfoRepository.GetCity(id, includePointsOfInterest);
            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                /* 
                var cityResult =
                new CityDto()
                {
                    Id = city.Id,
                    Description = city.Description,
                    Name = city.Name
                };

                foreach (var poi in city.PointOfInterests)
                {
                    cityResult.PointOfInterests.Add(
                        new PointOfInterestDto()
                        {
                            Id = poi.Id,
                            Name = poi.Name,
                            Description = poi.Description
                        }
                    );
                }
                */
            var cityResult = Mapper.Map<CityDto>(city);
                return Ok(cityResult);
            }

/*
            var CityWithoutPointsOfInterestResult =
            new CityWithoutPointsOfInterestDto()
            {
                Id = city.Id,
                Description = city.Description,
                Name = city.Name
            };

            */

            var CityWithoutPointsOfInterestResult = Mapper.Map<CityWithoutPointsOfInterestDto>(city);


            return Ok(CityWithoutPointsOfInterestResult);
        }



    }
}
