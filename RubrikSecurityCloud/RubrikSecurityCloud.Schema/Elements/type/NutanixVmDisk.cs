// NutanixVmDisk.cs
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
    #region NutanixVmDisk
    public class NutanixVmDisk: BaseType
    {
        #region members

        //      C# -> System.String? DeviceType
        // GraphQL -> deviceType: String! (scalar)
        [JsonProperty("deviceType")]
        public System.String? DeviceType { get; set; }

        //      C# -> System.Boolean? IsSnapshottable
        // GraphQL -> isSnapshottable: Boolean! (scalar)
        [JsonProperty("isSnapshottable")]
        public System.Boolean? IsSnapshottable { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? StorageContainerId
        // GraphQL -> storageContainerId: String! (scalar)
        [JsonProperty("storageContainerId")]
        public System.String? StorageContainerId { get; set; }

        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String! (scalar)
        [JsonProperty("storageContainerName")]
        public System.String? StorageContainerName { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> System.String? VmDiskUuid
        // GraphQL -> vmDiskUuid: String! (scalar)
        [JsonProperty("vmDiskUuid")]
        public System.String? VmDiskUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmDisk";
    }

    public NutanixVmDisk Set(
        System.String? DeviceType = null,
        System.Boolean? IsSnapshottable = null,
        System.String? Label = null,
        System.Int64? SizeInBytes = null,
        System.String? StorageContainerId = null,
        System.String? StorageContainerName = null,
        System.String? Uuid = null,
        System.String? VmDiskUuid = null
    ) 
    {
        if ( DeviceType != null ) {
            this.DeviceType = DeviceType;
        }
        if ( IsSnapshottable != null ) {
            this.IsSnapshottable = IsSnapshottable;
        }
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( StorageContainerId != null ) {
            this.StorageContainerId = StorageContainerId;
        }
        if ( StorageContainerName != null ) {
            this.StorageContainerName = StorageContainerName;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( VmDiskUuid != null ) {
            this.VmDiskUuid = VmDiskUuid;
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
        //      C# -> System.String? DeviceType
        // GraphQL -> deviceType: String! (scalar)
        if (this.DeviceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceType\n" ;
            } else {
                s += ind + "deviceType\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshottable
        // GraphQL -> isSnapshottable: Boolean! (scalar)
        if (this.IsSnapshottable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshottable\n" ;
            } else {
                s += ind + "isSnapshottable\n" ;
            }
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInBytes\n" ;
            } else {
                s += ind + "sizeInBytes\n" ;
            }
        }
        //      C# -> System.String? StorageContainerId
        // GraphQL -> storageContainerId: String! (scalar)
        if (this.StorageContainerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageContainerId\n" ;
            } else {
                s += ind + "storageContainerId\n" ;
            }
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String! (scalar)
        if (this.StorageContainerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageContainerName\n" ;
            } else {
                s += ind + "storageContainerName\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> System.String? VmDiskUuid
        // GraphQL -> vmDiskUuid: String! (scalar)
        if (this.VmDiskUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmDiskUuid\n" ;
            } else {
                s += ind + "vmDiskUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DeviceType
        // GraphQL -> deviceType: String! (scalar)
        if (ec.Includes("deviceType",true))
        {
            if(this.DeviceType == null) {

                this.DeviceType = "FETCH";

            } else {


            }
        }
        else if (this.DeviceType != null && ec.Excludes("deviceType",true))
        {
            this.DeviceType = null;
        }
        //      C# -> System.Boolean? IsSnapshottable
        // GraphQL -> isSnapshottable: Boolean! (scalar)
        if (ec.Includes("isSnapshottable",true))
        {
            if(this.IsSnapshottable == null) {

                this.IsSnapshottable = true;

            } else {


            }
        }
        else if (this.IsSnapshottable != null && ec.Excludes("isSnapshottable",true))
        {
            this.IsSnapshottable = null;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (ec.Includes("sizeInBytes",true))
        {
            if(this.SizeInBytes == null) {

                this.SizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SizeInBytes != null && ec.Excludes("sizeInBytes",true))
        {
            this.SizeInBytes = null;
        }
        //      C# -> System.String? StorageContainerId
        // GraphQL -> storageContainerId: String! (scalar)
        if (ec.Includes("storageContainerId",true))
        {
            if(this.StorageContainerId == null) {

                this.StorageContainerId = "FETCH";

            } else {


            }
        }
        else if (this.StorageContainerId != null && ec.Excludes("storageContainerId",true))
        {
            this.StorageContainerId = null;
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String! (scalar)
        if (ec.Includes("storageContainerName",true))
        {
            if(this.StorageContainerName == null) {

                this.StorageContainerName = "FETCH";

            } else {


            }
        }
        else if (this.StorageContainerName != null && ec.Excludes("storageContainerName",true))
        {
            this.StorageContainerName = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> System.String? VmDiskUuid
        // GraphQL -> vmDiskUuid: String! (scalar)
        if (ec.Includes("vmDiskUuid",true))
        {
            if(this.VmDiskUuid == null) {

                this.VmDiskUuid = "FETCH";

            } else {


            }
        }
        else if (this.VmDiskUuid != null && ec.Excludes("vmDiskUuid",true))
        {
            this.VmDiskUuid = null;
        }
    }


    #endregion

    } // class NutanixVmDisk
    
    #endregion

    public static class ListNutanixVmDiskExtensions
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
            this List<NutanixVmDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmDisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmDisk> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types