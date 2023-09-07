// AwsNativeEc2InstanceSpecificSnapshot.cs
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
    #region AwsNativeEc2InstanceSpecificSnapshot
 
    public class AwsNativeEc2InstanceSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> SnapshotServiceConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotServiceConsistencyLevel! (enum)
        [JsonProperty("consistencyLevel")]
        public SnapshotServiceConsistencyLevel? ConsistencyLevel { get; set; }

        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        [JsonProperty("awsNativeAccountId")]
        public System.String? AwsNativeAccountId { get; set; }

        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String! (scalar)
        [JsonProperty("iamInstanceProfileArn")]
        public System.String? IamInstanceProfileArn { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<System.String>? VolumeSnapshotsToExclude
        // GraphQL -> volumeSnapshotsToExclude: [String!]! (scalar)
        [JsonProperty("volumeSnapshotsToExclude")]
        public List<System.String>? VolumeSnapshotsToExclude { get; set; }

        //      C# -> DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap
        // GraphQL -> devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap! (type)
        [JsonProperty("devicePathToVolumeSnapshotIdMap")]
        public DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeEc2InstanceSpecificSnapshot";
    }

    public AwsNativeEc2InstanceSpecificSnapshot Set(
        SnapshotServiceConsistencyLevel? ConsistencyLevel = null,
        System.String? AwsNativeAccountId = null,
        System.String? IamInstanceProfileArn = null,
        System.String? InstanceType = null,
        System.String? NativeId = null,
        System.String? NativeName = null,
        System.String? Region = null,
        System.String? SnapshotId = null,
        List<System.String>? VolumeSnapshotsToExclude = null,
        DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap = null
    ) 
    {
        if ( ConsistencyLevel != null ) {
            this.ConsistencyLevel = ConsistencyLevel;
        }
        if ( AwsNativeAccountId != null ) {
            this.AwsNativeAccountId = AwsNativeAccountId;
        }
        if ( IamInstanceProfileArn != null ) {
            this.IamInstanceProfileArn = IamInstanceProfileArn;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( VolumeSnapshotsToExclude != null ) {
            this.VolumeSnapshotsToExclude = VolumeSnapshotsToExclude;
        }
        if ( DevicePathToVolumeSnapshotIdMap != null ) {
            this.DevicePathToVolumeSnapshotIdMap = DevicePathToVolumeSnapshotIdMap;
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
        //      C# -> SnapshotServiceConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotServiceConsistencyLevel! (enum)
        if (this.ConsistencyLevel != null) {
            s += ind + "consistencyLevel\n" ;
        }
        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        if (this.AwsNativeAccountId != null) {
            s += ind + "awsNativeAccountId\n" ;
        }
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String! (scalar)
        if (this.IamInstanceProfileArn != null) {
            s += ind + "iamInstanceProfileArn\n" ;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName != null) {
            s += ind + "nativeName\n" ;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> List<System.String>? VolumeSnapshotsToExclude
        // GraphQL -> volumeSnapshotsToExclude: [String!]! (scalar)
        if (this.VolumeSnapshotsToExclude != null) {
            s += ind + "volumeSnapshotsToExclude\n" ;
        }
        //      C# -> DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap
        // GraphQL -> devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap! (type)
        if (this.DevicePathToVolumeSnapshotIdMap != null) {
            var fspec = this.DevicePathToVolumeSnapshotIdMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "devicePathToVolumeSnapshotIdMap {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotServiceConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotServiceConsistencyLevel! (enum)
        if (this.ConsistencyLevel == null && ec.Includes("consistencyLevel",true))
        {
            this.ConsistencyLevel = new SnapshotServiceConsistencyLevel();
        }
        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        if (this.AwsNativeAccountId == null && ec.Includes("awsNativeAccountId",true))
        {
            this.AwsNativeAccountId = "FETCH";
        }
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String! (scalar)
        if (this.IamInstanceProfileArn == null && ec.Includes("iamInstanceProfileArn",true))
        {
            this.IamInstanceProfileArn = "FETCH";
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType == null && ec.Includes("instanceType",true))
        {
            this.InstanceType = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && ec.Includes("nativeId",true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName == null && ec.Includes("nativeName",true))
        {
            this.NativeName = "FETCH";
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> List<System.String>? VolumeSnapshotsToExclude
        // GraphQL -> volumeSnapshotsToExclude: [String!]! (scalar)
        if (this.VolumeSnapshotsToExclude == null && ec.Includes("volumeSnapshotsToExclude",true))
        {
            this.VolumeSnapshotsToExclude = new List<System.String>();
        }
        //      C# -> DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap
        // GraphQL -> devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap! (type)
        if (this.DevicePathToVolumeSnapshotIdMap == null && ec.Includes("devicePathToVolumeSnapshotIdMap",false))
        {
            this.DevicePathToVolumeSnapshotIdMap = new DevicePathToVolumeSnapshotIdMap();
            this.DevicePathToVolumeSnapshotIdMap.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdMap"));
        }
    }


    #endregion

    } // class AwsNativeEc2InstanceSpecificSnapshot
    
    #endregion

    public static class ListAwsNativeEc2InstanceSpecificSnapshotExtensions
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
            this List<AwsNativeEc2InstanceSpecificSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeEc2InstanceSpecificSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeEc2InstanceSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AwsNativeEc2InstanceSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types