/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CartesianTransformationOperator : GeometricRepresentationItem 
	{
		public Direction Axis1 {get;set;}

		public Direction Axis2 {get;set;}

		public CartesianPoint LocalOrigin {get;set;}

		public Double Scale {get;set;}

		public CartesianTransformationOperator(Direction axis1,
				Direction axis2,
				CartesianPoint localOrigin,
				Double scale,
				Boolean scaleSpecified,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.Axis1 = axis1;
			this.Axis2 = axis2;
			this.LocalOrigin = localOrigin;
			this.Scale = scale;
		}
	}
}