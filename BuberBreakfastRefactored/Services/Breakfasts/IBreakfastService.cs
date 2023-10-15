using BuberBreakfastRefactored.Models;
using ErrorOr;

namespace BuberBreakfastRefactored.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    void DeleteBreakfast(Guid id);
    void UpdateBreakfast(Breakfast breakfast);
}
