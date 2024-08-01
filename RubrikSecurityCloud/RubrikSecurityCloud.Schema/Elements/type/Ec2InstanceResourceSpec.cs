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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceType\n" ;
            } else {
                s += ind + "instanceType\n" ;
            }
        }
        //      C# -> System.Int32? InstanceTypeMemoryMbs
        // GraphQL -> instanceTypeMemoryMbs: Int! (scalar)
        if (this.InstanceTypeMemoryMbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceTypeMemoryMbs\n" ;
            } else {
                s += ind + "instanceTypeMemoryMbs\n" ;
            }
        }
        //      C# -> System.Int32? InstanceTypeVcpus
        // GraphQL -> instanceTypeVcpus: Int! (scalar)
        if (this.InstanceTypeVcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceTypeVcpus\n" ;
            } else {
                s += ind + "instanceTypeVcpus\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
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
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPointOpt\n" ;
            } else {
                s += ind + "recoveryPointOpt\n" ;
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
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableName\n" ;
            } else {
                s += ind + "snappableName\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> List<Ec2InstanceNic>? Ec2InstanceNics
        // GraphQL -> ec2InstanceNics: [Ec2InstanceNic!]! (type)
        if (this.Ec2InstanceNics != null) {
            var fspec = this.Ec2InstanceNics.AsFieldSpec(conf.Child("ec2InstanceNics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ec2InstanceNics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs
        // GraphQL -> ec2InstanceVolumeSpecs: [Ec2InstanceVolume!]! (type)
        if (this.Ec2InstanceVolumeSpecs != null) {
            var fspec = this.Ec2InstanceVolumeSpecs.AsFieldSpec(conf.Child("ec2InstanceVolumeSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ec2InstanceVolumeSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.Int32? InstanceTypeMemoryMbs
        // GraphQL -> instanceTypeMemoryMbs: Int! (scalar)
        if (ec.Includes("instanceTypeMemoryMbs",true))
        {
            if(this.InstanceTypeMemoryMbs == null) {

                this.InstanceTypeMemoryMbs = Int32.MinValue;

            } else {


            }
        }
        else if (this.InstanceTypeMemoryMbs != null && ec.Excludes("instanceTypeMemoryMbs",true))
        {
            this.InstanceTypeMemoryMbs = null;
        }
        //      C# -> System.Int32? InstanceTypeVcpus
        // GraphQL -> instanceTypeVcpus: Int! (scalar)
        if (ec.Includes("instanceTypeVcpus",true))
        {
            if(this.InstanceTypeVcpus == null) {

                this.InstanceTypeVcpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.InstanceTypeVcpus != null && ec.Excludes("instanceTypeVcpus",true))
        {
            this.InstanceTypeVcpus = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
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
        //      C# -> System.String? OsType
        // GraphQL -> osType: String! (scalar)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = "FETCH";

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (ec.Includes("recoveryPointOpt",true))
        {
            if(this.RecoveryPointOpt == null) {

                this.RecoveryPointOpt = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPointOpt != null && ec.Excludes("recoveryPointOpt",true))
        {
            this.RecoveryPointOpt = null;
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
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (ec.Includes("snappableName",true))
        {
            if(this.SnappableName == null) {

                this.SnappableName = "FETCH";

            } else {


            }
        }
        else if (this.SnappableName != null && ec.Excludes("snappableName",true))
        {
            this.SnappableName = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
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
        //      C# -> List<Ec2InstanceNic>? Ec2InstanceNics
        // GraphQL -> ec2InstanceNics: [Ec2InstanceNic!]! (type)
        if (ec.Includes("ec2InstanceNics",false))
        {
            if(this.Ec2InstanceNics == null) {

                this.Ec2InstanceNics = new List<Ec2InstanceNic>();
                this.Ec2InstanceNics.ApplyExploratoryFieldSpec(ec.NewChild("ec2InstanceNics"));

            } else {

                this.Ec2InstanceNics.ApplyExploratoryFieldSpec(ec.NewChild("ec2InstanceNics"));

            }
        }
        else if (this.Ec2InstanceNics != null && ec.Excludes("ec2InstanceNics",false))
        {
            this.Ec2InstanceNics = null;
        }
        //      C# -> List<Ec2InstanceVolume>? Ec2InstanceVolumeSpecs
        // GraphQL -> ec2InstanceVolumeSpecs: [Ec2InstanceVolume!]! (type)
        if (ec.Includes("ec2InstanceVolumeSpecs",false))
        {
            if(this.Ec2InstanceVolumeSpecs == null) {

                this.Ec2InstanceVolumeSpecs = new List<Ec2InstanceVolume>();
                this.Ec2InstanceVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("ec2InstanceVolumeSpecs"));

            } else {

                this.Ec2InstanceVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("ec2InstanceVolumeSpecs"));

            }
        }
        else if (this.Ec2InstanceVolumeSpecs != null && ec.Excludes("ec2InstanceVolumeSpecs",false))
        {
            this.Ec2InstanceVolumeSpecs = null;
        }
    }


    #endregion

    } // class Ec2InstanceResourceSpec
    
    #endregion

    public static class ListEc2InstanceResourceSpecExtensions
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
            this List<Ec2InstanceResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Ec2InstanceResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Ec2InstanceResourceSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Ec2InstanceResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Ec2InstanceResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types