using System.Diagnostics;

namespace BaseballGame;

public class GameManager
{
    public static DataManager Data = DataManager.Instance();
    public static Computer computer = new Computer();
    public static User user = new User();
    public static STATE state = new STATE();

    public void In_Game_()
    {
        bool Aex = true;
        Console.WriteLine("숫자 야구 게임을 시작합니다.");
        while (Aex && Data.con == DataManager.Continue.continue_)
        {
            computer.Three_Random_Integer_Spawn();
            Aex = user.ToInput_KeyValue();
            
            
            // Continue
            Data.con = ContinueInput();

        }
    }
    public DataManager.Continue ContinueInput()
    {
        if (Data.con == DataManager.Continue.end_)
        {
            return user.ToInput_Continue();
        }

        return DataManager.Continue.continue_;
    }
    
    public void Compare_Computer_To_User()
    {
        foreach (int Computer_Value in Data.n_computer_List)
        {
        }
    }
}