using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Models;

namespace Test.Tests
{
  [TestClass]
  public class TestTests
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

  }
}