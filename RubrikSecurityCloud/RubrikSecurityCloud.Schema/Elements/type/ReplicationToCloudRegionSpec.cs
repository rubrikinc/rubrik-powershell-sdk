// ReplicationToCloudRegionSpec.cs
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
    #region ReplicationToCloudRegionSpec
    public class ReplicationToCloudRegionSpec: IFragment
    {
        #region members
        //      C# -> System.String? ReplicationTargetRegion
        // GraphQL -> replicationTargetRegion: String! (scalar)
        [JsonProperty("replicationTargetRegion")]
        public System.String? ReplicationTargetRegion { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }

        //      C# -> CloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudProvider! (enum)
        [JsonProperty("cloudProvider")]
        public CloudProvider? CloudProvider { get; set; }

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        #endregion

    #region methods

    public ReplicationToCloudRegionSpec Set(
        System.String? ReplicationTargetRegion = null,
        System.Int32? Retention = null,
        CloudProvider? CloudProvider = null,
        RetentionUnit? RetentionUnit = null
    ) 
    {
        if ( ReplicationTargetRegion != null ) {
            this.ReplicationTargetRegion = ReplicationTargetRegion;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
        }
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
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
            //      C# -> System.String? ReplicationTargetRegion
            // GraphQL -> replicationTargetRegion: String! (scalar)
            if (this.ReplicationTargetRegion != null)
            {
                 s += ind + "replicationTargetRegion\n";

            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention != null)
            {
                 s += ind + "retention\n";

            }
            //      C# -> CloudProvider? CloudProvider
            // GraphQL -> cloudProvider: CloudProvider! (enum)
            if (this.CloudProvider != null)
            {
                 s += ind + "cloudProvider\n";

            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit != null)
            {
                 s += ind + "retentionUnit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ReplicationTargetRegion
            // GraphQL -> replicationTargetRegion: String! (scalar)
            if (this.ReplicationTargetRegion == null && Exploration.Includes(parent + ".replicationTargetRegion$"))
            {
                this.ReplicationTargetRegion = new System.String("FETCH");
            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention == null && Exploration.Includes(parent + ".retention$"))
            {
                this.Retention = new System.Int32();
            }
            //      C# -> CloudProvider? CloudProvider
            // GraphQL -> cloudProvider: CloudProvider! (enum)
            if (this.CloudProvider == null && Exploration.Includes(parent + ".cloudProvider$"))
            {
                this.CloudProvider = new CloudProvider();
            }
            //      C# -> RetentionUnit? RetentionUnit
            // GraphQL -> retentionUnit: RetentionUnit! (enum)
            if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit$"))
            {
                this.RetentionUnit = new RetentionUnit();
            }
        }


    #endregion

    } // class ReplicationToCloudRegionSpec
    #endregion

    public static class ListReplicationToCloudRegionSpecExtensions
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
            this List<ReplicationToCloudRegionSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationToCloudRegionSpec> list, 
            String parent = "")
        {
            var item = new ReplicationToCloudRegionSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types