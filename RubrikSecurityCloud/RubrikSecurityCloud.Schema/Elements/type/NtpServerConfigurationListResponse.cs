// NtpServerConfigurationListResponse.cs
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
    #region NtpServerConfigurationListResponse
    public class NtpServerConfigurationListResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        //      C# -> List<NtpServerConfiguration>? Data
        // GraphQL -> data: [NtpServerConfiguration!]! (type)
        [JsonProperty("data")]
        public List<NtpServerConfiguration>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NtpServerConfigurationListResponse";
    }

    public NtpServerConfigurationListResponse Set(
        System.Boolean? HasMore = null,
        System.Int64? Total = null,
        List<NtpServerConfiguration>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            s += ind + "hasMore\n" ;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
        }
        //      C# -> List<NtpServerConfiguration>? Data
        // GraphQL -> data: [NtpServerConfiguration!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "data {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore == null && ec.Includes("hasMore",true))
        {
            this.HasMore = true;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total == null && ec.Includes("total",true))
        {
            this.Total = new System.Int64();
        }
        //      C# -> List<NtpServerConfiguration>? Data
        // GraphQL -> data: [NtpServerConfiguration!]! (type)
        if (this.Data == null && ec.Includes("data",false))
        {
            this.Data = new List<NtpServerConfiguration>();
            this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));
        }
    }


    #endregion

    } // class NtpServerConfigurationListResponse
    
    #endregion

    public static class ListNtpServerConfigurationListResponseExtensions
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
            this List<NtpServerConfigurationListResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NtpServerConfigurationListResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NtpServerConfigurationListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NtpServerConfigurationListResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types