// LambdaFeatureHistory.cs
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
    #region LambdaFeatureHistory
    public class LambdaFeatureHistory: BaseType
    {
        #region members

        //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
        // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
        [JsonProperty("wasRansomwareInvestigationEverEnabled")]
        public System.Boolean? WasRansomwareInvestigationEverEnabled { get; set; }

        //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
        // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
        [JsonProperty("wasSensitiveDataDiscoveryEverEnabled")]
        public System.Boolean? WasSensitiveDataDiscoveryEverEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LambdaFeatureHistory";
    }

    public LambdaFeatureHistory Set(
        System.Boolean? WasRansomwareInvestigationEverEnabled = null,
        System.Boolean? WasSensitiveDataDiscoveryEverEnabled = null
    ) 
    {
        if ( WasRansomwareInvestigationEverEnabled != null ) {
            this.WasRansomwareInvestigationEverEnabled = WasRansomwareInvestigationEverEnabled;
        }
        if ( WasSensitiveDataDiscoveryEverEnabled != null ) {
            this.WasSensitiveDataDiscoveryEverEnabled = WasSensitiveDataDiscoveryEverEnabled;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
        // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
        if (this.WasRansomwareInvestigationEverEnabled != null) {
            s += ind + "wasRansomwareInvestigationEverEnabled\n" ;
        }
        //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
        // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
        if (this.WasSensitiveDataDiscoveryEverEnabled != null) {
            s += ind + "wasSensitiveDataDiscoveryEverEnabled\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? WasRansomwareInvestigationEverEnabled
        // GraphQL -> wasRansomwareInvestigationEverEnabled: Boolean! (scalar)
        if (this.WasRansomwareInvestigationEverEnabled == null && ec.Includes("wasRansomwareInvestigationEverEnabled",true))
        {
            this.WasRansomwareInvestigationEverEnabled = true;
        }
        //      C# -> System.Boolean? WasSensitiveDataDiscoveryEverEnabled
        // GraphQL -> wasSensitiveDataDiscoveryEverEnabled: Boolean! (scalar)
        if (this.WasSensitiveDataDiscoveryEverEnabled == null && ec.Includes("wasSensitiveDataDiscoveryEverEnabled",true))
        {
            this.WasSensitiveDataDiscoveryEverEnabled = true;
        }
    }


    #endregion

    } // class LambdaFeatureHistory
    
    #endregion

    public static class ListLambdaFeatureHistoryExtensions
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
            this List<LambdaFeatureHistory> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LambdaFeatureHistory> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LambdaFeatureHistory());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<LambdaFeatureHistory> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types