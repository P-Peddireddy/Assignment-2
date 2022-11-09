using System;
namespace Assignment2.Model
{
	public class HolidayModel
	{
		
       public string  Date { get; set; }
           public string NameEn { get; set; }
           public string  PnameEn { get; set; }


        public HolidayModel( string date, string nameEn, string pnameEn)
        {
          
            Date = date;
            NameEn = nameEn;
            PnameEn = pnameEn;
        }
    }
}

