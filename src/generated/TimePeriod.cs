/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class TimePeriod : Entity 
	{
		public String StartTime {get;set;}

		public String EndTime {get;set;}

		public TimePeriod(String startTime,
				String endTime) : base()
		{
			this.StartTime = startTime;
			this.EndTime = endTime;
		}
	}
}