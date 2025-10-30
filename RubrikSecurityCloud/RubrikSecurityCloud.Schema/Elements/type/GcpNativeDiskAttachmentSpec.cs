// GcpNativeDiskAttachmentSpec.cs
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
    #region GcpNativeDiskAttachmentSpec
    public class GcpNativeDiskAttachmentSpec: BaseType
    {
        #region members

        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        [JsonProperty("devicePath")]
        public System.String? DevicePath { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.Int32? DiskIndex
        // GraphQL -> diskIndex: Int! (scalar)
        [JsonProperty("diskIndex")]
        public System.Int32? DiskIndex { get; set; }

        //      C# -> System.String? GceInstanceId
        // GraphQL -> gceInstanceId: String! (scalar)
        [JsonProperty("gceInstanceId")]
        public System.String? GceInstanceId { get; set; }

        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        [JsonProperty("isBootDisk")]
        public System.Boolean? IsBootDisk { get; set; }

        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeDiskAttachmentSpec";
    }

    public GcpNativeDiskAttachmentSpec Set(
        System.String? DevicePath = null,
        System.String? DiskId = null,
        System.Int32? DiskIndex = null,
        System.String? GceInstanceId = null,
        System.Boolean? IsBootDisk = null,
        System.Boolean? IsExcludedFromSnapshot = null
    ) 
    {
        if ( DevicePath != null ) {
            this.DevicePath = DevicePath;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskIndex != null ) {
            this.DiskIndex = DiskIndex;
        }
        if ( GceInstanceId != null ) {
            this.GceInstanceId = GceInstanceId;
        }
        if ( IsBootDisk != null ) {
            this.IsBootDisk = IsBootDisk;
        }
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
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
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (this.DevicePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "devicePath\n" ;
            } else {
                s += ind + "devicePath\n" ;
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
        //      C# -> System.Int32? DiskIndex
        // GraphQL -> diskIndex: Int! (scalar)
        if (this.DiskIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskIndex\n" ;
            } else {
                s += ind + "diskIndex\n" ;
            }
        }
        //      C# -> System.String? GceInstanceId
        // GraphQL -> gceInstanceId: String! (scalar)
        if (this.GceInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gceInstanceId\n" ;
            } else {
                s += ind + "gceInstanceId\n" ;
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
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcludedFromSnapshot\n" ;
            } else {
                s += ind + "isExcludedFromSnapshot\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        if (ec.Includes("devicePath",true))
        {
            if(this.DevicePath == null) {

                this.DevicePath = "FETCH";

            } else {


            }
        }
        else if (this.DevicePath != null && ec.Excludes("devicePath",true))
        {
            this.DevicePath = null;
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
        //      C# -> System.Int32? DiskIndex
        // GraphQL -> diskIndex: Int! (scalar)
        if (ec.Includes("diskIndex",true))
        {
            if(this.DiskIndex == null) {

                this.DiskIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.DiskIndex != null && ec.Excludes("diskIndex",true))
        {
            this.DiskIndex = null;
        }
        //      C# -> System.String? GceInstanceId
        // GraphQL -> gceInstanceId: String! (scalar)
        if (ec.Includes("gceInstanceId",true))
        {
            if(this.GceInstanceId == null) {

                this.GceInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.GceInstanceId != null && ec.Excludes("gceInstanceId",true))
        {
            this.GceInstanceId = null;
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
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (ec.Includes("isExcludedFromSnapshot",true))
        {
            if(this.IsExcludedFromSnapshot == null) {

                this.IsExcludedFromSnapshot = true;

            } else {


            }
        }
        else if (this.IsExcludedFromSnapshot != null && ec.Excludes("isExcludedFromSnapshot",true))
        {
            this.IsExcludedFromSnapshot = null;
        }
    }


    #endregion

    } // class GcpNativeDiskAttachmentSpec
    
    #endregion

    public static class ListGcpNativeDiskAttachmentSpecExtensions
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
            this List<GcpNativeDiskAttachmentSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeDiskAttachmentSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeDiskAttachmentSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeDiskAttachmentSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeDiskAttachmentSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types