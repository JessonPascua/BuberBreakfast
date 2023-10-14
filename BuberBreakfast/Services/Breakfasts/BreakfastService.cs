using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    // Todo: Save breakfast to database 
    public void CreateBreakfast(Breakfast breakfast)
    {
        
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public void DeleteBreakfast(Guid id)
    {
       _breakfasts.Remove(id);
    }

    public Breakfast GetBreakfast(Guid id)
    {
       return _breakfasts[id];
    }

    public void UpdateBreakfast(Breakfast breakfast)
    {
       _breakfasts[breakfast.Id] = breakfast;
    }
}
