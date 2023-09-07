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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AttachedToVmId
        // GraphQL -> attachedToVmId: String! (scalar)
        if (this.AttachedToVmId != null) {
            s += ind + "attachedToVmId\n" ;
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            s += ind + "isExcludedFromSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk != null) {
            s += ind + "isOsDisk\n" ;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun != null) {
            s += ind + "lun\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AttachedToVmId
        // GraphQL -> attachedToVmId: String! (scalar)
        if (this.AttachedToVmId == null && ec.Includes("attachedToVmId",true))
        {
            this.AttachedToVmId = "FETCH";
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot == null && ec.Includes("isExcludedFromSnapshot",true))
        {
            this.IsExcludedFromSnapshot = true;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk == null && ec.Includes("isOsDisk",true))
        {
            this.IsOsDisk = true;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun == null && ec.Includes("lun",true))
        {
            this.Lun = Int32.MinValue;
        }
    }


    #endregion

    } // class AttachmentSpecsForManagedDisk
    
    #endregion

    public static class ListAttachmentSpecsForManagedDiskExtensions
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
            this List<AttachmentSpecsForManagedDisk> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecsForManagedDisk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecsForManagedDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AttachmentSpecsForManagedDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types