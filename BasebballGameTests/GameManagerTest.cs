using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(GameManager))]
public class GameManagerTest
{
    public static DataManager Data = DataManager.Instance();
    public GameManager GM = new GameManager();
    //public STATE state = new STATE();

    [Test]
    public void Init_Test()
    {
    }

    [Test]
    public void In_Game_Tset()
    {
    }

    [Test]
    public void ContinueInput_Test()
    {
        Data.con = DataManager.Continue.continue_;
        StringReader reader = new StringReader("1");
        Console.SetIn(reader);
        Assert.AreEqual(DataManager.Continue.continue_, GM.ContinueInput());

        Data.con = DataManager.Continue.end_;
        reader = new StringReader("2");
        Console.SetIn(reader);
        Assert.AreEqual(DataManager.Continue.end_, GM.ContinueInput());
    }

    [Test]
    public void Compare_UI_Test()
    {
        // StringAssert.Contains("낫싱" , GM.Compare_UI().ToString() );
        // StringAssert.Contains("{0}볼 {1}스트라이크", state.Ball, state.Strike , GM.Compare_UI().ToString() );
        // StringAssert.Contains("{0}볼" , GM.Compare_UI().ToString() );
        // StringAssert.Contains("0}스트라이크" , GM.Compare_UI().ToString() );
        // StringAssert.Contains("3개의 숫자를 모두 맞히셨습니다! 게임 종료" , GM.Compare_UI().ToString() );
        //
    }

    [Test]
    public void Compare_Computer_To_User_Test()
    {
        Data.state = new STATE();
        Data.n_computer_List.Clear();
        Data.n_player_List.Clear();
        for (int Test = 1; Test < 4; Test++)
        {
            Data.n_player_List.Add(Test);
        }
        for (int Test = 5; Test < 8 ; Test++)
        {
            Data.n_computer_List.Add(Test);
        }

        GM.Compare_Computer_To_User();
        Assert.IsTrue(Data.state.Nothing);
       
    }

    [Test]
    public void Computer_Check_Test()
    {
    }

    [Test]
    public void Strike_Count_Test()
    {
        Data.n_computer_List.Clear();
        Data.n_player_List.Clear();
        for (int Test = 1; Test < 4; Test++)
        {
            Data.n_player_List.Add(Test);
        }
        for (int Test = 3; Test > 0 ; Test--)
        {
            Data.n_computer_List.Add(Test);
        }
        for (int Test_IndexValue1 = 0; Test_IndexValue1 < 3; Test_IndexValue1++)
        {
            for (int Test_IndexValue2 = 0; Test_IndexValue2 < 3; Test_IndexValue2++)
            {
                GM.Strike_Count(Test_IndexValue1,Test_IndexValue2);
            }
        }
        Assert.AreEqual(1 , Data.state.Strike);
    }

    [Test]
    public void Ball_Count_Test()
    {
        Data.n_computer_List.Clear();
        Data.n_player_List.Clear();
        for (int Test = 1; Test < 4; Test++)
        {
            Data.n_player_List.Add(Test);
        }
        for (int Test = 3; Test > 0 ; Test--)
        {
            Data.n_computer_List.Add(Test);
        }
        for (int Test_IndexValue1 = 0; Test_IndexValue1 < 3; Test_IndexValue1++)
        {
            for (int Test_IndexValue2 = 0; Test_IndexValue2 < 3; Test_IndexValue2++)
            {
               GM.Ball_Count(Test_IndexValue1,Test_IndexValue2);
            }
        }
        Assert.AreEqual(2 , Data.state.Ball);
        
        
    }
}