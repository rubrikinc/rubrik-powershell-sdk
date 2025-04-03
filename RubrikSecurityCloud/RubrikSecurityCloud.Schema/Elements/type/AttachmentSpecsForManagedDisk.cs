// AttachmentSpecsForManagedDisk.cs
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
    #region AttachmentSpecsForManagedDisk
    public class AttachmentSpecsForManagedDisk: BaseType
    {
        #region members

        //      C# -> System.String? AttachedToVmId
        // GraphQL -> attachedToVmId: String! (scalar)
        [JsonProperty("attachedToVmId")]
        public System.String? AttachedToVmId { get; set; }

        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }

        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        [JsonProperty("isOsDisk")]
        public System.Boolean? IsOsDisk { get; set; }

        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        [JsonProperty("lun")]
        public System.Int32? Lun { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AttachmentSpecsForManagedDisk";
    }

    public AttachmentSpecsForManagedDisk Set(
        System.String? AttachedToVmId = null,
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsOsDisk = null,
        System.Int32? Lun = null
    ) 
    {
        if ( AttachedToVmId != null ) {
            this.AttachedToVmId = AttachedToVmId;
        }
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( IsOsDisk != null ) {
            this.IsOsDisk = IsOsDisk;
        }
        if ( Lun != null ) {
            this.Lun = Lun;
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
        //      C# -> System.String? AttachedToVmId
        // GraphQL -> attachedToVmId: String! (scalar)
        if (this.AttachedToVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedToVmId\n" ;
            } else {
                s += ind + "attachedToVmId\n" ;
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
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOsDisk\n" ;
            } else {
                s += ind + "isOsDisk\n" ;
            }
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lun\n" ;
            } else {
                s += ind + "lun\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AttachedToVmId
        // GraphQL -> attachedToVmId: String! (scalar)
        if (ec.Includes("attachedToVmId",true))
        {
            if(this.AttachedToVmId == null) {

                this.AttachedToVmId = "FETCH";

            } else {


            }
        }
        else if (this.AttachedToVmId != null && ec.Excludes("attachedToVmId",true))
        {
            this.AttachedToVmId = null;
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
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (ec.Includes("isOsDisk",true))
        {
            if(this.IsOsDisk == null) {

                this.IsOsDisk = true;

            } else {


            }
        }
        else if (this.IsOsDisk != null && ec.Excludes("isOsDisk",true))
        {
            this.IsOsDisk = null;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (ec.Includes("lun",true))
        {
            if(this.Lun == null) {

                this.Lun = Int32.MinValue;

            } else {


            }
        }
        else if (this.Lun != null && ec.Excludes("lun",true))
        {
            this.Lun = null;
        }
    }


    #endregion

    } // class AttachmentSpecsForManagedDisk
    
    #endregion

    public static class ListAttachmentSpecsForManagedDiskExtensions
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
            this List<AttachmentSpecsForManagedDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AttachmentSpecsForManagedDisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecsForManagedDisk> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecsForManagedDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AttachmentSpecsForManagedDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types