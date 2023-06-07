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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ExocomputeHealthCheckStatusValue? Status
        // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ExocomputeHealthCheckStatusValue();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason", true))
        {
            this.FailureReason = "FETCH";
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        if (this.LastUpdatedAt == null && Exploration.Includes(parent + ".lastUpdatedAt", true))
        {
            this.LastUpdatedAt = new DateTime();
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId", true))
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeHealthCheckStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeHealthCheckStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types