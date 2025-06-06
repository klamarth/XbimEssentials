// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometricModelResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometryResource;
//## Custom using statements
using Xbim.Ifc4x3.ProductExtension;
using Xbim.Ifc4x3.GeometricConstraintResource;
//##


namespace Xbim.Ifc4x3.GeometryResource
{
	[ExpressType("IfcCurve", 68)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCurve : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IEquatable<@IfcCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
				if (this is IfcLine ln) return ln.Pnt.Dim;
				if (this is IfcConic cn)return cn.Position.Dim;
				if (this is IfcPolyline pln) return pln.Points[1].Dim;
				if (this is IfcTrimmedCurve tc) return tc.BasisCurve.Dim;
				if (this is IfcBSplineCurve bs) return bs.ControlPointsList[1].Dim;
				if (this is IfcOffsetCurve2D) return 2;
				if (this is IfcOffsetCurve3D) return 3;
				if (this is IfcOffsetCurveByDistances) return 3;
				if (this is IfcPcurve) return 3;
				if (this is IfcIndexedPolyCurve pc) return pc.Points.Dim;
				if (this is IfcSegmentedReferenceCurve) return 3;
				if (this is IfcGradientCurve) return 3;
				if (this is IfcCompositeCurve cc) 
				{
					var segment = cc.Segments[1];
					if (segment is IfcCompositeCurveSegment ccs)
						return ccs.Dim;
					else if (segment is IfcCurveSegment cs)
						return cs.ParentCurve.Dim;
					else return 0;
				}
				if (this is IfcPolynomialCurve polynomialCurve)  return polynomialCurve.Position.Dim;
				if (this is IfcSpiral spiral) return 2;
				if (this is IfcSurfaceCurve surfaceCurve) return surfaceCurve.Curve3D.Dim;

				throw new NotSupportedException();
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}