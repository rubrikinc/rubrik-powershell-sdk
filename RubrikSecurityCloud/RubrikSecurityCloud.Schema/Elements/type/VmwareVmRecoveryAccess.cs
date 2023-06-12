// VmwareVmRecoveryAccess.cs
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
    #region VmwareVmRecoveryAccess
    public class VmwareVmRecoveryAccess: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        [JsonProperty("isRecoverable")]
        public System.Boolean? IsRecoverable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        [JsonProperty("vmwareVmId")]
        public System.String? VmwareVmId { get; set; }

        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        [JsonProperty("vmwareVmName")]
        public System.String? VmwareVmName { get; set; }


        #endregion

    #region methods

    public VmwareVmRecoveryAccess Set(
        System.Boolean? IsRecoverable = null,
        System.Boolean? IsViewable = null,
        System.String? VmwareVmId = null,
        System.String? VmwareVmName = null
    ) 
    {
        if ( IsRecoverable != null ) {
            this.IsRecoverable = IsRecoverable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( VmwareVmId != null ) {
            this.VmwareVmId = VmwareVmId;
        }
        if ( VmwareVmName != null ) {
            this.VmwareVmName = VmwareVmName;
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
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (this.IsRecoverable != null) {
            s += ind + "isRecoverable\n" ;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable != null) {
            s += ind + "isViewable\n" ;
        }
        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        if (this.VmwareVmId != null) {
            s += ind + "vmwareVmId\n" ;
        }
        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        if (this.VmwareVmName != null) {
            s += ind + "vmwareVmName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (this.IsRecoverable == null && Exploration.Includes(parent + ".isRecoverable", true))
        {
            this.IsRecoverable = true;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable == null && Exploration.Includes(parent + ".isViewable", true))
        {
            this.IsViewable = true;
        }
        //      C# -> System.String? VmwareVmId
        // GraphQL -> vmwareVmId: UUID! (scalar)
        if (this.VmwareVmId == null && Exploration.Includes(parent + ".vmwareVmId", true))
        {
            this.VmwareVmId = "FETCH";
        }
        //      C# -> System.String? VmwareVmName
        // GraphQL -> vmwareVmName: String! (scalar)
        if (this.VmwareVmName == null && Exploration.Includes(parent + ".vmwareVmName", true))
        {
            this.VmwareVmName = "FETCH";
        }
    }


    #endregion

    } // class VmwareVmRecoveryAccess
    
    #endregion

    public static class ListVmwareVmRecoveryAccessExtensions
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
            this List<VmwareVmRecoveryAccess> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmRecoveryAccess> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmRecoveryAccess());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types