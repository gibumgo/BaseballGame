using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(GameManager))]
public class GameManagerTest
{
    public static DataManager Data = DataManager.Instance();
    #region  InputComputer
    [Test]
    public void Input_Random_Integer_Test()
    {
        GameManager.Input_Random_Integer();
        Assert.AreEqual( 3,Data.n_computer_List.Count );
    }
    [Test]
    public void Value_Input_Test()
    {
        GameManager.Compare_Value_Input(1 , Data.n_computer_List);
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
    public void Random_Integer_Spawn_Test(
        [Range(1, 9)] int Temp_rand
        )
    {
        int i = 0;
        Temp_rand = GameManager.Random_Integer_Spawn(1, 10);
        while (i < 100)
        {
            Assert.That(Temp_rand ,Is.GreaterThan(0) & Is.LessThan(10));
            i++;
        }
    }
    #endregion

    #region InputPlayer
    [Test]
    public void KeyInput_Test()
    {
       
    }
    [Test]
    public void List_Input_Test()
    {
        List<int> Temp1 = new List<int>();
        List<int> Temp2 = new List<int>();
        Temp1.Add(1);
        Temp1.Add(2);
       
        GameManager.List_Input(Temp1 , Temp2);
        
        Assert.IsTrue(Temp2.SequenceEqual(Temp1));
    }
    [Test]
    public void ThrowMethod_Test()
    {
       
    }
    [Test]
    public void Value_Range_Test()
    {
        // 49 <= n <=57
        var ex = Assert.Throws<ArgumentException>(() => { GameManager.Value_Range(1);});
        StringAssert.Contains( "1~9가아님", ex.Message.ToString());
    }
    #endregion
    
}
