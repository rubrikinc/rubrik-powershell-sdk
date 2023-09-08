// AzureResourceAvailabilityResp.cs
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
    #region AzureResourceAvailabilityResp
    public class AzureResourceAvailabilityResp: BaseType
    {
        #region members

        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        [JsonProperty("available")]
        public System.Boolean? Available { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureResourceAvailabilityResp";
    }

    public AzureResourceAvailabilityResp Set(
        System.Boolean? Available = null,
        System.String? Reason = null
    ) 
    {
        if ( Available != null ) {
            this.Available = Available;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        if (this.Available != null) {
            s += ind + "available\n" ;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason != null) {
            s += ind + "reason\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Available
        // GraphQL -> available: Boolean! (scalar)
        if (this.Available == null && ec.Includes("available",true))
        {
            this.Available = true;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason == null && ec.Includes("reason",true))
        {
            this.Reason = "FETCH";
        }
    }


    #endregion

    } // class AzureResourceAvailabilityResp
    
    #endregion

    public static class ListAzureResourceAvailabilityRespExtensions
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
            this List<AzureResourceAvailabilityResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureResourceAvailabilityResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureResourceAvailabilityResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureResourceAvailabilityResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types