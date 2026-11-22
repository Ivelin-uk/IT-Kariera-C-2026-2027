using System;
using System.Collections.Generic;
using System.Text;
public abstract class EventOffer
{
    private string eventTitle;

    public string EventTitle
    {
        get { 
            return this.eventTitle;
        }
        set
        {
            if(value.Length >= 3 && value.Length <= 30)
            {
                this.eventTitle = value;
            }
            else
            {
                throw new ArgumentException("Event title should be between 3 and 30 characters!");
            }
        }
    }

    private string organizer;

    public string Organizer
    {
        get {
            return this.organizer;
        }
        set
        {
            if(value.Length >= 3 && value.Length <= 30)
            {
                this.organizer = value;
            }
            else
            {
                throw new ArgumentException("Organizer should be between 3 and 30 characters!");
            }
        }
    }

    private double ticketPrice;

    public double TicketPrice
    {
        get {
            return this.ticketPrice;
        }
        set { 
            if(value >= 0)
            {
                this.ticketPrice = value;
            }
            else
            {
                throw new ArgumentException("Ticket price should be 0 or positive!");
            }
        }
    }
    
    private int durationHours;

    public int DurationHours
    {
        get {
            return this.durationHours;
        }
        set { 
            if(value >= 10 && value <= 50)
            {
                this.durationHours = value;
            }
            else
            {
                throw new ArgumentException("Duration hours should be between 10 and 50!");
            }
        }
    }

    public EventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours)
    {
        this.EventTitle = eventTitle;
        this.Organizer = organizer;
        this.TicketPrice = ticketPrice;
        this.DurationHours = durationHours;
    }

    public override string ToString()
    {
        return $"Event Title: {this.EventTitle}\nOrganizer: {this.Organizer}\nTicket Price: {this.TicketPrice:F2} BGN\nDuration: {this.DurationHours} hours";
    }

}
