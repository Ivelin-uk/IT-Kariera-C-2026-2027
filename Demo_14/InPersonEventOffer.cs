using System;
using System.Collections.Generic;
using System.Text;


public class InPersonEventOffer : EventOffer
{
    private string city;

    public string City
    {
        get {
            return this.city;
        }
        
        set
        {
            if(value.Length >= 3 && value.Length <= 30)
            {
                this.city = value;
            }
            else
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
        }
    }

    public InPersonEventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours, string city) : base(eventTitle, organizer, ticketPrice, durationHours)
    {
        this.City = city;
    }

    public override string ToString()
    {   
        return base.ToString() + "\n" + $"City: {this.City}";
    }
}
