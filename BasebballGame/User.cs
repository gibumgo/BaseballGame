namespace BaseballGame;

public class User
{
    public static DataManager Data = DataManager.Instance();

    public bool ToInput_KeyValue()
    {
        string input;
        bool Input_Check;
        List<int> Temp_Key_Value = new List<int>();
        Console.Write("숫자를 입력해주세요 : ");
        input = Console.ReadLine();

        foreach (var Value in input)
        {
            Temp_Key_Value.Add(Value - 48);
        }

        Data.n_player_List.Clear();
        Input_Check = ExceptionCheck(Temp_Key_Value, 3, 1, 9);

        if (Input_Check == true) List_Input(Temp_Key_Value, Data.n_player_List);

        return Input_Check;
    }

    public bool ExceptionCheck(List<int> Temp_Key_Value, int Length, int Min, int Max)
    {
        try
        {
            ToCheck_InputList_Length(Temp_Key_Value, Length);
            ToCompare_List(Temp_Key_Value, Min, Max);
        }
        catch (ArgumentException a) when (a.Message == "잘못된 입력(개수)" && a.Message == "잘못된 입력(값)")
        {
            Console.WriteLine(a.Message);
            
        }

        return true;
    }

    public void List_Input(List<int> Value_List, List<int> Target_List)
    {
        foreach (int Value in Value_List)
        {
            Target_List.Add(Value);
        }
    }


    public void ToCompare_List(List<int> Temp_List, int Min, int Max)
    {
        foreach (int Temp_List_Value in Temp_List)
        {
            ToCompare_ValueRange(Temp_List_Value, Min, Max);
        }
    }

    public void ToCheck_InputList_Length(List<int> Temp_List, int Max)
    {
        if (Temp_List.Count > Max)
        {
            throw new ArgumentException("잘못된 입력(개수)");
        }
    }

    public int ToCompare_ValueRange(int Value, int Min, int Max)
    {
        if (Min <= Value && Value <= Max)
        {
            return 0;
        }

        throw new ArgumentException("잘못된 입력(값)");
    }

    public DataManager.Continue ToInput_Continue()
    {
        string sel;
        bool Continue_Check = false;
        List<int> Temp_Key_Value = new List<int>();

        Console.WriteLine("게임을 새로 시작하려면 1, 종료하려면 2를 입력하세요.");
        sel = Console.ReadLine();

        foreach (var Value in sel)
        {
            Temp_Key_Value.Add(Value - 48);
        }

        Continue_Check = ExceptionCheck(Temp_Key_Value, 1, 1, 2);

        if (Continue_Check == true && Temp_Key_Value[0] == 1)
        {
            return DataManager.Continue.continue_;
        }

        return DataManager.Continue.end_;
    }
}