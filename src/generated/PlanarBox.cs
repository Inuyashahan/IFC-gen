/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class PlanarBox : PlanarExtent 
	{
		public PlanarBoxPlacement Placement {get;set;}

		public PlanarBox(PlanarBoxPlacement placement,
				Double sizeInX,
				Boolean sizeInXSpecified,
				Double sizeInY,
				Boolean sizeInYSpecified,
				StyledItem styledByItem) : base(sizeInX,
				sizeInY,
				styledByItem)
		{
			this.Placement = placement;
		}
	}
}