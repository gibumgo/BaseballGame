namespace BaseballGame;

public class User
{
    public static DataManager Data = DataManager.Instance();
    
    public bool ToInput_KeyValue()
    {
        string input;
        List<int> Temp_Key_Value = new List<int>();
        Console.Write("숫자를 입력해주세요 : ");
        input = Console.ReadLine();
        
        foreach (var Value in input)
        {
            Temp_Key_Value.Add(Value-48);
        }
        return ExceptionCheck(Temp_Key_Value);
        
    }
    public bool ExceptionCheck(List<int> Temp_Key_Value)
    {
        try
        {
            ToCheck_InputList_Length(Temp_Key_Value);
            ToCompare_List(Temp_Key_Value);
            List_Input(Temp_Key_Value , Data.n_player_List);
        }
        catch (ArgumentException a) when(a.Message == "잘못된 입력(개수)" && a.Message == "잘못된 입력(값)" )
        {
            Console.WriteLine(a.Message);
            return false;
        }

        return true;
    }
    public void List_Input(List<int> Value_List , List<int> Target_List)
    {
        foreach (int Value in Value_List)
        {
            Target_List.Add(Value);
        }
    }
    
   
    public void ToCompare_List(List<int> Temp_List)
    {
        foreach (int Temp_List_Value in Temp_List)
        {
            ToCompare_ValueRange(Temp_List_Value);
        }
    }

    public void ToCheck_InputList_Length(List<int> Temp_List)
    {
        if (Temp_List.Count > 3)
        {
            throw new ArgumentException("잘못된 입력(개수)");
        }
    }
    public int ToCompare_ValueRange(int Value)
    {
        if (1 <= Value && Value <= 9)
        {
            return 0;
        }
        throw new ArgumentException("잘못된 입력(값)");
    }

   
}