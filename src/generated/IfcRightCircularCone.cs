/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRightCircularCone : IfcCsgPrimitive3D 
	{
		public IfcRightCircularCone(Double height,
				Boolean heightSpecified,
				Double bottomRadius,
				Boolean bottomRadiusSpecified,
				IfcAxis2Placement3D position,
				IfcStyledItem styledByItem) : base(position,
				styledByItem)
		{
			this.Height = height;
			this.HeightSpecified = heightSpecified;
			this.BottomRadius = bottomRadius;
			this.BottomRadiusSpecified = bottomRadiusSpecified;
		}
	}
}