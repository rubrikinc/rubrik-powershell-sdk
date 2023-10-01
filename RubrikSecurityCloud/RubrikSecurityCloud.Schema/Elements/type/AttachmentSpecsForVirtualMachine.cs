// AttachmentSpecsForVirtualMachine.cs
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
    #region AttachmentSpecsForVirtualMachine
    public class AttachmentSpecsForVirtualMachine: BaseType
    {
        #region members

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

        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        [JsonProperty("managedDiskId")]
        public System.String? ManagedDiskId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AttachmentSpecsForVirtualMachine";
    }

    public AttachmentSpecsForVirtualMachine Set(
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsOsDisk = null,
        System.Int32? Lun = null,
        System.String? ManagedDiskId = null
    ) 
    {
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( IsOsDisk != null ) {
            this.IsOsDisk = IsOsDisk;
        }
        if ( Lun != null ) {
            this.Lun = Lun;
        }
        if ( ManagedDiskId != null ) {
            this.ManagedDiskId = ManagedDiskId;
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
        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        if (this.ManagedDiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedDiskId\n" ;
            } else {
                s += ind + "managedDiskId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        if (ec.Includes("managedDiskId",true))
        {
            if(this.ManagedDiskId == null) {

                this.ManagedDiskId = "FETCH";

            } else {


            }
        }
        else if (this.ManagedDiskId != null && ec.Excludes("managedDiskId",true))
        {
            this.ManagedDiskId = null;
        }
    }


    #endregion

    } // class AttachmentSpecsForVirtualMachine
    
    #endregion

    public static class ListAttachmentSpecsForVirtualMachineExtensions
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
            this List<AttachmentSpecsForVirtualMachine> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AttachmentSpecsForVirtualMachine> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecsForVirtualMachine> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecsForVirtualMachine());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AttachmentSpecsForVirtualMachine> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types