
namespace Linq2ArcObjects.Mapping
  {
  public class TableAttribute : System.Attribute
    {
    public string Name { get; set; }
    public string Type { get; set; } /* FeatureClass or Table */
    }
  }