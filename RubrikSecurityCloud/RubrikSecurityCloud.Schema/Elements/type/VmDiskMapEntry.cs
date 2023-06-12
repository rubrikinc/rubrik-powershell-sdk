// VmDiskMapEntry.cs
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
    #region VmDiskMapEntry
    public class VmDiskMapEntry: BaseType
    {
        #region members

        //      C# -> System.String? SourceVmDiskId
        // GraphQL -> sourceVmDiskId: String! (scalar)
        [JsonProperty("sourceVmDiskId")]
        public System.String? SourceVmDiskId { get; set; }

        //      C# -> System.String? TargetDiskId
        // GraphQL -> targetDiskId: String! (scalar)
        [JsonProperty("targetDiskId")]
        public System.String? TargetDiskId { get; set; }

        //      C# -> System.String? TargetDiskNativeId
        // GraphQL -> targetDiskNativeId: String! (scalar)
        [JsonProperty("targetDiskNativeId")]
        public System.String? TargetDiskNativeId { get; set; }

        //      C# -> System.Boolean? TargetIsOsDisk
        // GraphQL -> targetIsOsDisk: Boolean! (scalar)
        [JsonProperty("targetIsOsDisk")]
        public System.Boolean? TargetIsOsDisk { get; set; }

        //      C# -> System.Int64? TargetLogicalSize
        // GraphQL -> targetLogicalSize: Long! (scalar)
        [JsonProperty("targetLogicalSize")]
        public System.Int64? TargetLogicalSize { get; set; }

        //      C# -> System.String? TargetSnapshotId
        // GraphQL -> targetSnapshotId: String! (scalar)
        [JsonProperty("targetSnapshotId")]
        public System.String? TargetSnapshotId { get; set; }

        //      C# -> VmDatastore? SourceDatastore
        // GraphQL -> sourceDatastore: VmDatastore (type)
        [JsonProperty("sourceDatastore")]
        public VmDatastore? SourceDatastore { get; set; }


        #endregion

    #region methods

    public VmDiskMapEntry Set(
        System.String? SourceVmDiskId = null,
        System.String? TargetDiskId = null,
        System.String? TargetDiskNativeId = null,
        System.Boolean? TargetIsOsDisk = null,
        System.Int64? TargetLogicalSize = null,
        System.String? TargetSnapshotId = null,
        VmDatastore? SourceDatastore = null
    ) 
    {
        if ( SourceVmDiskId != null ) {
            this.SourceVmDiskId = SourceVmDiskId;
        }
        if ( TargetDiskId != null ) {
            this.TargetDiskId = TargetDiskId;
        }
        if ( TargetDiskNativeId != null ) {
            this.TargetDiskNativeId = TargetDiskNativeId;
        }
        if ( TargetIsOsDisk != null ) {
            this.TargetIsOsDisk = TargetIsOsDisk;
        }
        if ( TargetLogicalSize != null ) {
            this.TargetLogicalSize = TargetLogicalSize;
        }
        if ( TargetSnapshotId != null ) {
            this.TargetSnapshotId = TargetSnapshotId;
        }
        if ( SourceDatastore != null ) {
            this.SourceDatastore = SourceDatastore;
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
        //      C# -> System.String? SourceVmDiskId
        // GraphQL -> sourceVmDiskId: String! (scalar)
        if (this.SourceVmDiskId != null) {
            s += ind + "sourceVmDiskId\n" ;
        }
        //      C# -> System.String? TargetDiskId
        // GraphQL -> targetDiskId: String! (scalar)
        if (this.TargetDiskId != null) {
            s += ind + "targetDiskId\n" ;
        }
        //      C# -> System.String? TargetDiskNativeId
        // GraphQL -> targetDiskNativeId: String! (scalar)
        if (this.TargetDiskNativeId != null) {
            s += ind + "targetDiskNativeId\n" ;
        }
        //      C# -> System.Boolean? TargetIsOsDisk
        // GraphQL -> targetIsOsDisk: Boolean! (scalar)
        if (this.TargetIsOsDisk != null) {
            s += ind + "targetIsOsDisk\n" ;
        }
        //      C# -> System.Int64? TargetLogicalSize
        // GraphQL -> targetLogicalSize: Long! (scalar)
        if (this.TargetLogicalSize != null) {
            s += ind + "targetLogicalSize\n" ;
        }
        //      C# -> System.String? TargetSnapshotId
        // GraphQL -> targetSnapshotId: String! (scalar)
        if (this.TargetSnapshotId != null) {
            s += ind + "targetSnapshotId\n" ;
        }
        //      C# -> VmDatastore? SourceDatastore
        // GraphQL -> sourceDatastore: VmDatastore (type)
        if (this.SourceDatastore != null) {
            var fspec = this.SourceDatastore.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceDatastore {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SourceVmDiskId
        // GraphQL -> sourceVmDiskId: String! (scalar)
        if (this.SourceVmDiskId == null && Exploration.Includes(parent + ".sourceVmDiskId", true))
        {
            this.SourceVmDiskId = "FETCH";
        }
        //      C# -> System.String? TargetDiskId
        // GraphQL -> targetDiskId: String! (scalar)
        if (this.TargetDiskId == null && Exploration.Includes(parent + ".targetDiskId", true))
        {
            this.TargetDiskId = "FETCH";
        }
        //      C# -> System.String? TargetDiskNativeId
        // GraphQL -> targetDiskNativeId: String! (scalar)
        if (this.TargetDiskNativeId == null && Exploration.Includes(parent + ".targetDiskNativeId", true))
        {
            this.TargetDiskNativeId = "FETCH";
        }
        //      C# -> System.Boolean? TargetIsOsDisk
        // GraphQL -> targetIsOsDisk: Boolean! (scalar)
        if (this.TargetIsOsDisk == null && Exploration.Includes(parent + ".targetIsOsDisk", true))
        {
            this.TargetIsOsDisk = true;
        }
        //      C# -> System.Int64? TargetLogicalSize
        // GraphQL -> targetLogicalSize: Long! (scalar)
        if (this.TargetLogicalSize == null && Exploration.Includes(parent + ".targetLogicalSize", true))
        {
            this.TargetLogicalSize = new System.Int64();
        }
        //      C# -> System.String? TargetSnapshotId
        // GraphQL -> targetSnapshotId: String! (scalar)
        if (this.TargetSnapshotId == null && Exploration.Includes(parent + ".targetSnapshotId", true))
        {
            this.TargetSnapshotId = "FETCH";
        }
        //      C# -> VmDatastore? SourceDatastore
        // GraphQL -> sourceDatastore: VmDatastore (type)
        if (this.SourceDatastore == null && Exploration.Includes(parent + ".sourceDatastore"))
        {
            this.SourceDatastore = new VmDatastore();
            this.SourceDatastore.ApplyExploratoryFieldSpec(parent + ".sourceDatastore");
        }
    }


    #endregion

    } // class VmDiskMapEntry
    
    #endregion

    public static class ListVmDiskMapEntryExtensions
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
            this List<VmDiskMapEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmDiskMapEntry> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmDiskMapEntry());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types