// ReportChartType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ReportChartType
    public interface ReportChartType: IFieldSpec {} // class ReportChartType
    #endregion

    public static class ListReportChartTypeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ReportChartType> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (ReportChartType item in list) 
            {
                var fspec = item.AsFieldSpec(indent+1);
                string typename;
                if (item is BaseType bt) {
                    typename = bt.GetGqlTypeName();
                } else {
                    typename = item.GetType().Name;
                }
                if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                    fieldspecs += ind + " ... on " + typename + " {\n" + fspec + ind + "}\n";
                }
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportChartType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<ReportChartType>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (ReportChartType item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void Fetch(this List<ReportChartType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types