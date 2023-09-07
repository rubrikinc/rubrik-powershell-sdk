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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        if (this.OnDemandCount != null) {
            s += ind + "onDemandCount\n" ;
        }
        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        if (this.RetrievedCount != null) {
            s += ind + "retrievedCount\n" ;
        }
        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        if (this.ScheduledCount != null) {
            s += ind + "scheduledCount\n" ;
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount != null) {
            s += ind + "totalCount\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        if (this.OnDemandCount == null && ec.Includes("onDemandCount",true))
        {
            this.OnDemandCount = new System.Int64();
        }
        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        if (this.RetrievedCount == null && ec.Includes("retrievedCount",true))
        {
            this.RetrievedCount = new System.Int64();
        }
        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        if (this.ScheduledCount == null && ec.Includes("scheduledCount",true))
        {
            this.ScheduledCount = new System.Int64();
        }
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount == null && ec.Includes("totalCount",true))
        {
            this.TotalCount = new System.Int64();
        }
    }


    #endregion

    } // class SnapshotDistribution
    
    #endregion

    public static class ListSnapshotDistributionExtensions
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
            this List<SnapshotDistribution> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<SnapshotDistribution> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types