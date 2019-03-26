using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context) {
            if (context.Cities.Any()) {
                return;
            }

            var cities = new List<City>()
            {
                new City(){
                    Name = "London",
                    Description = "The one with big ben.",
                    PointOfInterests = new List<PointOfInterest>(){
                        new PointOfInterest(){
                            Name = "Big Ben",
                            Description = "A big clock tower."
                        },
                        new PointOfInterest(){
                            Name="London Eye",
                            Description="A big wheel."
                        }
                    }
                },
                new City(){
                    Name = "Nottingham",
                    Description = "The one where Robin Hood lived.",
                    PointOfInterests = new List<PointOfInterest>(){
                        new PointOfInterest(){
                            Name = "Market Square",
                            Description = "A place to kill time on a sunny day."
                        },
                        new PointOfInterest(){
                            Name="Another point",
                            Description="Another point"
                        }
                    }
                },
                new City(){
                    Name="Mansfield",
                    Description="The one where Robin Hood actually lived.",
                    PointOfInterests = new List<PointOfInterest>(){
                        new PointOfInterest(){
                            Name = "Train station",
                            Description = "In case you want to leave Mansfield"
                        },
                        new PointOfInterest(){
                            Name="Four Seasons Mall",
                            Description="Just a place to do some shopping."
                        }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
