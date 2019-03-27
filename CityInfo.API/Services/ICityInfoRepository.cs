using System.Collections.Generic;
using CityInfo.API.Entities;

namespace CityInfo.API.Services{
    public interface ICityInfoRepository{
       IEnumerable<City> GetCities();
       bool CityExists(int cityId);
       City GetCity(int cityId, bool includePointsOfInterest);
       IEnumerable<PointOfInterest> GetPointOfInterestsForCity(int cityId);
       PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);

        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);
        void DeletePointOfInterestForCity(PointOfInterest pointOfInterest);

        bool Save();
    }
}