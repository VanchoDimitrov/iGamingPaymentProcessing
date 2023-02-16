namespace iGamingPaymentProcessing
{
    public interface IGamesFactory
    {
        int AddedAvailableGames();
        void AvailableGames();
        void PayToPlayGame(string gameName, object gameType);
    }
}