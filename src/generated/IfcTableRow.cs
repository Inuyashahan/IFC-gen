/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTableRow : Entity 
	{
		public IfcTableRow(IfcTableRowRowCells rowCells,
				Boolean isHeading,
				Boolean isHeadingSpecified) : base()
		{
			this.RowCells = rowCells;
			this.IsHeading = isHeading;
			this.IsHeadingSpecified = isHeadingSpecified;
		}
	}
}