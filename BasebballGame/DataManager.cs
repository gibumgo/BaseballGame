namespace BaseballGame;

public class DataManager
{
    public enum Continue{continue_,end_}
    public static DataManager DataInstance;
    public STATE state = new STATE();

    public static DataManager Instance()
    {
        if (DataInstance == null)
        {
            DataInstance = new DataManager();
        }

        return DataInstance;
    }

    public Continue con = Continue.continue_;
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

public class STATE
{
    public int Strike;
    public int Ball;
    public bool Nothing;

    public STATE()
    {
        Strike = 0;
        Ball = 0;
        Nothing = false;
    }

    public STATE(int strike, int ball, bool nothing)
    {
        Strike = strike;
        Ball = ball;
        Nothing = nothing;
    }
}