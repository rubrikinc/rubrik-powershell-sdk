// NutanixVmSubObject.cs
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
    #region NutanixVmSubObject
    public class NutanixVmSubObject: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.Int64? DiskUsedBytesOpt
        // GraphQL -> diskUsedBytesOpt: Long! (scalar)
        [JsonProperty("diskUsedBytesOpt")]
        public System.Int64? DiskUsedBytesOpt { get; set; }

        //      C# -> System.Int64? LogicalSnapshotFileSizeInBytes
        // GraphQL -> logicalSnapshotFileSizeInBytes: Long! (scalar)
        [JsonProperty("logicalSnapshotFileSizeInBytes")]
        public System.Int64? LogicalSnapshotFileSizeInBytes { get; set; }

        //      C# -> System.String? RelSnapshotDiskFilePath
        // GraphQL -> relSnapshotDiskFilePath: String! (scalar)
        [JsonProperty("relSnapshotDiskFilePath")]
        public System.String? RelSnapshotDiskFilePath { get; set; }

        //      C# -> System.String? SnapshotContainer
        // GraphQL -> snapshotContainer: String! (scalar)
        [JsonProperty("snapshotContainer")]
        public System.String? SnapshotContainer { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmSubObject";
    }

    public NutanixVmSubObject Set(
        System.String? ClusterUuid = null,
        System.String? DiskId = null,
        System.Int64? DiskUsedBytesOpt = null,
        System.Int64? LogicalSnapshotFileSizeInBytes = null,
        System.String? RelSnapshotDiskFilePath = null,
        System.String? SnapshotContainer = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskUsedBytesOpt != null ) {
            this.DiskUsedBytesOpt = DiskUsedBytesOpt;
        }
        if ( LogicalSnapshotFileSizeInBytes != null ) {
            this.LogicalSnapshotFileSizeInBytes = LogicalSnapshotFileSizeInBytes;
        }
        if ( RelSnapshotDiskFilePath != null ) {
            this.RelSnapshotDiskFilePath = RelSnapshotDiskFilePath;
        }
        if ( SnapshotContainer != null ) {
            this.SnapshotContainer = SnapshotContainer;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskId\n" ;
            } else {
                s += ind + "diskId\n" ;
            }
        }
        //      C# -> System.Int64? DiskUsedBytesOpt
        // GraphQL -> diskUsedBytesOpt: Long! (scalar)
        if (this.DiskUsedBytesOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskUsedBytesOpt\n" ;
            } else {
                s += ind + "diskUsedBytesOpt\n" ;
            }
        }
        //      C# -> System.Int64? LogicalSnapshotFileSizeInBytes
        // GraphQL -> logicalSnapshotFileSizeInBytes: Long! (scalar)
        if (this.LogicalSnapshotFileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalSnapshotFileSizeInBytes\n" ;
            } else {
                s += ind + "logicalSnapshotFileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? RelSnapshotDiskFilePath
        // GraphQL -> relSnapshotDiskFilePath: String! (scalar)
        if (this.RelSnapshotDiskFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relSnapshotDiskFilePath\n" ;
            } else {
                s += ind + "relSnapshotDiskFilePath\n" ;
            }
        }
        //      C# -> System.String? SnapshotContainer
        // GraphQL -> snapshotContainer: String! (scalar)
        if (this.SnapshotContainer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotContainer\n" ;
            } else {
                s += ind + "snapshotContainer\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (ec.Includes("diskId",true))
        {
            if(this.DiskId == null) {

                this.DiskId = "FETCH";

            } else {


            }
        }
        else if (this.DiskId != null && ec.Excludes("diskId",true))
        {
            this.DiskId = null;
        }
        //      C# -> System.Int64? DiskUsedBytesOpt
        // GraphQL -> diskUsedBytesOpt: Long! (scalar)
        if (ec.Includes("diskUsedBytesOpt",true))
        {
            if(this.DiskUsedBytesOpt == null) {

                this.DiskUsedBytesOpt = new System.Int64();

            } else {


            }
        }
        else if (this.DiskUsedBytesOpt != null && ec.Excludes("diskUsedBytesOpt",true))
        {
            this.DiskUsedBytesOpt = null;
        }
        //      C# -> System.Int64? LogicalSnapshotFileSizeInBytes
        // GraphQL -> logicalSnapshotFileSizeInBytes: Long! (scalar)
        if (ec.Includes("logicalSnapshotFileSizeInBytes",true))
        {
            if(this.LogicalSnapshotFileSizeInBytes == null) {

                this.LogicalSnapshotFileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalSnapshotFileSizeInBytes != null && ec.Excludes("logicalSnapshotFileSizeInBytes",true))
        {
            this.LogicalSnapshotFileSizeInBytes = null;
        }
        //      C# -> System.String? RelSnapshotDiskFilePath
        // GraphQL -> relSnapshotDiskFilePath: String! (scalar)
        if (ec.Includes("relSnapshotDiskFilePath",true))
        {
            if(this.RelSnapshotDiskFilePath == null) {

                this.RelSnapshotDiskFilePath = "FETCH";

            } else {


            }
        }
        else if (this.RelSnapshotDiskFilePath != null && ec.Excludes("relSnapshotDiskFilePath",true))
        {
            this.RelSnapshotDiskFilePath = null;
        }
        //      C# -> System.String? SnapshotContainer
        // GraphQL -> snapshotContainer: String! (scalar)
        if (ec.Includes("snapshotContainer",true))
        {
            if(this.SnapshotContainer == null) {

                this.SnapshotContainer = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotContainer != null && ec.Excludes("snapshotContainer",true))
        {
            this.SnapshotContainer = null;
        }
    }


    #endregion

    } // class NutanixVmSubObject
    
    #endregion

    public static class ListNutanixVmSubObjectExtensions
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
            this List<NutanixVmSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types