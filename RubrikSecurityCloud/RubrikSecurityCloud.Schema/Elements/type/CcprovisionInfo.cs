// CcprovisionInfo.cs
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
    #region CcprovisionInfo
    public class CcprovisionInfo: IFragment
    {
        #region members
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        [JsonProperty("marshaledConfig")]
        public System.String? MarshaledConfig { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }

        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CcpJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        #endregion

    #region methods

    public CcprovisionInfo Set(
        System.String? MarshaledConfig = null,
        System.Int32? Progress = null,
        CcpJobStatus? JobStatus = null,
        CcpJobType? JobType = null,
        CcpVendorType? Vendor = null
    ) 
    {
        if ( MarshaledConfig != null ) {
            this.MarshaledConfig = MarshaledConfig;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( Vendor != null ) {
            this.Vendor = Vendor;
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
            //      C# -> System.String? MarshaledConfig
            // GraphQL -> marshaledConfig: String! (scalar)
            if (this.MarshaledConfig != null)
            {
                 s += ind + "marshaledConfig\n";

            }
            //      C# -> System.Int32? Progress
            // GraphQL -> progress: Int! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> CcpJobStatus? JobStatus
            // GraphQL -> jobStatus: CcpJobStatus! (enum)
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
            //      C# -> CcpVendorType? Vendor
            // GraphQL -> vendor: CcpVendorType! (enum)
            if (this.Vendor != null)
            {
                 s += ind + "vendor\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? MarshaledConfig
            // GraphQL -> marshaledConfig: String! (scalar)
            if (this.MarshaledConfig == null && Exploration.Includes(parent + ".marshaledConfig$"))
            {
                this.MarshaledConfig = new System.String("FETCH");
            }
            //      C# -> System.Int32? Progress
            // GraphQL -> progress: Int! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Int32();
            }
            //      C# -> CcpJobStatus? JobStatus
            // GraphQL -> jobStatus: CcpJobStatus! (enum)
            if (this.JobStatus == null && Exploration.Includes(parent + ".jobStatus$"))
            {
                this.JobStatus = new CcpJobStatus();
            }
            //      C# -> CcpJobType? JobType
            // GraphQL -> jobType: CcpJobType! (enum)
            if (this.JobType == null && Exploration.Includes(parent + ".jobType$"))
            {
                this.JobType = new CcpJobType();
            }
            //      C# -> CcpVendorType? Vendor
            // GraphQL -> vendor: CcpVendorType! (enum)
            if (this.Vendor == null && Exploration.Includes(parent + ".vendor$"))
            {
                this.Vendor = new CcpVendorType();
            }
        }


    #endregion

    } // class CcprovisionInfo
    #endregion

    public static class ListCcprovisionInfoExtensions
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
            this List<CcprovisionInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CcprovisionInfo> list, 
            String parent = "")
        {
            var item = new CcprovisionInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types