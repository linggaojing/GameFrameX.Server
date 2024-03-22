
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.test
{
public sealed partial class TestNull : Server.Config.Core.BeanBase
{
    public TestNull(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        {if (_buf.TryGetProperty("x1", out var _j) && _j.ValueKind != JsonValueKind.Null) { X1 = _j.GetInt32(); } else { X1 = null; } }
        {if (_buf.TryGetProperty("x2", out var _j) && _j.ValueKind != JsonValueKind.Null) { X2 = (test.DemoEnum?)_j.GetInt32(); } else { X2 = null; } }
        {if (_buf.TryGetProperty("x3", out var _j) && _j.ValueKind != JsonValueKind.Null) { X3 = test.DemoType1.DeserializeDemoType1(_j); } else { X3 = null; } }
        {if (_buf.TryGetProperty("x4", out var _j) && _j.ValueKind != JsonValueKind.Null) { X4 = test.DemoDynamic.DeserializeDemoDynamic(_j); } else { X4 = null; } }
        {if (_buf.TryGetProperty("s1", out var _j) && _j.ValueKind != JsonValueKind.Null) { S1 = _j.GetString(); } else { S1 = null; } }
        {if (_buf.TryGetProperty("s2", out var _j) && _j.ValueKind != JsonValueKind.Null) { S2 = _j.GetString(); } else { S2 = null; } }
    }

    public static TestNull DeserializeTestNull(JsonElement _buf)
    {
        return new test.TestNull(_buf);
    }

    public readonly int Id;
    public readonly int? X1;
    public readonly test.DemoEnum? X2;
    public readonly test.DemoType1 X3;
    public readonly test.DemoDynamic X4;
    public readonly string S1;
    public readonly string S2;
   
    public const int __ID__ = 339868469;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        X3?.ResolveRef(tables);
        X4?.ResolveRef(tables);
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x4:" + X4 + ","
        + "s1:" + S1 + ","
        + "s2:" + S2 + ","
        + "}";
    }
}

}
