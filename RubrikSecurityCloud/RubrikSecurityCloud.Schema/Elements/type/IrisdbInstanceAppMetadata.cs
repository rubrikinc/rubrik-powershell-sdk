// IrisdbInstanceAppMetadata.cs
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
    #region IrisdbInstanceAppMetadata
    public class IrisdbInstanceAppMetadata: BaseType
    {
        #region members

        //      C# -> IrisdbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: IrisdbSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public IrisdbSnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String (scalar)
        [JsonProperty("instanceVersion")]
        public System.String? InstanceVersion { get; set; }

        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        [JsonProperty("mountPaths")]
        public List<System.String>? MountPaths { get; set; }

        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        [JsonProperty("stats")]
        public KosmosDataSnapshotStats? Stats { get; set; }

        //      C# -> List<IrisdbSnapshotVolumeInfo>? Volumes
        // GraphQL -> volumes: [IrisdbSnapshotVolumeInfo!]! (type)
        [JsonProperty("volumes")]
        public List<IrisdbSnapshotVolumeInfo>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IrisdbInstanceAppMetadata";
    }

    public IrisdbInstanceAppMetadata Set(
        IrisdbSnapshotType? SnapshotType = null,
        System.String? InstanceVersion = null,
        List<System.String>? MountPaths = null,
        KosmosDataSnapshotStats? Stats = null,
        List<IrisdbSnapshotVolumeInfo>? Volumes = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( InstanceVersion != null ) {
            this.InstanceVersion = InstanceVersion;
        }
        if ( MountPaths != null ) {
            this.MountPaths = MountPaths;
        }
        if ( Stats != null ) {
            this.Stats = Stats;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
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
        //      C# -> IrisdbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: IrisdbSnapshotType (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String (scalar)
        if (this.InstanceVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceVersion\n" ;
            } else {
                s += ind + "instanceVersion\n" ;
            }
        }
        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        if (this.MountPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountPaths\n" ;
            } else {
                s += ind + "mountPaths\n" ;
            }
        }
        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        if (this.Stats != null) {
            var fspec = this.Stats.AsFieldSpec(conf.Child("stats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "stats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<IrisdbSnapshotVolumeInfo>? Volumes
        // GraphQL -> volumes: [IrisdbSnapshotVolumeInfo!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IrisdbSnapshotType? SnapshotType
        // GraphQL -> snapshotType: IrisdbSnapshotType (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new IrisdbSnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String (scalar)
        if (ec.Includes("instanceVersion",true))
        {
            if(this.InstanceVersion == null) {

                this.InstanceVersion = "FETCH";

            } else {


            }
        }
        else if (this.InstanceVersion != null && ec.Excludes("instanceVersion",true))
        {
            this.InstanceVersion = null;
        }
        //      C# -> List<System.String>? MountPaths
        // GraphQL -> mountPaths: [String!]! (scalar)
        if (ec.Includes("mountPaths",true))
        {
            if(this.MountPaths == null) {

                this.MountPaths = new List<System.String>();

            } else {


            }
        }
        else if (this.MountPaths != null && ec.Excludes("mountPaths",true))
        {
            this.MountPaths = null;
        }
        //      C# -> KosmosDataSnapshotStats? Stats
        // GraphQL -> stats: KosmosDataSnapshotStats! (type)
        if (ec.Includes("stats",false))
        {
            if(this.Stats == null) {

                this.Stats = new KosmosDataSnapshotStats();
                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            } else {

                this.Stats.ApplyExploratoryFieldSpec(ec.NewChild("stats"));

            }
        }
        else if (this.Stats != null && ec.Excludes("stats",false))
        {
            this.Stats = null;
        }
        //      C# -> List<IrisdbSnapshotVolumeInfo>? Volumes
        // GraphQL -> volumes: [IrisdbSnapshotVolumeInfo!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<IrisdbSnapshotVolumeInfo>();
                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            } else {

                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            }
        }
        else if (this.Volumes != null && ec.Excludes("volumes",false))
        {
            this.Volumes = null;
        }
    }


    #endregion

    } // class IrisdbInstanceAppMetadata
    
    #endregion

    public static class ListIrisdbInstanceAppMetadataExtensions
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
            this List<IrisdbInstanceAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IrisdbInstanceAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IrisdbInstanceAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IrisdbInstanceAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IrisdbInstanceAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types