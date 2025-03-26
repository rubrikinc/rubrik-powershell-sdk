// VmwareVmSubObject.cs
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
    #region VmwareVmSubObject
    public class VmwareVmSubObject: BaseType
    {
        #region members

        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        [JsonProperty("currentDatastoreId")]
        public System.String? CurrentDatastoreId { get; set; }

        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        [JsonProperty("deviceKey")]
        public System.Int32? DeviceKey { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        [JsonProperty("virtualDiskId")]
        public System.String? VirtualDiskId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmSubObject";
    }

    public VmwareVmSubObject Set(
        System.String? CurrentDatastoreId = null,
        System.Int32? DeviceKey = null,
        System.Int64? FileSizeInBytes = null,
        System.String? Filename = null,
        System.String? VirtualDiskId = null
    ) 
    {
        if ( CurrentDatastoreId != null ) {
            this.CurrentDatastoreId = CurrentDatastoreId;
        }
        if ( DeviceKey != null ) {
            this.DeviceKey = DeviceKey;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( VirtualDiskId != null ) {
            this.VirtualDiskId = VirtualDiskId;
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
        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        if (this.CurrentDatastoreId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentDatastoreId\n" ;
            } else {
                s += ind + "currentDatastoreId\n" ;
            }
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        if (this.DeviceKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceKey\n" ;
            } else {
                s += ind + "deviceKey\n" ;
            }
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (this.FileSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSizeInBytes\n" ;
            } else {
                s += ind + "fileSizeInBytes\n" ;
            }
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
            }
        }
        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        if (this.VirtualDiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualDiskId\n" ;
            } else {
                s += ind + "virtualDiskId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CurrentDatastoreId
        // GraphQL -> currentDatastoreId: UUID (scalar)
        if (ec.Includes("currentDatastoreId",true))
        {
            if(this.CurrentDatastoreId == null) {

                this.CurrentDatastoreId = "FETCH";

            } else {


            }
        }
        else if (this.CurrentDatastoreId != null && ec.Excludes("currentDatastoreId",true))
        {
            this.CurrentDatastoreId = null;
        }
        //      C# -> System.Int32? DeviceKey
        // GraphQL -> deviceKey: Int! (scalar)
        if (ec.Includes("deviceKey",true))
        {
            if(this.DeviceKey == null) {

                this.DeviceKey = Int32.MinValue;

            } else {


            }
        }
        else if (this.DeviceKey != null && ec.Excludes("deviceKey",true))
        {
            this.DeviceKey = null;
        }
        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        if (ec.Includes("fileSizeInBytes",true))
        {
            if(this.FileSizeInBytes == null) {

                this.FileSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FileSizeInBytes != null && ec.Excludes("fileSizeInBytes",true))
        {
            this.FileSizeInBytes = null;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
        }
        //      C# -> System.String? VirtualDiskId
        // GraphQL -> virtualDiskId: UUID (scalar)
        if (ec.Includes("virtualDiskId",true))
        {
            if(this.VirtualDiskId == null) {

                this.VirtualDiskId = "FETCH";

            } else {


            }
        }
        else if (this.VirtualDiskId != null && ec.Excludes("virtualDiskId",true))
        {
            this.VirtualDiskId = null;
        }
    }


    #endregion

    } // class VmwareVmSubObject
    
    #endregion

    public static class ListVmwareVmSubObjectExtensions
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
            this List<VmwareVmSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareVmSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types