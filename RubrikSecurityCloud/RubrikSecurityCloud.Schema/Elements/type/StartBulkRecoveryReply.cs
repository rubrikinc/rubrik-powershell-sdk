// StartBulkRecoveryReply.cs
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
    #region StartBulkRecoveryReply
    public class StartBulkRecoveryReply: BaseType
    {
        #region members

        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        [JsonProperty("bulkRecoveryInstanceId")]
        public System.String? BulkRecoveryInstanceId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartBulkRecoveryReply";
    }

    public StartBulkRecoveryReply Set(
        System.String? BulkRecoveryInstanceId = null,
        System.String? Error = null,
        System.Int64? JobId = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( BulkRecoveryInstanceId != null ) {
            this.BulkRecoveryInstanceId = BulkRecoveryInstanceId;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
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
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        if (this.BulkRecoveryInstanceId != null) {
            s += ind + "bulkRecoveryInstanceId\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID (scalar)
        if (this.BulkRecoveryInstanceId == null && ec.Includes("bulkRecoveryInstanceId",true))
        {
            this.BulkRecoveryInstanceId = "FETCH";
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (this.Error == null && ec.Includes("error",true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long (scalar)
        if (this.JobId == null && ec.Includes("jobId",true))
        {
            this.JobId = new System.Int64();
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID (scalar)
        if (this.TaskchainId == null && ec.Includes("taskchainId",true))
        {
            this.TaskchainId = "FETCH";
        }
    }


    #endregion

    } // class StartBulkRecoveryReply
    
    #endregion

    public static class ListStartBulkRecoveryReplyExtensions
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
            this List<StartBulkRecoveryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StartBulkRecoveryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartBulkRecoveryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<StartBulkRecoveryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types