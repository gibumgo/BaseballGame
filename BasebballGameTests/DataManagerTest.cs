using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(DataManager))]
public class DataManagerTest
{
    private DataManager Data = DataManager.Instance();
    [Test]
    public void Return_Player_Integer_Test()
    {
        for (int index = 0; index < 3; index++)
        {
            Data.n_player_List.Add(index);
        }
        int Tempindex = 0;
        foreach (int Player_integer in Data.n_player_List)
        {
            Assert.AreEqual( Player_integer, Data.Return_Player_Integer(Tempindex) );
            Tempindex++;
        }
    }

    [Test]
    public void Return_Computer_Integer_Test()
    {
        for (int index = 0; index < 3; index++)
        {
            Data.n_computer_List.Add(index);
        }
        int Tempindex = 0;
        foreach (int computer_integer in Data.n_computer_List)
        {
            Assert.AreEqual( computer_integer, Data.Return_Computer_Integer(Tempindex) );
            Tempindex++;
        }
    }
}