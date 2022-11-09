using Assignment2.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace Assignment2.Services
{
    class PoplationDataStore : IHolidayDataStore<Holiday>
    {
        private static string API => "https://canada-holidays.ca/api/v1/holidays?year=2022&optional=false";

        public async Task<IEnumerable<Holiday>> GetHolidaysAsync()
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync($"{API}");

            var apiDetails = AllAPIBuilder(json);

            return apiDetails;
        }
        private List<Holiday> AllAPIBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<dynamic>(json);

            var users = response.holidays;


            var myapidata = new List<Holiday>();

            foreach (var user in users)
            {
                var id = user.id.ToString();

                var date = user.date.ToString();
                var nameEn = user.nameEn.ToString();
                var pnameEn = user.parm.ToString();


                myapidata.Add(new Holiday(id, date , nameEn, pnameEn));

            }

            return myapidata;
        }

       
        public static class UserBuilder
        {

        }
    }
}
