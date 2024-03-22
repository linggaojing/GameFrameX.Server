
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using Server.Config.Core;


namespace cfg.ai
{
public sealed partial class Selector : ai.ComposeNode
{
    public Selector(JsonElement _buf)  : base(_buf) 
    {
        { var __json0 = _buf.GetProperty("children"); Children = new System.Collections.Generic.List<ai.FlowNode>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { ai.FlowNode __v0;  __v0 = ai.FlowNode.DeserializeFlowNode(__e0);  Children.Add(__v0); }   }
    }

    public static Selector DeserializeSelector(JsonElement _buf)
    {
        return new ai.Selector(_buf);
    }

    public readonly System.Collections.Generic.List<ai.FlowNode> Children;
   
    public const int __ID__ = -1946981627;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        foreach (var _e in Children) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
        + "services:" + StringUtil.CollectionToString(Services) + ","
        + "children:" + StringUtil.CollectionToString(Children) + ","
        + "}";
    }
}

}
