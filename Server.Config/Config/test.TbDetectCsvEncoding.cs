
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
public partial class TbDetectCsvEncoding
{
    private readonly System.Collections.Generic.Dictionary<int, test.DetectEncoding> _dataMap;
    private readonly System.Collections.Generic.List<test.DetectEncoding> _dataList;
    
    public TbDetectCsvEncoding(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.DetectEncoding>();
        _dataList = new System.Collections.Generic.List<test.DetectEncoding>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.DetectEncoding _v;
            _v = test.DetectEncoding.DeserializeDetectEncoding(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.DetectEncoding> DataMap => _dataMap;
    public System.Collections.Generic.List<test.DetectEncoding> DataList => _dataList;

    public test.DetectEncoding GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DetectEncoding Get(int key) => _dataMap[key];
    public test.DetectEncoding this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
