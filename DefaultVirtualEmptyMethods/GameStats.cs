public class GameStats
{
    private ILog log;
    private int continues;

    public GameStats(ILog log)
    {
        this.log = log;
    }

    public void AddCoins(int amount)
    {
        continues += amount;
        log.Info
            ($"You add another continue to the game");
    }
}
