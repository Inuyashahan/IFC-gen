/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class IndexedPolygonalFaceWithVoids : IndexedPolygonalFace 
	{
		public Int64[] InnerCoordIndices {get;set;}

		public IndexedPolygonalFaceWithVoids(Int64[] innerCoordIndices,
				Int64[] coordIndex,
				StyledItem styledByItem) : base(coordIndex,
				styledByItem)
		{
			this.InnerCoordIndices = innerCoordIndices;
		}
	}
}