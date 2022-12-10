// JobReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    #region JobReply
    public class JobReply: IFragment
    {
        #region members
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? CustomerAccount
        // GraphQL -> customerAccount: String! (scalar)
        [JsonProperty("customerAccount")]
        public System.String? CustomerAccount { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> JobMetadata? Metadata
        // GraphQL -> metadata: JobMetadata (type)
        [JsonProperty("metadata")]
        public JobMetadata? Metadata { get; set; }

        #endregion

    #region methods

    public JobReply Set(
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.String? CustomerAccount = null,
        System.String? Version = null,
        JobMetadata? Metadata = null
    ) 
    {
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CustomerAccount != null ) {
            this.CustomerAccount = CustomerAccount;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName != null)
            {
                 s += ind + "clusterName\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? CustomerAccount
            // GraphQL -> customerAccount: String! (scalar)
            if (this.CustomerAccount != null)
            {
                 s += ind + "customerAccount\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> JobMetadata? Metadata
            // GraphQL -> metadata: JobMetadata (type)
            if (this.Metadata != null)
            {
                 s += ind + "metadata\n";

                 s += ind + "{\n" + 
                 this.Metadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName$"))
            {
                this.ClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? CustomerAccount
            // GraphQL -> customerAccount: String! (scalar)
            if (this.CustomerAccount == null && Exploration.Includes(parent + ".customerAccount$"))
            {
                this.CustomerAccount = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> JobMetadata? Metadata
            // GraphQL -> metadata: JobMetadata (type)
            if (this.Metadata == null && Exploration.Includes(parent + ".metadata"))
            {
                this.Metadata = new JobMetadata();
                this.Metadata.ApplyExploratoryFragment(parent + ".metadata");
            }
        }


    #endregion

    } // class JobReply
    #endregion

    public static class ListJobReplyExtensions
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
            this List<JobReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<JobReply> list, 
            String parent = "")
        {
            var item = new JobReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types