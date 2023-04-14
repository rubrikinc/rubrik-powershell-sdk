// ReplicationTarget.cs
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
    #region ReplicationTarget
    public class ReplicationTarget: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        [JsonProperty("totalStorage")]
        public System.Int64? TotalStorage { get; set; }

        #endregion

    #region methods

    public ReplicationTarget Set(
        System.String? Id = null,
        System.String? TargetClusterAddress = null,
        System.String? TargetClusterName = null,
        System.String? TargetClusterUuid = null,
        System.Int64? TotalStorage = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( TargetClusterAddress != null ) {
            this.TargetClusterAddress = TargetClusterAddress;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
        }
        if ( TargetClusterUuid != null ) {
            this.TargetClusterUuid = TargetClusterUuid;
        }
        if ( TotalStorage != null ) {
            this.TotalStorage = TotalStorage;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? TargetClusterAddress
            // GraphQL -> targetClusterAddress: String (scalar)
            if (this.TargetClusterAddress != null)
            {
                 s += ind + "targetClusterAddress\n";

            }
            //      C# -> System.String? TargetClusterName
            // GraphQL -> targetClusterName: String! (scalar)
            if (this.TargetClusterName != null)
            {
                 s += ind + "targetClusterName\n";

            }
            //      C# -> System.String? TargetClusterUuid
            // GraphQL -> targetClusterUuid: UUID! (scalar)
            if (this.TargetClusterUuid != null)
            {
                 s += ind + "targetClusterUuid\n";

            }
            //      C# -> System.Int64? TotalStorage
            // GraphQL -> totalStorage: Long (scalar)
            if (this.TotalStorage != null)
            {
                 s += ind + "totalStorage\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterAddress
            // GraphQL -> targetClusterAddress: String (scalar)
            if (this.TargetClusterAddress == null && Exploration.Includes(parent + ".targetClusterAddress$"))
            {
                this.TargetClusterAddress = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterName
            // GraphQL -> targetClusterName: String! (scalar)
            if (this.TargetClusterName == null && Exploration.Includes(parent + ".targetClusterName$"))
            {
                this.TargetClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? TargetClusterUuid
            // GraphQL -> targetClusterUuid: UUID! (scalar)
            if (this.TargetClusterUuid == null && Exploration.Includes(parent + ".targetClusterUuid$"))
            {
                this.TargetClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalStorage
            // GraphQL -> totalStorage: Long (scalar)
            if (this.TotalStorage == null && Exploration.Includes(parent + ".totalStorage$"))
            {
                this.TotalStorage = new System.Int64();
            }
        }


    #endregion

    } // class ReplicationTarget
    #endregion

    public static class ListReplicationTargetExtensions
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
            this List<ReplicationTarget> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationTarget> list, 
            String parent = "")
        {
            var item = new ReplicationTarget();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types