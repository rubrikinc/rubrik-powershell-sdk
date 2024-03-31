// SnapshotDistribution.cs
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
    #region SnapshotDistribution
    public class SnapshotDistribution: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        [JsonProperty("onDemandCount")]
        public System.Int64? OnDemandCount { get; set; }

        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        [JsonProperty("retrievedCount")]
        public System.Int64? RetrievedCount { get; set; }

        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        [JsonProperty("scheduledCount")]
        public System.Int64? ScheduledCount { get; set; }

        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotDistribution";
    }

    public SnapshotDistribution Set(
        System.String? Id = null,
        System.Int64? OnDemandCount = null,
        System.Int64? RetrievedCount = null,
        System.Int64? ScheduledCount = null,
        System.Int64? TotalCount = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OnDemandCount != null ) {
            this.OnDemandCount = OnDemandCount;
        }
        if ( RetrievedCount != null ) {
            this.RetrievedCount = RetrievedCount;
        }
        if ( ScheduledCount != null ) {
            this.ScheduledCount = ScheduledCount;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        if (this.OnDemandCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onDemandCount\n" ;
            } else {
                s += ind + "onDemandCount\n" ;
            }
        }
        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        if (this.RetrievedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retrievedCount\n" ;
            } else {
                s += ind + "retrievedCount\n" ;
            }
        }
        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        if (this.ScheduledCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduledCount\n" ;
            } else {
                s += ind + "scheduledCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        if (ec.Includes("onDemandCount",true))
        {
            if(this.OnDemandCount == null) {

                this.OnDemandCount = new System.Int64();

            } else {


            }
        }
        else if (this.OnDemandCount != null && ec.Excludes("onDemandCount",true))
        {
            this.OnDemandCount = null;
        }
        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        if (ec.Includes("retrievedCount",true))
        {
            if(this.RetrievedCount == null) {

                this.RetrievedCount = new System.Int64();

            } else {


            }
        }
        else if (this.RetrievedCount != null && ec.Excludes("retrievedCount",true))
        {
            this.RetrievedCount = null;
        }
        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        if (ec.Includes("scheduledCount",true))
        {
            if(this.ScheduledCount == null) {

                this.ScheduledCount = new System.Int64();

            } else {


            }
        }
        else if (this.ScheduledCount != null && ec.Excludes("scheduledCount",true))
        {
            this.ScheduledCount = null;
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
    }


    #endregion

    } // class SnapshotDistribution
    
    #endregion

    public static class ListSnapshotDistributionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SnapshotDistribution> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotDistribution> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotDistribution> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotDistribution());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotDistribution> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types