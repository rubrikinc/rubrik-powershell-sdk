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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CloudNativeSnapshotDetailsForRecovery";
    }

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
            var fspec = this.CloudNativeAccountId.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudNativeAccountId {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion != null) {
            var fspec = this.SnapshotRegion.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotRegion {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (this.CloudType == null && ec.Includes("cloudType",true))
        {
            this.CloudType = new CloudProviderType();
        }
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility == null && ec.Includes("fileRecoveryFeasibility",true))
        {
            this.FileRecoveryFeasibility = new FileRecoveryFeasibility();
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType == null && ec.Includes("snapshotType",true))
        {
            this.SnapshotType = new SnapshotType();
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (this.CloudNativeAccountId == null && ec.Includes("cloudNativeAccountId",false))
        {
            this.CloudNativeAccountId = new CloudNativeAccountIdWithName();
            this.CloudNativeAccountId.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccountId"));
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion == null && ec.Includes("snapshotRegion",false))
        {
            this.SnapshotRegion = new CloudNativeRegion();
            this.SnapshotRegion.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRegion"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotDetailsForRecovery> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotDetailsForRecovery());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CloudNativeSnapshotDetailsForRecovery> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types