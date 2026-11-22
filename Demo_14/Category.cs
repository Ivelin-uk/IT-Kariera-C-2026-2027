using System;
using System.Collections.Generic;
using System.Linq;

public class Category
{
    private string name = string.Empty;
    private List<EventOffer> eventOffers = new List<EventOffer>();

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value.Length >= 2 && value.Length <= 40)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
        }
    }

    public Category(string name)
    {
        this.Name = name;
    }

    public void AddEventOffer(EventOffer offer)
    {
        this.eventOffers.Add(offer);
    }

    public double AverageTicketPrice()
    {
        return this.eventOffers.Average(e => e.TicketPrice);
    }

    public List<EventOffer> GetOffersAboveDuration(int durationHours)
    {
        return this.eventOffers
            .Where(e => e.DurationHours > durationHours && e.DurationHours > 0)
            .OrderByDescending(e => e.DurationHours)
            .ToList();
    }

    public List<EventOffer> GetOffersWithTicketPrice()
    {
        return this.eventOffers
            .Where(e => e.TicketPrice > 0)
            .OrderBy(e => e.Organizer)
            .ToList();
    }

    public override string ToString()
    {
        return $"Category {this.Name}\nTotal Offers: {this.eventOffers.Count}";
    }
}
