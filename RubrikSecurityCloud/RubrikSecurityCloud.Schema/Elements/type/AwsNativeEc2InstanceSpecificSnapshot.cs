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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotServiceConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotServiceConsistencyLevel! (enum)
        if (this.ConsistencyLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consistencyLevel\n" ;
            } else {
                s += ind + "consistencyLevel\n" ;
            }
        }
        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        if (this.AwsNativeAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeAccountId\n" ;
            } else {
                s += ind + "awsNativeAccountId\n" ;
            }
        }
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String! (scalar)
        if (this.IamInstanceProfileArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iamInstanceProfileArn\n" ;
            } else {
                s += ind + "iamInstanceProfileArn\n" ;
            }
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceType\n" ;
            } else {
                s += ind + "instanceType\n" ;
            }
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeName\n" ;
            } else {
                s += ind + "nativeName\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> List<System.String>? VolumeSnapshotsToExclude
        // GraphQL -> volumeSnapshotsToExclude: [String!]! (scalar)
        if (this.VolumeSnapshotsToExclude != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeSnapshotsToExclude\n" ;
            } else {
                s += ind + "volumeSnapshotsToExclude\n" ;
            }
        }
        //      C# -> DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap
        // GraphQL -> devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap! (type)
        if (this.DevicePathToVolumeSnapshotIdMap != null) {
            var fspec = this.DevicePathToVolumeSnapshotIdMap.AsFieldSpec(conf.Child("devicePathToVolumeSnapshotIdMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "devicePathToVolumeSnapshotIdMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SnapshotServiceConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotServiceConsistencyLevel! (enum)
        if (ec.Includes("consistencyLevel",true))
        {
            if(this.ConsistencyLevel == null) {

                this.ConsistencyLevel = new SnapshotServiceConsistencyLevel();

            } else {


            }
        }
        else if (this.ConsistencyLevel != null && ec.Excludes("consistencyLevel",true))
        {
            this.ConsistencyLevel = null;
        }
        //      C# -> System.String? AwsNativeAccountId
        // GraphQL -> awsNativeAccountId: String! (scalar)
        if (ec.Includes("awsNativeAccountId",true))
        {
            if(this.AwsNativeAccountId == null) {

                this.AwsNativeAccountId = "FETCH";

            } else {


            }
        }
        else if (this.AwsNativeAccountId != null && ec.Excludes("awsNativeAccountId",true))
        {
            this.AwsNativeAccountId = null;
        }
        //      C# -> System.String? IamInstanceProfileArn
        // GraphQL -> iamInstanceProfileArn: String! (scalar)
        if (ec.Includes("iamInstanceProfileArn",true))
        {
            if(this.IamInstanceProfileArn == null) {

                this.IamInstanceProfileArn = "FETCH";

            } else {


            }
        }
        else if (this.IamInstanceProfileArn != null && ec.Excludes("iamInstanceProfileArn",true))
        {
            this.IamInstanceProfileArn = null;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (ec.Includes("instanceType",true))
        {
            if(this.InstanceType == null) {

                this.InstanceType = "FETCH";

            } else {


            }
        }
        else if (this.InstanceType != null && ec.Excludes("instanceType",true))
        {
            this.InstanceType = null;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (ec.Includes("nativeId",true))
        {
            if(this.NativeId == null) {

                this.NativeId = "FETCH";

            } else {


            }
        }
        else if (this.NativeId != null && ec.Excludes("nativeId",true))
        {
            this.NativeId = null;
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (ec.Includes("nativeName",true))
        {
            if(this.NativeName == null) {

                this.NativeName = "FETCH";

            } else {


            }
        }
        else if (this.NativeName != null && ec.Excludes("nativeName",true))
        {
            this.NativeName = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> List<System.String>? VolumeSnapshotsToExclude
        // GraphQL -> volumeSnapshotsToExclude: [String!]! (scalar)
        if (ec.Includes("volumeSnapshotsToExclude",true))
        {
            if(this.VolumeSnapshotsToExclude == null) {

                this.VolumeSnapshotsToExclude = new List<System.String>();

            } else {


            }
        }
        else if (this.VolumeSnapshotsToExclude != null && ec.Excludes("volumeSnapshotsToExclude",true))
        {
            this.VolumeSnapshotsToExclude = null;
        }
        //      C# -> DevicePathToVolumeSnapshotIdMap? DevicePathToVolumeSnapshotIdMap
        // GraphQL -> devicePathToVolumeSnapshotIdMap: DevicePathToVolumeSnapshotIdMap! (type)
        if (ec.Includes("devicePathToVolumeSnapshotIdMap",false))
        {
            if(this.DevicePathToVolumeSnapshotIdMap == null) {

                this.DevicePathToVolumeSnapshotIdMap = new DevicePathToVolumeSnapshotIdMap();
                this.DevicePathToVolumeSnapshotIdMap.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdMap"));

            } else {

                this.DevicePathToVolumeSnapshotIdMap.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdMap"));

            }
        }
        else if (this.DevicePathToVolumeSnapshotIdMap != null && ec.Excludes("devicePathToVolumeSnapshotIdMap",false))
        {
            this.DevicePathToVolumeSnapshotIdMap = null;
        }
    }


    #endregion

    } // class AwsNativeEc2InstanceSpecificSnapshot
    
    #endregion

    public static class ListAwsNativeEc2InstanceSpecificSnapshotExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsNativeEc2InstanceSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeEc2InstanceSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeEc2InstanceSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeEc2InstanceSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeEc2InstanceSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types