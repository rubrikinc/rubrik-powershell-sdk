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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CloudNativeSnapshotDetailsForRecovery
    public class CloudNativeSnapshotDetailsForRecovery: BaseType
    {
        #region members

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

        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        [JsonProperty("cloudNativeAccountId")]
        public CloudNativeAccountIdWithName? CloudNativeAccountId { get; set; }

        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        [JsonProperty("snapshotRegion")]
        public CloudNativeRegion? SnapshotRegion { get; set; }


        #endregion

    #region methods

    public CloudNativeSnapshotDetailsForRecovery Set(
        CloudProviderType? CloudType = null,
        FileRecoveryFeasibility? FileRecoveryFeasibility = null,
        SnapshotType? SnapshotType = null,
        CloudNativeAccountIdWithName? CloudNativeAccountId = null,
        CloudNativeRegion? SnapshotRegion = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( FileRecoveryFeasibility != null ) {
            this.FileRecoveryFeasibility = FileRecoveryFeasibility;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( SnapshotRegion != null ) {
            this.SnapshotRegion = SnapshotRegion;
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
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (this.CloudType != null) {
            s += ind + "cloudType\n" ;
        }
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility != null) {
            s += ind + "fileRecoveryFeasibility\n" ;
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType != null) {
            s += ind + "snapshotType\n" ;
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (this.CloudNativeAccountId != null) {
            s += ind + "cloudNativeAccountId {\n" + this.CloudNativeAccountId.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion != null) {
            s += ind + "snapshotRegion {\n" + this.SnapshotRegion.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (this.CloudType == null && Exploration.Includes(parent + ".cloudType", true))
        {
            this.CloudType = new CloudProviderType();
        }
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility == null && Exploration.Includes(parent + ".fileRecoveryFeasibility", true))
        {
            this.FileRecoveryFeasibility = new FileRecoveryFeasibility();
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType", true))
        {
            this.SnapshotType = new SnapshotType();
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (this.CloudNativeAccountId == null && Exploration.Includes(parent + ".cloudNativeAccountId"))
        {
            this.CloudNativeAccountId = new CloudNativeAccountIdWithName();
            this.CloudNativeAccountId.ApplyExploratoryFieldSpec(parent + ".cloudNativeAccountId");
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion == null && Exploration.Includes(parent + ".snapshotRegion"))
        {
            this.SnapshotRegion = new CloudNativeRegion();
            this.SnapshotRegion.ApplyExploratoryFieldSpec(parent + ".snapshotRegion");
        }
    }


    #endregion

    } // class CloudNativeSnapshotDetailsForRecovery
    
    #endregion

    public static class ListCloudNativeSnapshotDetailsForRecoveryExtensions
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
            this List<CloudNativeSnapshotDetailsForRecovery> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotDetailsForRecovery> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotDetailsForRecovery());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types