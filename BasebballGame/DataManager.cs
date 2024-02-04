namespace BaseballGame;

public class DataManager
{
    public static DataManager DataInstance;
    public static DataManager Instance()
    {
        if (DataInstance == null)
        {
            DataInstance = new DataManager();
        }
        return DataInstance;
    }
    
    public List<int> n_player_List = new List<int>();
    public List<int> n_computer_List = new List<int>();

    public int Return_Player_Integer(int n_array_num)
    {
        return n_player_List[n_array_num];
    }
    public int Return_Computer_Integer(int n_array_num)
    {
        return n_computer_List[n_array_num];
    }

    
}