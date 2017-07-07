/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CurveStyle : PresentationStyle 
	{
		public CurveStyleCurveFont CurveFont {get;set;}

		public CurveStyleCurveWidth CurveWidth {get;set;}

		public CurveStyleCurveColour CurveColour {get;set;}

		public Boolean ModelOrDraughting {get;set;}

		public CurveStyle(CurveStyleCurveFont curveFont,
				CurveStyleCurveWidth curveWidth,
				CurveStyleCurveColour curveColour,
				Boolean modelOrDraughting,
				Boolean modelOrDraughtingSpecified,
				String name) : base(name)
		{
			this.CurveFont = curveFont;
			this.CurveWidth = curveWidth;
			this.CurveColour = curveColour;
			this.ModelOrDraughting = modelOrDraughting;
		}
	}
}