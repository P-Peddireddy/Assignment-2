using System;
using Assignment2.Model;
namespace Assignment2.ViewModel
{
    [QueryProperty(nameof(HolidaysDetail), "HolidsayDetailObj")]
    public class HolidayDetailsViewModel : BaseViewModel
    {

        private Holiday _holidayDetail;
        public Holiday HolidaysDetail
        {
            get => _holidayDetail;
            set => SetProperty(ref _holidayDetail, value);
        }
    }
}


