/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class GridAxis : Entity 
	{
		public Curve AxisCurve {get;set;}

		public String AxisTag {get;set;}

		public Boolean SameSense {get;set;}

		public GridAxis(Curve axisCurve,
				String axisTag,
				Boolean sameSense,
				Boolean sameSenseSpecified) : base()
		{
			this.AxisCurve = axisCurve;
			this.AxisTag = axisTag;
			this.SameSense = sameSense;
		}
	}
}