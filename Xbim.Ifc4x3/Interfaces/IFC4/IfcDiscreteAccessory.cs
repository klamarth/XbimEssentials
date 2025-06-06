// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.SharedComponentElements
{
	public partial class @IfcDiscreteAccessory : IIfcDiscreteAccessory
	{

		[CrossSchemaAttribute(typeof(IIfcDiscreteAccessory), 9)]
		Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum? IIfcDiscreteAccessory.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcDiscreteAccessoryTypeEnum.ANCHORPLATE:
						return Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.ANCHORPLATE;
					case IfcDiscreteAccessoryTypeEnum.BIRDPROTECTION:
						//## Handle translation of BIRDPROTECTION member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.BRACKET:
						return Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.BRACKET;
					case IfcDiscreteAccessoryTypeEnum.CABLEARRANGER:
						//## Handle translation of CABLEARRANGER member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.ELASTIC_CUSHION:
						//## Handle translation of ELASTIC_CUSHION member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.EXPANSION_JOINT_DEVICE:
						//## Handle translation of EXPANSION_JOINT_DEVICE member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.FILLER:
						//## Handle translation of FILLER member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.FLASHING:
						//## Handle translation of FLASHING member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.INSULATOR:
						//## Handle translation of INSULATOR member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.LOCK:
						//## Handle translation of LOCK member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.PANEL_STRENGTHENING:
						//## Handle translation of PANEL_STRENGTHENING member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.POINTMACHINEMOUNTINGDEVICE:
						//## Handle translation of POINTMACHINEMOUNTINGDEVICE member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.POINT_MACHINE_LOCKING_DEVICE:
						//## Handle translation of POINT_MACHINE_LOCKING_DEVICE member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.RAILBRACE:
						//## Handle translation of RAILBRACE member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.RAILPAD:
						//## Handle translation of RAILPAD member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.RAIL_LUBRICATION:
						//## Handle translation of RAIL_LUBRICATION member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.RAIL_MECHANICAL_EQUIPMENT:
						//## Handle translation of RAIL_MECHANICAL_EQUIPMENT member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.SHOE:
						return Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.SHOE;
					case IfcDiscreteAccessoryTypeEnum.SLIDINGCHAIR:
						//## Handle translation of SLIDINGCHAIR member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.SOUNDABSORPTION:
						//## Handle translation of SOUNDABSORPTION member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.TENSIONINGEQUIPMENT:
						//## Handle translation of TENSIONINGEQUIPMENT member from IfcDiscreteAccessoryTypeEnum in property PredefinedType
						return this.GetUserDefined<Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum>();
						//##
					case IfcDiscreteAccessoryTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.USERDEFINED;
					case IfcDiscreteAccessoryTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.ANCHORPLATE:
						PredefinedType = IfcDiscreteAccessoryTypeEnum.ANCHORPLATE;
						return;
					case Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.BRACKET:
						PredefinedType = IfcDiscreteAccessoryTypeEnum.BRACKET;
						return;
					case Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.SHOE:
						PredefinedType = IfcDiscreteAccessoryTypeEnum.SHOE;
						return;
					case Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.USERDEFINED:
						PredefinedType = IfcDiscreteAccessoryTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDiscreteAccessoryTypeEnum.NOTDEFINED:
						PredefinedType = IfcDiscreteAccessoryTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}