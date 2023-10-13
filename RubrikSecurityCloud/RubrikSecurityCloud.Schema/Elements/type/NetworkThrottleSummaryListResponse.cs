// NetworkThrottleSummaryListResponse.cs
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
    #region NetworkThrottleSummaryListResponse
    public class NetworkThrottleSummaryListResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        [JsonProperty("nextCursor")]
        public System.String? NextCursor { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        //      C# -> List<UpdateNetworkThrottleReply>? Data
        // GraphQL -> data: [UpdateNetworkThrottleReply!]! (type)
        [JsonProperty("data")]
        public List<UpdateNetworkThrottleReply>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkThrottleSummaryListResponse";
    }

    public NetworkThrottleSummaryListResponse Set(
        System.Boolean? HasMore = null,
        System.String? NextCursor = null,
        System.Int64? Total = null,
        List<UpdateNetworkThrottleReply>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( NextCursor != null ) {
            this.NextCursor = NextCursor;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMore\n" ;
            } else {
                s += ind + "hasMore\n" ;
            }
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (this.NextCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextCursor\n" ;
            } else {
                s += ind + "nextCursor\n" ;
            }
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        //      C# -> List<UpdateNetworkThrottleReply>? Data
        // GraphQL -> data: [UpdateNetworkThrottleReply!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(conf.Child("data"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "data {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (ec.Includes("hasMore",true))
        {
            if(this.HasMore == null) {

                this.HasMore = true;

            } else {


            }
        }
        else if (this.HasMore != null && ec.Excludes("hasMore",true))
        {
            this.HasMore = null;
        }
        //      C# -> System.String? NextCursor
        // GraphQL -> nextCursor: String (scalar)
        if (ec.Includes("nextCursor",true))
        {
            if(this.NextCursor == null) {

                this.NextCursor = "FETCH";

            } else {


            }
        }
        else if (this.NextCursor != null && ec.Excludes("nextCursor",true))
        {
            this.NextCursor = null;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = new System.Int64();

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
        //      C# -> List<UpdateNetworkThrottleReply>? Data
        // GraphQL -> data: [UpdateNetworkThrottleReply!]! (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new List<UpdateNetworkThrottleReply>();
                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            } else {

                this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));

            }
        }
        else if (this.Data != null && ec.Excludes("data",false))
        {
            this.Data = null;
        }
    }


    #endregion

    } // class NetworkThrottleSummaryListResponse
    
    #endregion

    public static class ListNetworkThrottleSummaryListResponseExtensions
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
            this List<NetworkThrottleSummaryListResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NetworkThrottleSummaryListResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkThrottleSummaryListResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkThrottleSummaryListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkThrottleSummaryListResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types