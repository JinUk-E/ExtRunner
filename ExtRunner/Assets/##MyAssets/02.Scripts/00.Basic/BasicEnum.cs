namespace RNBExtensions
{
    public class BasicEnum
    {
        // Enum for the game states
        public enum GameState
        {
            MainMenu,
            Playing,
            GameOver
        }
        
        // Enum for the Jump states
        public enum JumpState
        {
            Idle,
            Jumping,
            Top,
            Falling
        }
    }
}
