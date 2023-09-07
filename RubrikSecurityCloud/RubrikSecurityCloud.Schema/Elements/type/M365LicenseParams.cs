// M365LicenseParams.cs
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
    #region M365LicenseParams
    public class M365LicenseParams: BaseType
    {
        #region members

        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }

        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        [JsonProperty("fetb")]
        public System.Int64? Fetb { get; set; }

        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        [JsonProperty("userCount")]
        public System.Int32? UserCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365LicenseParams";
    }

    public M365LicenseParams Set(
        AzureHostType? HostType = null,
        System.Int64? Fetb = null,
        System.Int32? UserCount = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( Fetb != null ) {
            this.Fetb = Fetb;
        }
        if ( UserCount != null ) {
            this.UserCount = UserCount;
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
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        if (this.Fetb != null) {
            s += ind + "fetb\n" ;
        }
        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        if (this.UserCount != null) {
            s += ind + "userCount\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType == null && ec.Includes("hostType",true))
        {
            this.HostType = new AzureHostType();
        }
        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        if (this.Fetb == null && ec.Includes("fetb",true))
        {
            this.Fetb = new System.Int64();
        }
        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        if (this.UserCount == null && ec.Includes("userCount",true))
        {
            this.UserCount = Int32.MinValue;
        }
    }


    #endregion

    } // class M365LicenseParams
    
    #endregion

    public static class ListM365LicenseParamsExtensions
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
            this List<M365LicenseParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<M365LicenseParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365LicenseParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<M365LicenseParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types