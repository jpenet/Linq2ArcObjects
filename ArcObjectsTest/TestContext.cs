using Linq2ArcObjects;

namespace ArcObjectsTest
{
	public class TestArcObjectsContext : ArcObjectsContext
	{
		public TestArcObjectsContext()
		{
			TblBronTable = new TableClass<TblBron>(base.Workspace);
		}

		public TableClass<TblBron> TblBronTable { get; set; }
	}

	[Linq2ArcObjects.Mapping.Table(Name = "D_TBLBRON", Type = "Table")]
	public class TblBron : RowEntity
	{
		[Linq2ArcObjects.Mapping.Column(FieldName = "OID", DbType = "int", ObjectID = true)]
		public int ObjectID { get; set; }

		[Linq2ArcObjects.Mapping.Column(FieldName = "code", DbType = "string", ObjectID = false)]
		public string Code { get; set; }

		[Linq2ArcObjects.Mapping.Column(FieldName = "descript", DbType = "string", ObjectID = false)]
		public string DeScript { get; set; }

	}
}
