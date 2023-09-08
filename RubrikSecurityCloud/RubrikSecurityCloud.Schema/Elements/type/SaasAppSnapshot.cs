// SaasAppSnapshot.cs
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
    #region SaasAppSnapshot
    public class SaasAppSnapshot: BaseType
    {
        #region members

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        [JsonProperty("expiryHint")]
        public System.Boolean? ExpiryHint { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        [JsonProperty("indexTime")]
        public DateTime? IndexTime { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        [JsonProperty("sequenceNumber")]
        public System.Int32? SequenceNumber { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasAppSnapshot";
    }

    public SaasAppSnapshot Set(
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.String? Id = null,
        DateTime? IndexTime = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Int32? SequenceNumber = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( ExpiryHint != null ) {
            this.ExpiryHint = ExpiryHint;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexTime != null ) {
            this.IndexTime = IndexTime;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( SequenceNumber != null ) {
            this.SequenceNumber = SequenceNumber;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint != null) {
            s += ind + "expiryHint\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime != null) {
            s += ind + "indexTime\n" ;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            s += ind + "isOnDemandSnapshot\n" ;
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (this.SequenceNumber != null) {
            s += ind + "sequenceNumber\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && ec.Includes("date",true))
        {
            this.Date = new DateTime();
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && ec.Includes("expirationDate",true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint == null && ec.Includes("expiryHint",true))
        {
            this.ExpiryHint = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime == null && ec.Includes("indexTime",true))
        {
            this.IndexTime = new DateTime();
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && ec.Includes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (this.SequenceNumber == null && ec.Includes("sequenceNumber",true))
        {
            this.SequenceNumber = Int32.MinValue;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && ec.Includes("workloadId",true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class SaasAppSnapshot
    
    #endregion

    public static class ListSaasAppSnapshotExtensions
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
            this List<SaasAppSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SaasAppSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasAppSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SaasAppSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types