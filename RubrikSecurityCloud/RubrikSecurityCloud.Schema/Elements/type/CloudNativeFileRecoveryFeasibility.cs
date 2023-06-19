// CloudNativeFileRecoveryFeasibility.cs
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
    #region CloudNativeFileRecoveryFeasibility
    public class CloudNativeFileRecoveryFeasibility: BaseType
    {
        #region members

        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        [JsonProperty("fileRecoveryFeasibility")]
        public FileRecoveryFeasibility? FileRecoveryFeasibility { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public CloudNativeFileRecoveryFeasibility Set(
        FileRecoveryFeasibility? FileRecoveryFeasibility = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( FileRecoveryFeasibility != null ) {
            this.FileRecoveryFeasibility = FileRecoveryFeasibility;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility != null) {
            s += ind + "fileRecoveryFeasibility\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FileRecoveryFeasibility? FileRecoveryFeasibility
        // GraphQL -> fileRecoveryFeasibility: FileRecoveryFeasibility! (enum)
        if (this.FileRecoveryFeasibility == null && Exploration.Includes(parent + ".fileRecoveryFeasibility", true))
        {
            this.FileRecoveryFeasibility = new FileRecoveryFeasibility();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
    }


    #endregion

    } // class CloudNativeFileRecoveryFeasibility
    
    #endregion

    public static class ListCloudNativeFileRecoveryFeasibilityExtensions
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
            this List<CloudNativeFileRecoveryFeasibility> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeFileRecoveryFeasibility> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeFileRecoveryFeasibility());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types