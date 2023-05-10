using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.CSharp;

public class ValueVsRef
{
    public ValueVsRef()
    {
        
    }

    public ValueVsRef(int value)
    {
        Value = value;
    }

    public int Value { get; set; }
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
}