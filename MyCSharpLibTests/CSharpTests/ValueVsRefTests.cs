using MyCSharpLib.CSharp;

namespace MyCSharpLibTests.CSharpTests;

[TestClass]
public class ValueVsRefTests
{
    private ValueVsRef obj;
    private ModifyObj mod;

    [TestInitialize]
    public void Init()
    {
        obj = new ValueVsRef(10);
        mod = new ModifyObj();
        
    }

    [TestMethod]
    public void TestModify1()
    {
        mod.ModifyValue(obj);
        Assert.AreEqual(20, obj.Value);
    }

    [TestMethod]
    public void TestModify2()
    {
        mod.ModifyValue(ref obj);
        Assert.AreEqual(20, obj.Value);
    }


    [TestMethod]
    public void TestMakeCopyAndModify1()
    {
        mod.MakeCopyAndModifyValue(obj);
        Assert.AreEqual(10, obj.Value);
    }

    [TestMethod]
    public void TestMakeCopyAndModify2()
    {
        mod.MakeCopyAndModifyValue(ref obj);
        Assert.AreEqual(20, obj.Value);
    }
}