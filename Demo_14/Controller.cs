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
            return $"Created Category {category.Name}";
        }

        return $"Category {name} already exists";
	}

	public string AddEventOffer(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

	public string GetAverageTicketPrice(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

	public string GetOffersAboveDuration(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

	public string GetOffersWithTicketPrice(List<string> args)
	{
        //TODO: Implement me...
        throw new NotImplementedException();
	}

}
