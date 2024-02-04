namespace BaseballGame;

public class DataManager
{
    public static List<int> n_player_List = new List<int>();
    public static List<int> n_computer_List = new List<int>();

    public static int Return_Player_Integer(int n_array_num)
    {
        return n_player_List[n_array_num];
    }
    public static int Return_Computer_Integer(int n_array_num)
    {
        return n_computer_List[n_array_num];
    }
    

}