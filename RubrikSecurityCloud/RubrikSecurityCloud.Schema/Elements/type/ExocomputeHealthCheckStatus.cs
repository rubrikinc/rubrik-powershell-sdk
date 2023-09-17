// ExocomputeHealthCheckStatus.cs
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
    #region ExocomputeHealthCheckStatus
    public class ExocomputeHealthCheckStatus: BaseType
    {
        #region members

        //      C# -> ExocomputeHealthCheckStatusValue? Status
        // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
        [JsonProperty("status")]
        public ExocomputeHealthCheckStatusValue? Status { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        [JsonProperty("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExocomputeHealthCheckStatus";
    }

    public ExocomputeHealthCheckStatus Set(
        ExocomputeHealthCheckStatusValue? Status = null,
        System.String? FailureReason = null,
        DateTime? LastUpdatedAt = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( LastUpdatedAt != null ) {
            this.LastUpdatedAt = LastUpdatedAt;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
        //      C# -> ExocomputeHealthCheckStatusValue? Status
        // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        if (this.LastUpdatedAt != null) {
            s += ind + "lastUpdatedAt\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ExocomputeHealthCheckStatusValue? Status
        // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new ExocomputeHealthCheckStatusValue();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        if (this.FailureReason == null && ec.Includes("failureReason",true))
        {
            this.FailureReason = "FETCH";
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        if (this.LastUpdatedAt == null && ec.Includes("lastUpdatedAt",true))
        {
            this.LastUpdatedAt = new DateTime();
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId == null && ec.Includes("taskchainId",true))
        {
            this.TaskchainId = "FETCH";
        }
    }


    #endregion

    } // class ExocomputeHealthCheckStatus
    
    #endregion

    public static class ListExocomputeHealthCheckStatusExtensions
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
            this List<ExocomputeHealthCheckStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeHealthCheckStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeHealthCheckStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExocomputeHealthCheckStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types