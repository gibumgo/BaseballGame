using BaseballGame;
using NUnit.Framework;

namespace test;

[TestFixture]
[TestOf(typeof(DataManager))]
public class DataManagerTest
{
    private DataManager Data = DataManager.Instance();
    
}