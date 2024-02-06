namespace BaseballGame;

public class Computer
{
    
    public static DataManager Data = DataManager.Instance();

    public Computer(){ }
    
    public void Three_Random_Integer_Spawn()
    {
        int Temp_rand_Value = 0;
        Data.n_computer_List.Add(Random_Integer_Spawn(1, 10));
        while (Data.n_computer_List.Count < 3)
        {
            Temp_rand_Value = Random_Integer_Spawn(1, 10);
            ToCompare_Value_List(Temp_rand_Value, Data.n_computer_List);
        }
    }

    public void ToCompare_Value_List(int Value , List<int> TargetList)
    {
        bool Compare_Check = false;
        foreach (int Target_List_Value in TargetList)
        {
            Compare_Check = Compare_Integer(Value,Target_List_Value );
        }
        if (Compare_Check == true)
        {
            TargetList.Add(Value);
        }
    }

    public bool Compare_Integer(int CompareValue,int Target_List_Value)
    {
        if (Target_List_Value != CompareValue)
        {
            return true;
        }
        return false;
    }

    public int Random_Integer_Spawn(int Min, int Max)
    {
        Random random = new Random();
        int Temp_Integer = random.Next(Min, Max);
        return Temp_Integer;
    }

}