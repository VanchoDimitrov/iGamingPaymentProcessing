namespace iGamingPaymentProcessing
{
    public interface IGamesFactory
    {
        int AddedAvailableGames();
        void AvailableGames();
        IGamesForPlaying PayToPlayGame(string gameName);
    }
}