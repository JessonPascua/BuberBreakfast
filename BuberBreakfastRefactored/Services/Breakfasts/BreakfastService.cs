
using BuberBreakfastRefactored.Models;
using BuberBreakfastRefactored.ServiceErrors;
using ErrorOr;

namespace BuberBreakfastRefactored.Services.Breakfasts;
public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    // Todo: Save breakfast to database 
    public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);

         return Result.Created;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
       _breakfasts.Remove(id);

       return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
      if (_breakfasts.TryGetValue(id, out var breakfast))
      {
         return breakfast;
      }

      return Errors.BuberBreakfast.NotFound;
    }

    public ErrorOr<UpsertedBreakfast> UpdateBreakfast(Breakfast breakfast)
    {
      var IsNewlyCreated = !_breakfasts.ContainsKey(breakfast.Id);
       _breakfasts[breakfast.Id] = breakfast;

       return new UpsertedBreakfast(IsNewlyCreated);
    }
}