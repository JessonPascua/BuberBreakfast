using ErrorOr;

namespace BuberBreakfast.ServiceErrors;
public static class Errors
{
    public static class BuberBreakfast
    {
        public static Error NotFound => Error.NotFound(
            code: "BuberBreakfast.NotFound",
            description: "BuberBreakfast not found");
    }
}