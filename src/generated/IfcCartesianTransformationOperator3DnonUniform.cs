/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D 
	{
		public IfcCartesianTransformationOperator3DnonUniform(Double scale2,
				Boolean scale2Specified,
				Double scale3,
				Boolean scale3Specified,
				IfcDirection axis3,
				IfcDirection axis1,
				IfcDirection axis2,
				IfcCartesianPoint localOrigin,
				Double scale,
				Boolean scaleSpecified,
				IfcStyledItem styledByItem) : base(axis3,
				axis1,
				axis2,
				localOrigin,
				scale,
				scaleSpecified,
				styledByItem)
		{
			this.Scale2 = scale2;
			this.Scale2Specified = scale2Specified;
			this.Scale3 = scale3;
			this.Scale3Specified = scale3Specified;
		}
	}
}