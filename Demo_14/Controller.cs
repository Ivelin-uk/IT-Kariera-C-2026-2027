using System;
using System.Collections.Generic;
using System.Text;


public class Controller
{
	private readonly Dictionary<string, Category> categories; 

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

	public string AddCategory(List<string> args)
	{
        string name = args[0];
        Category category = new Category(name);

        if(!categories.ContainsKey(name))
        {
            this.categories.Add(name, category);
            return $"Created Category {category.Name}!";
        }

        return $"Category {name} already exists";
	}

	public string AddEventOffer(List<string> args)
	{
        //virtual
        //inperson
        //{name} {eventTitle} {organizer} {ticketPrice} {durationHours} {type} {city или fullyVirtual}
        string name = args[0];
        string eventTitle = args[1];
        string organizer = args[2];
        double ticketPrice = double.Parse(args[3]);     
        int durationHours = int.Parse(args[4]);
        string type = args[5];

        if(categories.ContainsKey(name))
        {
            if(type == "virtual")
            {
                //(string eventTitle, string organizer, double ticketPrice, int durationHours, bool fullyVirtual)
                bool fullyVirtual =  bool.Parse(args[6]);
                VirtualEventOffer virtualEventOffer = new VirtualEventOffer(eventTitle,organizer,ticketPrice,durationHours,fullyVirtual);
                this.categories[name].AddEventOffer(virtualEventOffer);
                return $"Created EventOffer {eventTitle} in Category {name}!";

            }

            if(type == "inperson")
            {
                //string eventTitle, string organizer, double ticketPrice, int durationHours, string city
                string city = args[6];
                InPersonEventOffer virtualEventOffer = new InPersonEventOffer(eventTitle,organizer,ticketPrice,durationHours,city);
                this.categories[name].AddEventOffer(virtualEventOffer);
                return $"Created EventOffer {eventTitle} in Category {name}!";
            }
        }
        
        return $"Category {name} not exists";
       

	}

	public string GetAverageTicketPrice(List<string> args)
	{
        string name = args[0];
        if(categories.ContainsKey(name))
        {
            Category category = this.categories[name];
            double averagePrice = category.AverageTicketPrice();
            return $"The average ticket price is: {averagePrice:F2} BGN";
        }
        else
        {
              return $"Category {name} not exists";
        }
	}

	public string GetOffersAboveDuration(List<string> args)
	{
        string name = args[0];
        int duration = int.Parse(args[1]);
        if(categories.ContainsKey(name))
        {
            Category category = this.categories[name];
            List<EventOffer> offer = category.GetOffersAboveDuration(duration);
            return string.Join(Environment.NewLine, offer);
        }
        else
        {
              return $"Category {name} not exists";
        }
	}

	public string GetOffersWithTicketPrice(List<string> args)
	{
        string name = args[0];
        if(categories.ContainsKey(name))
        {
            Category category = this.categories[name];
            List<EventOffer> offer = category.GetOffersWithTicketPrice();
            return string.Join(Environment.NewLine, offer);
        }
        else
        {
              return $"Category {name} not exists";
        }
	}

}
