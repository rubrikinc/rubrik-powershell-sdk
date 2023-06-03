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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
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
        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        if (this.ManagedDiskId != null) {
            s += ind + "managedDiskId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot == null && Exploration.Includes(parent + ".isExcludedFromSnapshot", true))
        {
            this.IsExcludedFromSnapshot = true;
        }
        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        if (this.IsOsDisk == null && Exploration.Includes(parent + ".isOsDisk", true))
        {
            this.IsOsDisk = true;
        }
        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        if (this.Lun == null && Exploration.Includes(parent + ".lun", true))
        {
            this.Lun = new System.Int32();
        }
        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        if (this.ManagedDiskId == null && Exploration.Includes(parent + ".managedDiskId", true))
        {
            this.ManagedDiskId = new System.String("FETCH");
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AttachmentSpecsForVirtualMachine> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AttachmentSpecsForVirtualMachine());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types