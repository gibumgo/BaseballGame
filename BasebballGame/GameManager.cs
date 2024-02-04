
namespace BaseballGame;

public class GameManager
{
    public static DataManager Data = DataManager.Instance();
    public static void Init()
    {
        Input_Random_Integer();
    }

    public static void In_Game_()
    {
        while (true)
        {
            
        }
    }

    public static void Input_Random_Integer()
    {
        int Temp_rand_Index = 0 ;
        Data.n_computer_List.Add(Random_Integer_Spawn(1,10));
        while (Data.n_computer_List.Count < 3)
        {
            Temp_rand_Index = Random_Integer_Spawn(1, 10);
            Computer_List_Input(Temp_rand_Index);
        }
    }

    public static void Computer_List_Input(int CompareIndex)
    {
        bool Compare_Check = false;
        foreach ( int Temp_Value in Data.n_computer_List)
        {
            Compare_Check = Compare_Integer(Temp_Value, CompareIndex);
        }

        if (Compare_Check == true)
        {
            Data.n_computer_List.Add(CompareIndex);
        }
    }
    public static bool Compare_Integer(int ListIndex , int CompareIndex)
    {
        if (ListIndex != CompareIndex)
        {
            return true;
        }
        return false;
    }
    
    public static int Random_Integer_Spawn(int Min , int Max)
    {
        Random random = new Random();
        int Temp_Integer = random.Next(Min, Max);
        return Temp_Integer;
    }
}
