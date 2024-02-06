
using System.Diagnostics;

namespace BaseballGame;

public class GameManager
{
    public static DataManager Data = DataManager.Instance();
    public Computer computer = new Computer();
    public User user = new User();
    
    
    

    public void In_Game_()
    {
        bool Aex = true;
        while (Aex)
        {
            Console.WriteLine("숫자 야구 게임을 시작합니다.");
            computer.Three_Random_Integer_Spawn();
            Aex = user.ToInput_KeyValue();
        }
    }
    //
    // public bool Game_States()
    // {
    //
    //     return true;
    // }
    // public void Strike();
    // public void Ball();
    // public void Nothing();

}
