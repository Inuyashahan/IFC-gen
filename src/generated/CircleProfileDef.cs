/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CircleProfileDef : ParameterizedProfileDef 
	{
		public Double Radius {get;set;}

		public CircleProfileDef(Double radius,
				Boolean radiusSpecified,
				Axis2Placement2D position,
				ProfileDefHasProperties hasProperties,
				ProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(position,
				hasProperties,
				profileType,
				profileName)
		{
			this.Radius = radius;
		}
	}
}