using System.Diagnostics;

namespace BaseballGame;

public class GameManager
{
    public static DataManager Data = DataManager.Instance();
    public static Computer computer = new Computer();
    public static User user = new User();
    

    public void Init()
    {
        Console.WriteLine("숫자 야구 게임을 시작합니다.");
        while (Data.con == DataManager.Continue.continue_)
        {
            computer.Three_Random_Integer_Spawn();
            // Console.WriteLine(Data.n_computer_List[0].ToString());
            // Console.WriteLine(Data.n_computer_List[1].ToString());
            // Console.WriteLine(Data.n_computer_List[2].ToString());
            In_Game_();
            //Data.con = DataManager.Continue.end_;
            // Continue
            Data.con = ContinueInput();
        }
    }

    public void In_Game_()
    {
        bool Aex = true;
        while (Aex)
        {
            Data.state = new STATE();
            Aex = user.ToInput_KeyValue();
            Compare_Computer_To_User();
            Aex = Compare_UI();
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

   
    
    public bool Compare_UI()
    {
        if (Data.state.Nothing == true)
        {
            Console.WriteLine("낫싱");
        }
        if (Data.state.Nothing == false && Data.state.Ball != 0 && Data.state.Strike != 0)
        {
            Console.WriteLine("{0}볼 {1}스트라이크", Data.state.Ball, Data.state.Strike);
        }

        if (Data.state.Nothing == false && Data.state.Ball != 0 && Data.state.Strike == 0)
        {
            Console.WriteLine("{0}볼", Data.state.Ball);
        }
        if(Data.state.Nothing == false && Data.state.Ball == 0 && Data.state.Strike != 0)
        {
            Console.WriteLine("{0}스트라이크", Data.state.Strike);
        }
        if (Data.n_computer_List.SequenceEqual(Data.n_player_List))
        {
            Console.WriteLine("3개의 숫자를 모두 맞히셨습니다! 게임 종료");
            Data.con = DataManager.Continue.end_;
            return false;
        }

        return true;
    }

    public void Compare_Computer_To_User()
    {
        Computer_Check();
        if (Data.state.Strike == 0 && Data.state.Ball == 0)
        {
            Data.state.Nothing = true;
        }
    }

    public void Computer_Check()
    {
        for (int Computer_Count = 0; Computer_Count < 3; Computer_Count++)
        {
            Player_Check(Computer_Count);
        }
    }

    public void Player_Check(int Computer_Count)
    {
        for (int Player_Count = 0; Player_Count < 3; Player_Count++)
        {
            Strike_Count(Computer_Count, Player_Count);
            Ball_Count(Computer_Count, Player_Count);
        }
    }


    public void Strike_Count(int Computer_Count, int Player_Count)
    {
        if (Computer_Count == Player_Count && Data.n_player_List[Player_Count] == Data.n_computer_List[Computer_Count])
        {
            Data.state.Strike++;
        }
    }

    public void Ball_Count(int Computer_Count, int Player_Count)
    {
        if (Computer_Count != Player_Count && Data.n_player_List[Player_Count] == Data.n_computer_List[Computer_Count])
        {
            Data.state.Ball++;
        }
    }
}