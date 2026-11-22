using System;
using System.Collections.Generic;
using System.Text;

public class VirtualEventOffer : EventOffer
{
    private bool fullyVirtual;

    public VirtualEventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours, bool fullyVirtual) : base(eventTitle, organizer, ticketPrice, durationHours)
    {
        this.FullyVirtual = fullyVirtual;
    }

    public bool FullyVirtual
    {
        get {
            return this.fullyVirtual;
        }
        set {
   
            this.fullyVirtual = value;
        }
    }

    public override string ToString()
    {
        string restul = this.FullyVirtual ? "yes" : "no";
        return base.ToString() + "\n" + $"Fully Virtual: {restul}";
    }
}
