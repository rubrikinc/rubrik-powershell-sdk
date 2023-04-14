// DeleteFailedClusterOperationJobDataReply.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region DeleteFailedClusterOperationJobDataReply
    public class DeleteFailedClusterOperationJobDataReply: IFragment
    {
        #region members
        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        [JsonProperty("jobProgress")]
        public System.Int32? JobProgress { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CdmJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        #endregion

    #region methods

    public DeleteFailedClusterOperationJobDataReply Set(
        System.Int32? JobProgress = null,
        System.String? Message = null,
        CdmJobStatus? JobStatus = null,
        CcpJobType? JobType = null
    ) 
    {
        if ( JobProgress != null ) {
            this.JobProgress = JobProgress;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? JobProgress
            // GraphQL -> jobProgress: Int! (scalar)
            if (this.JobProgress != null)
            {
                 s += ind + "jobProgress\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> CdmJobStatus? JobStatus
            // GraphQL -> jobStatus: CdmJobStatus! (enum)
            if (this.JobStatus != null)
            {
                 s += ind + "jobStatus\n";

            }
            //      C# -> CcpJobType? JobType
            // GraphQL -> jobType: CcpJobType! (enum)
            if (this.JobType != null)
            {
                 s += ind + "jobType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? JobProgress
            // GraphQL -> jobProgress: Int! (scalar)
            if (this.JobProgress == null && Exploration.Includes(parent + ".jobProgress$"))
            {
                this.JobProgress = new System.Int32();
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> CdmJobStatus? JobStatus
            // GraphQL -> jobStatus: CdmJobStatus! (enum)
            if (this.JobStatus == null && Exploration.Includes(parent + ".jobStatus$"))
            {
                this.JobStatus = new CdmJobStatus();
            }
            //      C# -> CcpJobType? JobType
            // GraphQL -> jobType: CcpJobType! (enum)
            if (this.JobType == null && Exploration.Includes(parent + ".jobType$"))
            {
                this.JobType = new CcpJobType();
            }
        }


    #endregion

    } // class DeleteFailedClusterOperationJobDataReply
    #endregion

    public static class ListDeleteFailedClusterOperationJobDataReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<DeleteFailedClusterOperationJobDataReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DeleteFailedClusterOperationJobDataReply> list, 
            String parent = "")
        {
            var item = new DeleteFailedClusterOperationJobDataReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types