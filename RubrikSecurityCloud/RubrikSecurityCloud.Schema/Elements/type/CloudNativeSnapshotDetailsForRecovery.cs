// CloudNativeSnapshotDetailsForRecovery.cs
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
    #region CloudNativeSnapshotDetailsForRecovery
    public class CloudNativeSnapshotDetailsForRecovery: IFragment
    {
        #region members
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        [JsonProperty("cloudNativeAccountId")]
        public CloudNativeAccountIdWithName? CloudNativeAccountId { get; set; }

        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        [JsonProperty("snapshotRegion")]
        public CloudNativeRegion? SnapshotRegion { get; set; }

        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        [JsonProperty("cloudType")]
        public CloudProviderType? CloudType { get; set; }

        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        [JsonProperty("fileRecoveryFeasibility")]
        public FileRecoveryFeasibility? FileRecoveryFeasibility { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        #endregion

    #region methods

    public CloudNativeSnapshotDetailsForRecovery Set(
        CloudNativeAccountIdWithName? CloudNativeAccountId = null,
        CloudNativeRegion? SnapshotRegion = null,
        CloudProviderType? CloudType = null,
        FileRecoveryFeasibility? FileRecoveryFeasibility = null,
        SnapshotType? SnapshotType = null
    ) 
    {
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( SnapshotRegion != null ) {
            this.SnapshotRegion = SnapshotRegion;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( FileRecoveryFeasibility != null ) {
            this.FileRecoveryFeasibility = FileRecoveryFeasibility;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
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
            //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
            // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
            if (this.CloudNativeAccountId != null)
            {
                 s += ind + "cloudNativeAccountId\n";

                 s += ind + "{\n" + 
                 this.CloudNativeAccountId.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CloudNativeRegion? SnapshotRegion
            // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
            if (this.SnapshotRegion != null)
            {
                 s += ind + "snapshotRegion\n";

                 s += ind + "{\n" + 
                 this.SnapshotRegion.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CloudProviderType? CloudType
            // GraphQL -> cloudType: CloudProviderType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
            // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
            if (this.FileRecoveryFeasibility != null)
            {
                 s += ind + "fileRecoveryFeasibility\n";

            }
            //      C# -> SnapshotType? SnapshotType
            // GraphQL -> snapshotType: SnapshotType! (enum)
            if (this.SnapshotType != null)
            {
                 s += ind + "snapshotType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
            // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
            if (this.CloudNativeAccountId == null && Exploration.Includes(parent + ".cloudNativeAccountId"))
            {
                this.CloudNativeAccountId = new CloudNativeAccountIdWithName();
                this.CloudNativeAccountId.ApplyExploratoryFragment(parent + ".cloudNativeAccountId");
            }
            //      C# -> CloudNativeRegion? SnapshotRegion
            // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
            if (this.SnapshotRegion == null && Exploration.Includes(parent + ".snapshotRegion"))
            {
                this.SnapshotRegion = new CloudNativeRegion();
                this.SnapshotRegion.ApplyExploratoryFragment(parent + ".snapshotRegion");
            }
            //      C# -> CloudProviderType? CloudType
            // GraphQL -> cloudType: CloudProviderType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new CloudProviderType();
            }
            //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
            // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
            if (this.FileRecoveryFeasibility == null && Exploration.Includes(parent + ".fileRecoveryFeasibility$"))
            {
                this.FileRecoveryFeasibility = new FileRecoveryFeasibility();
            }
            //      C# -> SnapshotType? SnapshotType
            // GraphQL -> snapshotType: SnapshotType! (enum)
            if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType$"))
            {
                this.SnapshotType = new SnapshotType();
            }
        }


    #endregion

    } // class CloudNativeSnapshotDetailsForRecovery
    #endregion

    public static class ListCloudNativeSnapshotDetailsForRecoveryExtensions
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
            this List<CloudNativeSnapshotDetailsForRecovery> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeSnapshotDetailsForRecovery> list, 
            String parent = "")
        {
            var item = new CloudNativeSnapshotDetailsForRecovery();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types