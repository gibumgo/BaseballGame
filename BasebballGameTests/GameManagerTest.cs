using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(GameManager))]
public class GameManagerTest
{
    public static DataManager Data = DataManager.Instance();
    public GameManager GM = new GameManager();
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
        Assert.AreEqual(DataManager.Continue.continue_ , GM.ContinueInput());
        
        Data.con = DataManager.Continue.end_;
        reader = new StringReader("2");
        Console.SetIn(reader);
        Assert.AreEqual(DataManager.Continue.end_ , GM.ContinueInput());
    }
    [Test]
    public void METHOD()
    {
        
    }
}

