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

    
    
    
    #region InputComputer
    public static void Input_Random_Integer()
    {
        int Temp_rand_Index = 0;
        Data.n_computer_List.Add(Random_Integer_Spawn(1, 10));
        while (Data.n_computer_List.Count < 3)
        {
            Temp_rand_Index = Random_Integer_Spawn(1, 10);
            Compare_Value_Input(Temp_rand_Index, Data.n_computer_List);
        }
    }

    public static void Compare_Value_Input(int CompareIndex , List<int> TargetList)
    {
        bool Compare_Check = false;
        foreach (int Temp_Value in TargetList)
        {
            Compare_Check = Compare_Integer(CompareIndex,Temp_Value );
        }
        if (Compare_Check == true)
        {
            TargetList.Add(CompareIndex);
        }
    }

    public static bool Compare_Integer(int CompareIndex,int ListIndex)
    {
        if (ListIndex != CompareIndex)
        {
            return true;
        }
        return false;
    }

    public static int Random_Integer_Spawn(int Min, int Max)
    {
        Random random = new Random();
        int Temp_Integer = random.Next(Min, Max);
        return Temp_Integer;
    }
    #endregion

    #region InputPlayer
    public static void KeyInput()
    {
        
        List<int> Temp_Key_Value = new List<int>();
        Console.Write("숫자를 입력해주세요 : ");
        Temp_Key_Value.Add(Console.Read()-48);
        Temp_Key_Value.Add(Console.Read()-48);
        Temp_Key_Value.Add(Console.Read()-48);
        try
        {
            ThrowMethod(Temp_Key_Value);
            
            List_Input(Temp_Key_Value , Data.n_player_List);
        }
        catch (ArgumentException a)
        {
            Console.WriteLine(a.Message);
        }
    }

    public static void List_Input(List<int> Value_List , List<int> Target_List)
    {
        foreach (int Value in Value_List)
        {
            Target_List.Add(Value);
        }
    }
    
    #region Range_Check
    public static void ThrowMethod(List<int> Temp_List)
    {
        foreach (int Temp_List_Value in Temp_List)
        {
            Value_Range(Temp_List_Value);
        }
    }

    public static int Value_Range(int Value)
    {
        if (1 <= Value && Value <= 9)
        {
            return 0;
        }
        throw new ArgumentException("1~9가아님");
    }
    #endregion
    #endregion
}
