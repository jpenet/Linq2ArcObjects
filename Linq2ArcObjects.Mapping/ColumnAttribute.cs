using System;

namespace Linq2ArcObjects.Mapping
  {
  public class ColumnAttribute :System.Attribute
    {
    public string FieldName { get; set; }
    public string DbType { get; set; }
    public Boolean ObjectID { get; set; }
    }
  }
