// OlvmVmSubObject.cs
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
    #region OlvmVmSubObject
    public class OlvmVmSubObject: BaseType
    {
        #region members

        //      C# -> System.Int64? ActualSizeInBytes
        // GraphQL -> actualSizeInBytes: Long! (scalar)
        [JsonProperty("actualSizeInBytes")]
        public System.Int64? ActualSizeInBytes { get; set; }

        //      C# -> System.String? DiskAlias
        // GraphQL -> diskAlias: String! (scalar)
        [JsonProperty("diskAlias")]
        public System.String? DiskAlias { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.Int64? FileSizeInBytes
        // GraphQL -> fileSizeInBytes: Long! (scalar)
        [JsonProperty("fileSizeInBytes")]
        public System.Int64? FileSizeInBytes { get; set; }

        //      C# -> System.Int64? ProvisionedSizeInBytes
        // GraphQL -> provisionedSizeInBytes: Long! (scalar)
        [JsonProperty("provisionedSizeInBytes")]
        public System.Int64? ProvisionedSizeInBytes { get; set; }

        //      C# -> System.String? StorageDomainId
        // GraphQL -> storageDomainId: String! (scalar)
        [JsonProperty("storageDomainId")]
        public System.String? StorageDomainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OlvmVmSubObject";
    }

    public OlvmVmSubObject Set(
        System.Int64? ActualSizeInBytes = null,
        System.String? DiskAlias = null,
        System.String? DiskId = null,
        System.Int64? FileSizeInBytes = null,
        System.Int64? ProvisionedSizeInBytes = null,
        System.String? StorageDomainId = null
    ) 
    {
        if ( ActualSizeInBytes != null ) {
            this.ActualSizeInBytes = ActualSizeInBytes;
        }
        if ( DiskAlias != null ) {
            this.DiskAlias = DiskAlias;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( FileSizeInBytes != null ) {
            this.FileSizeInBytes = FileSizeInBytes;
        }
        if ( ProvisionedSizeInBytes != null ) {
            this.ProvisionedSizeInBytes = ProvisionedSizeInBytes;
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
        //      C# -> System.Int64? ActualSizeInBytes
        // GraphQL -> actualSizeInBytes: Long! (scalar)
        if (this.ActualSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actualSizeInBytes\n" ;
            } else {
                s += ind + "actualSizeInBytes\n" ;
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
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskId\n" ;
            } else {
                s += ind + "diskId\n" ;
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
        //      C# -> System.Int64? ProvisionedSizeInBytes
        // GraphQL -> provisionedSizeInBytes: Long! (scalar)
        if (this.ProvisionedSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisionedSizeInBytes\n" ;
            } else {
                s += ind + "provisionedSizeInBytes\n" ;
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
        //      C# -> System.Int64? ActualSizeInBytes
        // GraphQL -> actualSizeInBytes: Long! (scalar)
        if (ec.Includes("actualSizeInBytes",true))
        {
            if(this.ActualSizeInBytes == null) {

                this.ActualSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ActualSizeInBytes != null && ec.Excludes("actualSizeInBytes",true))
        {
            this.ActualSizeInBytes = null;
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
        //      C# -> System.Int64? ProvisionedSizeInBytes
        // GraphQL -> provisionedSizeInBytes: Long! (scalar)
        if (ec.Includes("provisionedSizeInBytes",true))
        {
            if(this.ProvisionedSizeInBytes == null) {

                this.ProvisionedSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ProvisionedSizeInBytes != null && ec.Excludes("provisionedSizeInBytes",true))
        {
            this.ProvisionedSizeInBytes = null;
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

    } // class OlvmVmSubObject
    
    #endregion

    public static class ListOlvmVmSubObjectExtensions
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
            this List<OlvmVmSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OlvmVmSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OlvmVmSubObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OlvmVmSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OlvmVmSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types