// HostDiagnosisSummary.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region HostDiagnosisSummary
    public class HostDiagnosisSummary: BaseType
    {
        #region members

        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        [JsonProperty("connectivity")]
        public List<HostConnectivitySummary>? Connectivity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostDiagnosisSummary";
    }

    public HostDiagnosisSummary Set(
        List<HostConnectivitySummary>? Connectivity = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        if (this.Connectivity != null) {
            var fspec = this.Connectivity.AsFieldSpec(conf.Child("connectivity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectivity {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HostConnectivitySummary>? Connectivity
        // GraphQL -> connectivity: [HostConnectivitySummary!]! (type)
        if (ec.Includes("connectivity",false))
        {
            if(this.Connectivity == null) {

                this.Connectivity = new List<HostConnectivitySummary>();
                this.Connectivity.ApplyExploratoryFieldSpec(ec.NewChild("connectivity"));

            } else {

                this.Connectivity.ApplyExploratoryFieldSpec(ec.NewChild("connectivity"));

            }
        }
        else if (this.Connectivity != null && ec.Excludes("connectivity",false))
        {
            this.Connectivity = null;
        }
    }


    #endregion

    } // class HostDiagnosisSummary
    
    #endregion

    public static class ListHostDiagnosisSummaryExtensions
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
            this List<HostDiagnosisSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostDiagnosisSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDiagnosisSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostDiagnosisSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types