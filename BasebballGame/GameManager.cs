namespace BaseballGame;

public class GameManager
{
    public static void Init()
    {
        
    }

    public static void In_Game_()
    {
        while (true)
        {
            
        }
    }
    
    public static int Random_Integer_Spawn(int Min , int Max)
    {
        Random random = new Random();
        int Temp_Integer = random.Next(Min, Max);
        return Temp_Integer;
    }

    
}