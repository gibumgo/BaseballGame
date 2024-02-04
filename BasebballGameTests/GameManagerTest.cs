using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(GameManager))]
public class GameManagerTest
{
    public static DataManager Data = DataManager.Instance();
    [Test]
    public void Input_Random_Integer_Test()
    {
        GameManager.Input_Random_Integer();
        Assert.AreEqual( 3,Data.n_computer_List.Count );
    }
    [Test]
    public void Computer_List_Input_Test()
    {
        GameManager.Computer_List_Input(1);
        Assert.AreEqual( 0,Data.n_computer_List.Count );
        Data.n_computer_List.Add(2);
        Assert.AreEqual( 1,Data.n_computer_List.Count );

    }
    [Test]
    public void Compare_Integer_Test()
    {
        Assert.False(GameManager.Compare_Integer(1,1) , "같지않음");
    }
    [Test]
    public void Random_Integer_Spawn_Test()
    {
        int i = 0;
        int Temp_rand = GameManager.Random_Integer_Spawn(1, 10);
        while (i < 100)
        {
            Assert.That(Temp_rand ,Is.GreaterThan(0) & Is.LessThan(10));
            i++;
        }
    }


    
}