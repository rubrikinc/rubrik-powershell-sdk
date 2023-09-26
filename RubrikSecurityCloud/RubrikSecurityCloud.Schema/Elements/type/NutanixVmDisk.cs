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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<NutanixVmDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmDisk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types