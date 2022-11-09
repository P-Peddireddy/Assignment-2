using System;
using Assignment2.Model;
namespace Assignment2.search
   
{
	public class HolidaysSeachHandlert : SearchHandler
	{

        public IList<Holiday> holidays { get; set; }
        public string NavigationRoute { get; set; }
        public Type NavigationType { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = holidays.Where(holidays => holidays.date.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            var navParam = new Dictionary<string, object>
                {
                    {"HolidayDetailObj",item }
                };
            if (!string.IsNullOrWhiteSpace(NavigationRoute))
            {
                await Shell.Current.GoToAsync(NavigationRoute, navParam);
            }
            else if (NavigationType != null)
            {
                await Shell.Current.GoToAsync(GetNavigationPageName(), navParam);
            }
        }

        string GetNavigationPageName()
        {
            return (Shell.Current as AppShell).Route.FirstOrDefault(route => route.Value.Equals(NavigationType)).Key;
        }
    }
}

