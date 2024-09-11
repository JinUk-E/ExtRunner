public class GameManager : AtGameSingleton<GameManager>
{
    public static GameManager Instance => instance ?? (instance = new GameManager());
    
    public float WorldSpeed { get; private set; } = 0.8f;
    
}
