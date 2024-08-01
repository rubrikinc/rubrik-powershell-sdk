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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "VmDiskMapEntry";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? SourceVmDiskId
        // GraphQL -> sourceVmDiskId: String! (scalar)
        if (this.SourceVmDiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmDiskId\n" ;
            } else {
                s += ind + "sourceVmDiskId\n" ;
            }
        }
        //      C# -> System.String? TargetDiskId
        // GraphQL -> targetDiskId: String! (scalar)
        if (this.TargetDiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetDiskId\n" ;
            } else {
                s += ind + "targetDiskId\n" ;
            }
        }
        //      C# -> System.String? TargetDiskNativeId
        // GraphQL -> targetDiskNativeId: String! (scalar)
        if (this.TargetDiskNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetDiskNativeId\n" ;
            } else {
                s += ind + "targetDiskNativeId\n" ;
            }
        }
        //      C# -> System.Boolean? TargetIsOsDisk
        // GraphQL -> targetIsOsDisk: Boolean! (scalar)
        if (this.TargetIsOsDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIsOsDisk\n" ;
            } else {
                s += ind + "targetIsOsDisk\n" ;
            }
        }
        //      C# -> System.Int64? TargetLogicalSize
        // GraphQL -> targetLogicalSize: Long! (scalar)
        if (this.TargetLogicalSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLogicalSize\n" ;
            } else {
                s += ind + "targetLogicalSize\n" ;
            }
        }
        //      C# -> System.String? TargetSnapshotId
        // GraphQL -> targetSnapshotId: String! (scalar)
        if (this.TargetSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetSnapshotId\n" ;
            } else {
                s += ind + "targetSnapshotId\n" ;
            }
        }
        //      C# -> VmDatastore? SourceDatastore
        // GraphQL -> sourceDatastore: VmDatastore (type)
        if (this.SourceDatastore != null) {
            var fspec = this.SourceDatastore.AsFieldSpec(conf.Child("sourceDatastore"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceDatastore" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SourceVmDiskId
        // GraphQL -> sourceVmDiskId: String! (scalar)
        if (ec.Includes("sourceVmDiskId",true))
        {
            if(this.SourceVmDiskId == null) {

                this.SourceVmDiskId = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmDiskId != null && ec.Excludes("sourceVmDiskId",true))
        {
            this.SourceVmDiskId = null;
        }
        //      C# -> System.String? TargetDiskId
        // GraphQL -> targetDiskId: String! (scalar)
        if (ec.Includes("targetDiskId",true))
        {
            if(this.TargetDiskId == null) {

                this.TargetDiskId = "FETCH";

            } else {


            }
        }
        else if (this.TargetDiskId != null && ec.Excludes("targetDiskId",true))
        {
            this.TargetDiskId = null;
        }
        //      C# -> System.String? TargetDiskNativeId
        // GraphQL -> targetDiskNativeId: String! (scalar)
        if (ec.Includes("targetDiskNativeId",true))
        {
            if(this.TargetDiskNativeId == null) {

                this.TargetDiskNativeId = "FETCH";

            } else {


            }
        }
        else if (this.TargetDiskNativeId != null && ec.Excludes("targetDiskNativeId",true))
        {
            this.TargetDiskNativeId = null;
        }
        //      C# -> System.Boolean? TargetIsOsDisk
        // GraphQL -> targetIsOsDisk: Boolean! (scalar)
        if (ec.Includes("targetIsOsDisk",true))
        {
            if(this.TargetIsOsDisk == null) {

                this.TargetIsOsDisk = true;

            } else {


            }
        }
        else if (this.TargetIsOsDisk != null && ec.Excludes("targetIsOsDisk",true))
        {
            this.TargetIsOsDisk = null;
        }
        //      C# -> System.Int64? TargetLogicalSize
        // GraphQL -> targetLogicalSize: Long! (scalar)
        if (ec.Includes("targetLogicalSize",true))
        {
            if(this.TargetLogicalSize == null) {

                this.TargetLogicalSize = new System.Int64();

            } else {


            }
        }
        else if (this.TargetLogicalSize != null && ec.Excludes("targetLogicalSize",true))
        {
            this.TargetLogicalSize = null;
        }
        //      C# -> System.String? TargetSnapshotId
        // GraphQL -> targetSnapshotId: String! (scalar)
        if (ec.Includes("targetSnapshotId",true))
        {
            if(this.TargetSnapshotId == null) {

                this.TargetSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.TargetSnapshotId != null && ec.Excludes("targetSnapshotId",true))
        {
            this.TargetSnapshotId = null;
        }
        //      C# -> VmDatastore? SourceDatastore
        // GraphQL -> sourceDatastore: VmDatastore (type)
        if (ec.Includes("sourceDatastore",false))
        {
            if(this.SourceDatastore == null) {

                this.SourceDatastore = new VmDatastore();
                this.SourceDatastore.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatastore"));

            } else {

                this.SourceDatastore.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatastore"));

            }
        }
        else if (this.SourceDatastore != null && ec.Excludes("sourceDatastore",false))
        {
            this.SourceDatastore = null;
        }
    }


    #endregion

    } // class VmDiskMapEntry
    
    #endregion

    public static class ListVmDiskMapEntryExtensions
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
            this List<VmDiskMapEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmDiskMapEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmDiskMapEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmDiskMapEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmDiskMapEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types