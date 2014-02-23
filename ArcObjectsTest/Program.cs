using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linq2ArcObjects;

namespace ArcObjectsTest
  {
  class Program
    {
    static void Main(string[] args)
      {

      //TestRow row = new TestRow();
      //row.ObjectId = 1;
      //row.Data = "data"+ row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 2;
      //row.Data = "data"+ row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 3;
      //row.Data = "data"+ row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 4;
      //row.Data = "data" + row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 5;
      //row.Data = "data" + row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 6;
      //row.Data = "data" + row.ObjectId.ToString();
      //testRows.Add(row);
      //row.ObjectId = 7;
      //row.Data = "data" + row.ObjectId.ToString();
      //testRows.Add(row);
      //var result = from d in testRows
      //             where d.Data == "data5"
      //             select d;
      //foreach (var item in result)
      //  {
      //  Console.WriteLine(item.Data);        
      //  }
      TestArcObjectsContext context = new TestArcObjectsContext();
      string value = "TA";
      var result = from d in context.TblBronTable.Rows
                   where (d.Code == value)
                   orderby d.ObjectId
                   select d;
      foreach (var item in result)
        {
        Console.WriteLine(item.DeScript);
        }
      }
    }
  }
