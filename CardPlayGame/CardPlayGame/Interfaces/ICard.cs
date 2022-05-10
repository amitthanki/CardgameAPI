using CardPlayGame.Services;

namespace CardPlayGame.Interfaces
{
    public interface ICard
    {
        List<String> GetRandomCard();
        List<String> GetSortedResult(List<string> str);
    }
}
