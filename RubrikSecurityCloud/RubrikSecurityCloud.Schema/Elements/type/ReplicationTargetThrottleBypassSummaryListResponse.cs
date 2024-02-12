// ReplicationTargetThrottleBypassSummaryListResponse.cs
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
    #region ReplicationTargetThrottleBypassSummaryListResponse
    public class ReplicationTargetThrottleBypassSummaryListResponse: BaseType
    {
        #region members

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }

        //      C# -> List<ReplicationTargetThrottleBypassSummary>? Data
        // GraphQL -> data: [ReplicationTargetThrottleBypassSummary!]! (type)
        [JsonProperty("data")]
        public List<ReplicationTargetThrottleBypassSummary>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationTargetThrottleBypassSummaryListResponse";
    }

    public ReplicationTargetThrottleBypassSummaryListResponse Set(
        System.Int32? Total = null,
        List<ReplicationTargetThrottleBypassSummary>? Data = null
    ) 
    {
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
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        //      C# -> List<ReplicationTargetThrottleBypassSummary>? Data
        // GraphQL -> data: [ReplicationTargetThrottleBypassSummary!]! (type)
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
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = Int32.MinValue;

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
        //      C# -> List<ReplicationTargetThrottleBypassSummary>? Data
        // GraphQL -> data: [ReplicationTargetThrottleBypassSummary!]! (type)
        if (ec.Includes("data",false))
        {
            if(this.Data == null) {

                this.Data = new List<ReplicationTargetThrottleBypassSummary>();
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

    } // class ReplicationTargetThrottleBypassSummaryListResponse
    
    #endregion

    public static class ListReplicationTargetThrottleBypassSummaryListResponseExtensions
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
            this List<ReplicationTargetThrottleBypassSummaryListResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ReplicationTargetThrottleBypassSummaryListResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationTargetThrottleBypassSummaryListResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationTargetThrottleBypassSummaryListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationTargetThrottleBypassSummaryListResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types