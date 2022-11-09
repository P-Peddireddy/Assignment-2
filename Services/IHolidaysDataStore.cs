using Assignment2.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Assignment2.Services
{
    interface IHolidayDataStore<T>
    {
        Task<IEnumerable<Holiday>> GetHolidaysAsync();
    }
}