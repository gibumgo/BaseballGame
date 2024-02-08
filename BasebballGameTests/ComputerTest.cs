using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(Computer))]
public class ComputerTest
{
    public Computer computer = new Computer();
    public static DataManager Data = DataManager.Instance();

    [Test]
    public void Three_Random_Integer_Spawn_Test()
    {
        List<int> Test_List = new List<int>();
        Test_List = computer.Three_Random_Integer_Spawn();
        foreach (var Test_Value in Test_List)
        {
            var duplicate = Test_List.GroupBy(x => x).Where(Group => Group.Count() > 1);

            Assert.AreEqual(0, duplicate.Count());
        }
    }

    [Test]
    public void ToCompare_Value_List_Test()
    {
        Data.n_computer_List.Clear();
        List<int> Test_List = new List<int>();
        int Temp_rand_Value = 1;
        Test_List.Add(Temp_rand_Value);
        Data.n_computer_List.Add(Temp_rand_Value);
        Temp_rand_Value++;
        Test_List.Add(Temp_rand_Value);
        computer.ToCompare_Value_List(Temp_rand_Value, Data.n_computer_List);
        Assert.IsTrue(Test_List.SequenceEqual(Data.n_computer_List));
    }

    [Test]
    public void Compare_Integer_Test()
    {
        Assert.AreEqual(0, computer.Compare_Integer(1, 2));
        Assert.AreEqual(1, computer.Compare_Integer(2, 2));
    }

    [Test]
    public void Random_integer_Spawn_Test(
        [Range(1, 9)] int Temp_rand
    )
    {
        int i = 0;
        Temp_rand = computer.Random_Integer_Spawn(1, 10);
        Assert.That(Temp_rand, Is.GreaterThan(0) & Is.LessThan(10));
    }
}