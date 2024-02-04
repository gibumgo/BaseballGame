using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(GameManager))]
public class GameManagerTest
{

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