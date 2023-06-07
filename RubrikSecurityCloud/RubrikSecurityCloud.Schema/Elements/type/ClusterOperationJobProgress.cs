// ClusterOperationJobProgress.cs
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
    #region ClusterOperationJobProgress
    public class ClusterOperationJobProgress: BaseType
    {
        #region members

        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CdmJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        [JsonProperty("jobProgress")]
        public System.Int32? JobProgress { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public ClusterOperationJobProgress Set(
        CdmJobStatus? JobStatus = null,
        CcpJobType? JobType = null,
        System.Int32? JobProgress = null,
        System.String? Message = null
    ) 
    {
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( JobProgress != null ) {
            this.JobProgress = JobProgress;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        if (this.JobStatus != null) {
            s += ind + "jobStatus\n" ;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        if (this.JobProgress != null) {
            s += ind + "jobProgress\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        if (this.JobStatus == null && Exploration.Includes(parent + ".jobStatus", true))
        {
            this.JobStatus = new CdmJobStatus();
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = new CcpJobType();
        }
        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        if (this.JobProgress == null && Exploration.Includes(parent + ".jobProgress", true))
        {
            this.JobProgress = Int32.MinValue;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class ClusterOperationJobProgress
    
    #endregion

    public static class ListClusterOperationJobProgressExtensions
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
            this List<ClusterOperationJobProgress> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterOperationJobProgress> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterOperationJobProgress());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types