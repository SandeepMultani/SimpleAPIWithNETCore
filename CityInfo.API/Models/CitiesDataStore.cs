using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto(){
                    Id = 1,
                    Name = "London",
                    Description = "The one with big ben.",
                    PointOfInterests = new List<PointOfInterestDto>(){
                        new PointOfInterestDto(){
                            Id=11,
                            Name = "Big Ben",
                            Description = "A big clock tower."
                        },
                        new PointOfInterestDto(){
                            Id=12,
                            Name="London Eye",
                            Description="A big wheel."
                        }
                    }
                },
                new CityDto(){
                    Id=2,
                    Name = "Nottingham",
                    Description = "The one where Robin Hood lived.",
                    PointOfInterests = new List<PointOfInterestDto>(){
                        new PointOfInterestDto(){
                            Id=21,
                            Name = "Market Square",
                            Description = "A place to kill time on a sunny day."
                        },
                        new PointOfInterestDto(){
                            Id=22,
                            Name="Another point",
                            Description="Another point"
                        }
                    }
                },
                new CityDto(){
                    Id=3,
                    Name="Mansfield",
                    Description="The one where Robin Hood actually lived.",
                    PointOfInterests = new List<PointOfInterestDto>(){
                        new PointOfInterestDto(){
                            Id=31,
                            Name = "Train station",
                            Description = "In case you want to leave Mansfield"
                        },
                        new PointOfInterestDto(){
                            Id=32,
                            Name="Four Seasons Mall",
                            Description="Just a place to do some shopping."
                        }
                    }
                }
            };

        }
    }
}
