public class GameManager : AtGameSingleton<GameManager>
{
    public static GameManager Instance => instance ?? (instance = new GameManager());
    
    public int WorldSpeed { get; private set; } = 1;
    
}
