using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.CSharp;

public class ValueVsRef
{
    public int Value { get; set; }

    public int ValueNew { get; set; }

    public ValueVsRef()
    {
        
    }

    public ValueVsRef(int value, int valueNew)
    {
        Value = value;
        ValueNew = valueNew;
    }

    public ValueVsRef(int value)
    {
        Value = value;
    }
    
}

public class ModifyObj
{
    public void ModifyValue(ValueVsRef obj)
    {
        obj.Value = 20;
    }

    public void ModifyValue(ref ValueVsRef obj)
    {
        obj.Value = 20;
    }

    public void MakeCopyAndModifyValue(ValueVsRef obj)
    {
        obj = new ValueVsRef
        {
            Value = 20
        };
    }

    public void MakeCopyAndModifyValue(ref ValueVsRef obj)
    {
        obj = new ValueVsRef
        {
            Value = 20
        };
    }

    public void ParamsExample(params string[] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine("Name is: {0}", name);
        }
    }
}