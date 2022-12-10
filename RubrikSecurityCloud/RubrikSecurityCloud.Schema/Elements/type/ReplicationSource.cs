// ReplicationSource.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
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
    #region ReplicationSource
    public class ReplicationSource: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        [JsonProperty("sourceClusterAddress")]
        public System.String? SourceClusterAddress { get; set; }

        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        [JsonProperty("sourceClusterName")]
        public System.String? SourceClusterName { get; set; }

        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        [JsonProperty("sourceClusterUuid")]
        public System.String? SourceClusterUuid { get; set; }

        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        [JsonProperty("totalStorage")]
        public System.Int64? TotalStorage { get; set; }

        #endregion

    #region methods

    public ReplicationSource Set(
        System.String? Id = null,
        System.String? SourceClusterAddress = null,
        System.String? SourceClusterName = null,
        System.String? SourceClusterUuid = null,
        System.Int64? TotalStorage = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SourceClusterAddress != null ) {
            this.SourceClusterAddress = SourceClusterAddress;
        }
        if ( SourceClusterName != null ) {
            this.SourceClusterName = SourceClusterName;
        }
        if ( SourceClusterUuid != null ) {
            this.SourceClusterUuid = SourceClusterUuid;
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
            //      C# -> System.String? SourceClusterAddress
            // GraphQL -> sourceClusterAddress: String (scalar)
            if (this.SourceClusterAddress != null)
            {
                 s += ind + "sourceClusterAddress\n";

            }
            //      C# -> System.String? SourceClusterName
            // GraphQL -> sourceClusterName: String! (scalar)
            if (this.SourceClusterName != null)
            {
                 s += ind + "sourceClusterName\n";

            }
            //      C# -> System.String? SourceClusterUuid
            // GraphQL -> sourceClusterUuid: UUID! (scalar)
            if (this.SourceClusterUuid != null)
            {
                 s += ind + "sourceClusterUuid\n";

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
            //      C# -> System.String? SourceClusterAddress
            // GraphQL -> sourceClusterAddress: String (scalar)
            if (this.SourceClusterAddress == null && Exploration.Includes(parent + ".sourceClusterAddress$"))
            {
                this.SourceClusterAddress = new System.String("FETCH");
            }
            //      C# -> System.String? SourceClusterName
            // GraphQL -> sourceClusterName: String! (scalar)
            if (this.SourceClusterName == null && Exploration.Includes(parent + ".sourceClusterName$"))
            {
                this.SourceClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceClusterUuid
            // GraphQL -> sourceClusterUuid: UUID! (scalar)
            if (this.SourceClusterUuid == null && Exploration.Includes(parent + ".sourceClusterUuid$"))
            {
                this.SourceClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalStorage
            // GraphQL -> totalStorage: Long (scalar)
            if (this.TotalStorage == null && Exploration.Includes(parent + ".totalStorage$"))
            {
                this.TotalStorage = new System.Int64();
            }
        }


    #endregion

    } // class ReplicationSource
    #endregion

    public static class ListReplicationSourceExtensions
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
            this List<ReplicationSource> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationSource> list, 
            String parent = "")
        {
            var item = new ReplicationSource();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types