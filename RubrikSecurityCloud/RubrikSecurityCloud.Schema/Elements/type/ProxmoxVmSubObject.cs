// ProxmoxVmSubObject.cs
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
    #region ProxmoxVmSubObject
    public class ProxmoxVmSubObject: BaseType
    {
        #region members

        //      C# -> System.Int64? ActualSize
        // GraphQL -> actualSize: Long! (scalar)
        [JsonProperty("actualSize")]
        public System.Int64? ActualSize { get; set; }

        //      C# -> System.String? DiskAlias
        // GraphQL -> diskAlias: String! (scalar)
        [JsonProperty("diskAlias")]
        public System.String? DiskAlias { get; set; }

        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        [JsonProperty("diskFormat")]
        public System.String? DiskFormat { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskInterface
        // GraphQL -> diskInterface: String! (scalar)
        [JsonProperty("diskInterface")]
        public System.String? DiskInterface { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.Boolean? IsBootable
        // GraphQL -> isBootable: Boolean! (scalar)
        [JsonProperty("isBootable")]
        public System.Boolean? IsBootable { get; set; }

        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        [JsonProperty("provisionedSize")]
        public System.Int64? ProvisionedSize { get; set; }

        //      C# -> System.String? StorageDomainId
        // GraphQL -> storageDomainId: String! (scalar)
        [JsonProperty("storageDomainId")]
        public System.String? StorageDomainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProxmoxVmSubObject";
    }

    public ProxmoxVmSubObject Set(
        System.Int64? ActualSize = null,
        System.String? DiskAlias = null,
        System.String? DiskFormat = null,
        System.String? DiskId = null,
        System.String? DiskInterface = null,
        System.Int64? FileSizeInBytes = null,
        System.Boolean? IsBootable = null,
        System.Int64? ProvisionedSize = null,
        System.String? StorageDomainId = null
    ) 
    {
        if ( ActualSize != null ) {
            this.ActualSize = ActualSize;
        }
        if ( DiskAlias != null ) {
            this.DiskAlias = DiskAlias;
        }
        if ( DiskFormat != null ) {
            this.DiskFormat = DiskFormat;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskInterface != null ) {
            this.DiskInterface = DiskInterface;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( IsBootable != null ) {
            this.IsBootable = IsBootable;
        }
        if ( ProvisionedSize != null ) {
            this.ProvisionedSize = ProvisionedSize;
        }
        if ( StorageDomainId != null ) {
            this.StorageDomainId = StorageDomainId;
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
        //      C# -> System.Int64? ActualSize
        // GraphQL -> actualSize: Long! (scalar)
        if (this.ActualSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actualSize\n" ;
            } else {
                s += ind + "actualSize\n" ;
            }
        }
        //      C# -> System.String? DiskAlias
        // GraphQL -> diskAlias: String! (scalar)
        if (this.DiskAlias != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskAlias\n" ;
            } else {
                s += ind + "diskAlias\n" ;
            }
        }
        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        if (this.DiskFormat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskFormat\n" ;
            } else {
                s += ind + "diskFormat\n" ;
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
        //      C# -> System.String? DiskInterface
        // GraphQL -> diskInterface: String! (scalar)
        if (this.DiskInterface != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskInterface\n" ;
            } else {
                s += ind + "diskInterface\n" ;
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
        //      C# -> System.Boolean? IsBootable
        // GraphQL -> isBootable: Boolean! (scalar)
        if (this.IsBootable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBootable\n" ;
            } else {
                s += ind + "isBootable\n" ;
            }
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (this.ProvisionedSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisionedSize\n" ;
            } else {
                s += ind + "provisionedSize\n" ;
            }
        }
        //      C# -> System.String? StorageDomainId
        // GraphQL -> storageDomainId: String! (scalar)
        if (this.StorageDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageDomainId\n" ;
            } else {
                s += ind + "storageDomainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ActualSize
        // GraphQL -> actualSize: Long! (scalar)
        if (ec.Includes("actualSize",true))
        {
            if(this.ActualSize == null) {

                this.ActualSize = new System.Int64();

            } else {


            }
        }
        else if (this.ActualSize != null && ec.Excludes("actualSize",true))
        {
            this.ActualSize = null;
        }
        //      C# -> System.String? DiskAlias
        // GraphQL -> diskAlias: String! (scalar)
        if (ec.Includes("diskAlias",true))
        {
            if(this.DiskAlias == null) {

                this.DiskAlias = "FETCH";

            } else {


            }
        }
        else if (this.DiskAlias != null && ec.Excludes("diskAlias",true))
        {
            this.DiskAlias = null;
        }
        //      C# -> System.String? DiskFormat
        // GraphQL -> diskFormat: String! (scalar)
        if (ec.Includes("diskFormat",true))
        {
            if(this.DiskFormat == null) {

                this.DiskFormat = "FETCH";

            } else {


            }
        }
        else if (this.DiskFormat != null && ec.Excludes("diskFormat",true))
        {
            this.DiskFormat = null;
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
        //      C# -> System.String? DiskInterface
        // GraphQL -> diskInterface: String! (scalar)
        if (ec.Includes("diskInterface",true))
        {
            if(this.DiskInterface == null) {

                this.DiskInterface = "FETCH";

            } else {


            }
        }
        else if (this.DiskInterface != null && ec.Excludes("diskInterface",true))
        {
            this.DiskInterface = null;
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
        //      C# -> System.Boolean? IsBootable
        // GraphQL -> isBootable: Boolean! (scalar)
        if (ec.Includes("isBootable",true))
        {
            if(this.IsBootable == null) {

                this.IsBootable = true;

            } else {


            }
        }
        else if (this.IsBootable != null && ec.Excludes("isBootable",true))
        {
            this.IsBootable = null;
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (ec.Includes("provisionedSize",true))
        {
            if(this.ProvisionedSize == null) {

                this.ProvisionedSize = new System.Int64();

            } else {


            }
        }
        else if (this.ProvisionedSize != null && ec.Excludes("provisionedSize",true))
        {
            this.ProvisionedSize = null;
        }
        //      C# -> System.String? StorageDomainId
        // GraphQL -> storageDomainId: String! (scalar)
        if (ec.Includes("storageDomainId",true))
        {
            if(this.StorageDomainId == null) {

                this.StorageDomainId = "FETCH";

            } else {


            }
        }
        else if (this.StorageDomainId != null && ec.Excludes("storageDomainId",true))
        {
            this.StorageDomainId = null;
        }
    }


    #endregion

    } // class ProxmoxVmSubObject
    
    #endregion

    public static class ListProxmoxVmSubObjectExtensions
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
            this List<ProxmoxVmSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProxmoxVmSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProxmoxVmSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxmoxVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProxmoxVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types