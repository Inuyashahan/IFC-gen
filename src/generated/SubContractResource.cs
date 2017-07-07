/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class SubContractResource : ConstructionResource 
	{
		public SubContractResourceTypeEnum PredefinedType {get;set;}

		public SubContractResource(SubContractResourceTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				ResourceTime usage,
				ConstructionResourceBaseCosts baseCosts,
				PhysicalQuantity baseQuantity,
				String identification,
				String longDescription,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(usage,
				baseCosts,
				baseQuantity,
				identification,
				longDescription,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
		}
	}
}