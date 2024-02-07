using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(User))]
public class UserTest
{
    public User user = new User();
    public static DataManager Data = DataManager.Instance();
    [Test]
    public void ToInput_KeyValue_Test()
    {
        List<int> Temp1 = new List<int>();
        for(int i = 1  ; i < 4 ; i++) { Temp1.Add(i); }
        StringReader reader = new StringReader("123");
        Console.SetIn(reader);
        Assert.IsTrue(user.ToInput_KeyValue());
        Assert.IsTrue(Temp1.SequenceEqual(Data.n_player_List));
        
        
        
    }
    [Test]
    public void ExceptionCheck_Test()
    {
        List<int> Temp1 = new List<int>();
        for(int i = 0  ; i < 4 ; i++) { Temp1.Add(i); }
        var ex1 = Assert.Throws<ArgumentException>(() => { user.ExceptionCheck(Temp1 , 3 ,1, 3);});
        StringAssert.Contains( "잘못된 입력(개수)", ex1.Message.ToString());
        
        List<int> Temp2 = new List<int>();
        Temp2.Add(10); 
        Temp2.Add(11); 
        Temp2.Add(12); 
        var ex2 = Assert.Throws<ArgumentException>(() => { user.ExceptionCheck(Temp2 , 3 ,1, 3);});
        StringAssert.Contains( "잘못된 입력(값)", ex2.Message.ToString());
        
        List<int> Temp3 = new List<int>();
        for(int i = 1  ; i < 4 ; i++) { Temp3.Add(i); }
        Assert.IsTrue(user.ExceptionCheck(Temp3,3,1,3));
    }
    
    [Test]
    public void ToCheck_InputList_Length_Test()
    {
        int MaxInteger = 5 ;
        List<int> Temp = new List<int>();
        for (int i = 0; i < MaxInteger; i++)
        {
            Temp.Add(i);
        }
        var ex = Assert.Throws<ArgumentException>(() => { user.ToCheck_InputList_Length(Temp ,3);});
        StringAssert.Contains( "잘못된 입력(개수)", ex.Message.ToString());
    }

    
    [Test]
    public void ToCompare_ValueRange_Test()
    {
        // 49 <= n <=57
        var ex = Assert.Throws<ArgumentException>(() => { user.ToCompare_ValueRange(10 ,1,9);});
        StringAssert.Contains( "잘못된 입력(값)", ex.Message.ToString());
    }

    [Test]
    public void ToInput_Continue_Test()
    {
        StringReader reader = new StringReader("1");
        Console.SetIn(reader);
        Assert.AreEqual(DataManager.Continue.continue_ , user.ToInput_Continue());
        
        reader = new StringReader("2");
        Console.SetIn(reader);
        Assert.AreEqual(DataManager.Continue.end_ , user.ToInput_Continue());
        
        reader = new StringReader("A");
        Console.SetIn(reader);
        var ex = Assert.Throws<ArgumentException>(() => { user.ToInput_Continue();});
        StringAssert.Contains( "잘못된 입력(값)", ex.Message.ToString());
    
        reader = new StringReader("12");
        Console.SetIn(reader);
        ex = Assert.Throws<ArgumentException>(() => { user.ToInput_Continue();});
        StringAssert.Contains( "잘못된 입력(개수)", ex.Message.ToString());
    }


    
}