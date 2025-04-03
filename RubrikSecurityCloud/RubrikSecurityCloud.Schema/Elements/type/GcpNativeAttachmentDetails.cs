// GcpNativeAttachmentDetails.cs
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
    #region GcpNativeAttachmentDetails
    public class GcpNativeAttachmentDetails: BaseType
    {
        #region members

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        [JsonProperty("instanceZone")]
        public System.String? InstanceZone { get; set; }

        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        [JsonProperty("isBootDisk")]
        public System.Boolean? IsBootDisk { get; set; }

        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        [JsonProperty("isExcluded")]
        public System.Boolean? IsExcluded { get; set; }

        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        [JsonProperty("sizeInGiBs")]
        public System.Int32? SizeInGiBs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeAttachmentDetails";
    }

    public GcpNativeAttachmentDetails Set(
        System.String? DeviceName = null,
        System.String? DiskId = null,
        System.String? DiskName = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.String? InstanceZone = null,
        System.Boolean? IsBootDisk = null,
        System.Boolean? IsExcluded = null,
        System.Int32? SizeInGiBs = null
    ) 
    {
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceZone != null ) {
            this.InstanceZone = InstanceZone;
        }
        if ( IsBootDisk != null ) {
            this.IsBootDisk = IsBootDisk;
        }
        if ( IsExcluded != null ) {
            this.IsExcluded = IsExcluded;
        }
        if ( SizeInGiBs != null ) {
            this.SizeInGiBs = SizeInGiBs;
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
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceName\n" ;
            } else {
                s += ind + "deviceName\n" ;
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
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskName\n" ;
            } else {
                s += ind + "diskName\n" ;
            }
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceId\n" ;
            } else {
                s += ind + "instanceId\n" ;
            }
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceName\n" ;
            } else {
                s += ind + "instanceName\n" ;
            }
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (this.InstanceZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceZone\n" ;
            } else {
                s += ind + "instanceZone\n" ;
            }
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (this.IsBootDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBootDisk\n" ;
            } else {
                s += ind + "isBootDisk\n" ;
            }
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (this.IsExcluded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcluded\n" ;
            } else {
                s += ind + "isExcluded\n" ;
            }
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInGiBs\n" ;
            } else {
                s += ind + "sizeInGiBs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (ec.Includes("deviceName",true))
        {
            if(this.DeviceName == null) {

                this.DeviceName = "FETCH";

            } else {


            }
        }
        else if (this.DeviceName != null && ec.Excludes("deviceName",true))
        {
            this.DeviceName = null;
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
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (ec.Includes("diskName",true))
        {
            if(this.DiskName == null) {

                this.DiskName = "FETCH";

            } else {


            }
        }
        else if (this.DiskName != null && ec.Excludes("diskName",true))
        {
            this.DiskName = null;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (ec.Includes("instanceId",true))
        {
            if(this.InstanceId == null) {

                this.InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceId != null && ec.Excludes("instanceId",true))
        {
            this.InstanceId = null;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (ec.Includes("instanceName",true))
        {
            if(this.InstanceName == null) {

                this.InstanceName = "FETCH";

            } else {


            }
        }
        else if (this.InstanceName != null && ec.Excludes("instanceName",true))
        {
            this.InstanceName = null;
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (ec.Includes("instanceZone",true))
        {
            if(this.InstanceZone == null) {

                this.InstanceZone = "FETCH";

            } else {


            }
        }
        else if (this.InstanceZone != null && ec.Excludes("instanceZone",true))
        {
            this.InstanceZone = null;
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (ec.Includes("isBootDisk",true))
        {
            if(this.IsBootDisk == null) {

                this.IsBootDisk = true;

            } else {


            }
        }
        else if (this.IsBootDisk != null && ec.Excludes("isBootDisk",true))
        {
            this.IsBootDisk = null;
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (ec.Includes("isExcluded",true))
        {
            if(this.IsExcluded == null) {

                this.IsExcluded = true;

            } else {


            }
        }
        else if (this.IsExcluded != null && ec.Excludes("isExcluded",true))
        {
            this.IsExcluded = null;
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (ec.Includes("sizeInGiBs",true))
        {
            if(this.SizeInGiBs == null) {

                this.SizeInGiBs = Int32.MinValue;

            } else {


            }
        }
        else if (this.SizeInGiBs != null && ec.Excludes("sizeInGiBs",true))
        {
            this.SizeInGiBs = null;
        }
    }


    #endregion

    } // class GcpNativeAttachmentDetails
    
    #endregion

    public static class ListGcpNativeAttachmentDetailsExtensions
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
            this List<GcpNativeAttachmentDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeAttachmentDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeAttachmentDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeAttachmentDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeAttachmentDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types