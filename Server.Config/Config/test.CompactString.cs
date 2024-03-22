
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
public sealed partial class CompactString : Server.Config.Core.BeanBase
{
    public CompactString(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        S2 = _buf.GetProperty("s2").GetString();
        S3 = _buf.GetProperty("s3").GetString();
    }

    public static CompactString DeserializeCompactString(JsonElement _buf)
    {
        return new test.CompactString(_buf);
    }

    public readonly int Id;
    public readonly string S2;
    public readonly string S3;
   
    public const int __ID__ = 1968089240;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "s2:" + S2 + ","
        + "s3:" + S3 + ","
        + "}";
    }
}

}
