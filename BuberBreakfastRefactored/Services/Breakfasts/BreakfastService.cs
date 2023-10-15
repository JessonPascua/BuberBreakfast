
using BuberBreakfastRefactored.Models;
using BuberBreakfastRefactored.ServiceErrors;
using ErrorOr;

namespace BuberBreakfastRefactored.Services.Breakfasts;
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

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
      if (_breakfasts.TryGetValue(id, out var breakfast))
      {
         return breakfast;
      }

      return Errors.BuberBreakfast.NotFound;
    }

    public void UpdateBreakfast(Breakfast breakfast)
    {
       _breakfasts[breakfast.Id] = breakfast;
    }
}