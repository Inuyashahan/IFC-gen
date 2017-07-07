/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class DoorLiningProperties : PreDefinedPropertySet 
	{
		public ShapeAspect ShapeAspectStyle {get;set;}

		public Double LiningDepth {get;set;}

		public Double LiningThickness {get;set;}

		public Double ThresholdDepth {get;set;}

		public Double ThresholdThickness {get;set;}

		public Double TransomThickness {get;set;}

		public Double TransomOffset {get;set;}

		public Double LiningOffset {get;set;}

		public Double ThresholdOffset {get;set;}

		public Double CasingThickness {get;set;}

		public Double CasingDepth {get;set;}

		public Double LiningToPanelOffsetX {get;set;}

		public Double LiningToPanelOffsetY {get;set;}

		public DoorLiningProperties(ShapeAspect shapeAspectStyle,
				Double liningDepth,
				Boolean liningDepthSpecified,
				Double liningThickness,
				Boolean liningThicknessSpecified,
				Double thresholdDepth,
				Boolean thresholdDepthSpecified,
				Double thresholdThickness,
				Boolean thresholdThicknessSpecified,
				Double transomThickness,
				Boolean transomThicknessSpecified,
				Double transomOffset,
				Boolean transomOffsetSpecified,
				Double liningOffset,
				Boolean liningOffsetSpecified,
				Double thresholdOffset,
				Boolean thresholdOffsetSpecified,
				Double casingThickness,
				Boolean casingThicknessSpecified,
				Double casingDepth,
				Boolean casingDepthSpecified,
				Double liningToPanelOffsetX,
				Boolean liningToPanelOffsetXSpecified,
				Double liningToPanelOffsetY,
				Boolean liningToPanelOffsetYSpecified) : base()
		{
			this.ShapeAspectStyle = shapeAspectStyle;
			this.LiningDepth = liningDepth;
			this.LiningThickness = liningThickness;
			this.ThresholdDepth = thresholdDepth;
			this.ThresholdThickness = thresholdThickness;
			this.TransomThickness = transomThickness;
			this.TransomOffset = transomOffset;
			this.LiningOffset = liningOffset;
			this.ThresholdOffset = thresholdOffset;
			this.CasingThickness = casingThickness;
			this.CasingDepth = casingDepth;
			this.LiningToPanelOffsetX = liningToPanelOffsetX;
			this.LiningToPanelOffsetY = liningToPanelOffsetY;
		}
	}
}