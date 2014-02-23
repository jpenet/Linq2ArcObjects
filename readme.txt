10/6/2012 - Initial release by Johnny Penet

This is my first attempt for adding LINQ to the use of attribute classes and feature class.

This was a study to replace the old ADO style of handling rows and features in the ArcGis framework towards the
more modern way of reading attribute and feature classes using LINQ. I choose a pattern similar as Microsoft did for 
the implementation of LINQ to SQL.

The library use reflection to implement LINQ, as did Microsoft for their LINQ to SQL

There is no fancy editor for creating the table classes, you must create them by hand. However it is not so difficult
to write a tool using ARC Engine to create the classes based on the SDE attribute an feature tables.

The class ArcObjectsContext.cs contains some default values that has to be changed.


