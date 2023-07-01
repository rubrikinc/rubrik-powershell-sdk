// Ec2InstanceResourceSpec.cs
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
    #region Ec2InstanceResourceSpec
 
    public class Ec2InstanceResourceSpec: BaseType, ResourceSpec
    {
        #region members

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.Int32? InstanceTypeMemoryMbs
        // GraphQL -> instanceTypeMemoryMbs: Int! (scalar)
        [JsonProperty("instanceTypeMemoryMbs")]
        public System.Int32? InstanceTypeMemoryMbs { get; set; }

        //      C# -> System.Int32? InstanceTypeVcpus
        // GraphQL -> instanceTypeVcpus: Int! (scalar)
        [JsonProperty("instanceTypeVcpus")]
        public System.Int32? InstanceTypeVcpus { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        [JsonProperty("recoveryPointOpt")]
        public System.Int64? RecoveryPointOpt { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        [JsonProperty("snappableName")]
        public System.String? SnappableName { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<Ec2InstanceNic>? Ec2InstanceNics
        // GraphQL -> ec2InstanceNics: [Ec2InstanceNic!]! (type)
        [JsonProperty("ec2InstanceNics")]
        public List<Ec2InstanceNic>? Ec2InstanceNics { get; set; }

        //      C# -> List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs
        // GraphQL -> ec2InstanceVolumeSpecs: [Ec2InstanceVolume!]! (type)
        [JsonProperty("ec2InstanceVolumeSpecs")]
        public List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ec2InstanceResourceSpec";
    }

    public Ec2InstanceResourceSpec Set(
        System.String? InstanceType = null,
        System.Int32? InstanceTypeMemoryMbs = null,
        System.Int32? InstanceTypeVcpus = null,
        System.Boolean? IsArchived = null,
        System.String? NativeId = null,
        System.String? OsType = null,
        System.Int64? RecoveryPointOpt = null,
        System.String? Region = null,
        System.String? SnappableId = null,
        System.String? SnappableName = null,
        System.String? SnapshotId = null,
        List<Ec2InstanceNic>? Ec2InstanceNics = null,
        List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs = null
    ) 
    {
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( InstanceTypeMemoryMbs != null ) {
            this.InstanceTypeMemoryMbs = InstanceTypeMemoryMbs;
        }
        if ( InstanceTypeVcpus != null ) {
            this.InstanceTypeVcpus = InstanceTypeVcpus;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( RecoveryPointOpt != null ) {
            this.RecoveryPointOpt = RecoveryPointOpt;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnappableName != null ) {
            this.SnappableName = SnappableName;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Ec2InstanceNics != null ) {
            this.Ec2InstanceNics = Ec2InstanceNics;
        }
        if ( Ec2InstanceVolumeSpecs != null ) {
            this.Ec2InstanceVolumeSpecs = Ec2InstanceVolumeSpecs;
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
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        //      C# -> System.Int32? InstanceTypeMemoryMbs
        // GraphQL -> instanceTypeMemoryMbs: Int! (scalar)
        if (this.InstanceTypeMemoryMbs != null) {
            s += ind + "instanceTypeMemoryMbs\n" ;
        }
        //      C# -> System.Int32? InstanceTypeVcpus
        // GraphQL -> instanceTypeVcpus: Int! (scalar)
        if (this.InstanceTypeVcpus != null) {
            s += ind + "instanceTypeVcpus\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            s += ind + "recoveryPointOpt\n" ;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName != null) {
            s += ind + "snappableName\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> List<Ec2InstanceNic>? Ec2InstanceNics
        // GraphQL -> ec2InstanceNics: [Ec2InstanceNic!]! (type)
        if (this.Ec2InstanceNics != null) {
            var fspec = this.Ec2InstanceNics.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ec2InstanceNics {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs
        // GraphQL -> ec2InstanceVolumeSpecs: [Ec2InstanceVolume!]! (type)
        if (this.Ec2InstanceVolumeSpecs != null) {
            var fspec = this.Ec2InstanceVolumeSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ec2InstanceVolumeSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType", true))
        {
            this.InstanceType = "FETCH";
        }
        //      C# -> System.Int32? InstanceTypeMemoryMbs
        // GraphQL -> instanceTypeMemoryMbs: Int! (scalar)
        if (this.InstanceTypeMemoryMbs == null && Exploration.Includes(parent + ".instanceTypeMemoryMbs", true))
        {
            this.InstanceTypeMemoryMbs = Int32.MinValue;
        }
        //      C# -> System.Int32? InstanceTypeVcpus
        // GraphQL -> instanceTypeVcpus: Int! (scalar)
        if (this.InstanceTypeVcpus == null && Exploration.Includes(parent + ".instanceTypeVcpus", true))
        {
            this.InstanceTypeVcpus = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && Exploration.Includes(parent + ".nativeId", true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = "FETCH";
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt == null && Exploration.Includes(parent + ".recoveryPointOpt", true))
        {
            this.RecoveryPointOpt = new System.Int64();
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = "FETCH";
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId", true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName == null && Exploration.Includes(parent + ".snappableName", true))
        {
            this.SnappableName = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> List<Ec2InstanceNic>? Ec2InstanceNics
        // GraphQL -> ec2InstanceNics: [Ec2InstanceNic!]! (type)
        if (this.Ec2InstanceNics == null && Exploration.Includes(parent + ".ec2InstanceNics"))
        {
            this.Ec2InstanceNics = new List<Ec2InstanceNic>();
            this.Ec2InstanceNics.ApplyExploratoryFieldSpec(parent + ".ec2InstanceNics");
        }
        //      C# -> List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs
        // GraphQL -> ec2InstanceVolumeSpecs: [Ec2InstanceVolume!]! (type)
        if (this.Ec2InstanceVolumeSpecs == null && Exploration.Includes(parent + ".ec2InstanceVolumeSpecs"))
        {
            this.Ec2InstanceVolumeSpecs = new List<Ec2InstanceVolume>();
            this.Ec2InstanceVolumeSpecs.ApplyExploratoryFieldSpec(parent + ".ec2InstanceVolumeSpecs");
        }
    }


    #endregion

    } // class Ec2InstanceResourceSpec
    
    #endregion

    public static class ListEc2InstanceResourceSpecExtensions
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
            this List<Ec2InstanceResourceSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Ec2InstanceResourceSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Ec2InstanceResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types