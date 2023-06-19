// RecoveryPermission.cs
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
    #region RecoveryPermission
    public class RecoveryPermission: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        [JsonProperty("isCleanable")]
        public System.Boolean? IsCleanable { get; set; }

        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        [JsonProperty("isResumable")]
        public System.Boolean? IsResumable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        [JsonProperty("recoveryFid")]
        public System.String? RecoveryFid { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }


        #endregion

    #region methods

    public RecoveryPermission Set(
        System.Boolean? IsCleanable = null,
        System.Boolean? IsResumable = null,
        System.Boolean? IsViewable = null,
        System.String? RecoveryFid = null,
        System.String? RecoveryName = null
    ) 
    {
        if ( IsCleanable != null ) {
            this.IsCleanable = IsCleanable;
        }
        if ( IsResumable != null ) {
            this.IsResumable = IsResumable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( RecoveryFid != null ) {
            this.RecoveryFid = RecoveryFid;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
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
        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        if (this.IsCleanable != null) {
            s += ind + "isCleanable\n" ;
        }
        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        if (this.IsResumable != null) {
            s += ind + "isResumable\n" ;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable != null) {
            s += ind + "isViewable\n" ;
        }
        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        if (this.RecoveryFid != null) {
            s += ind + "recoveryFid\n" ;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            s += ind + "recoveryName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsCleanable
        // GraphQL -> isCleanable: Boolean! (scalar)
        if (this.IsCleanable == null && Exploration.Includes(parent + ".isCleanable", true))
        {
            this.IsCleanable = true;
        }
        //      C# -> System.Boolean? IsResumable
        // GraphQL -> isResumable: Boolean! (scalar)
        if (this.IsResumable == null && Exploration.Includes(parent + ".isResumable", true))
        {
            this.IsResumable = true;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable == null && Exploration.Includes(parent + ".isViewable", true))
        {
            this.IsViewable = true;
        }
        //      C# -> System.String? RecoveryFid
        // GraphQL -> recoveryFid: UUID! (scalar)
        if (this.RecoveryFid == null && Exploration.Includes(parent + ".recoveryFid", true))
        {
            this.RecoveryFid = "FETCH";
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName == null && Exploration.Includes(parent + ".recoveryName", true))
        {
            this.RecoveryName = "FETCH";
        }
    }


    #endregion

    } // class RecoveryPermission
    
    #endregion

    public static class ListRecoveryPermissionExtensions
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
            this List<RecoveryPermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types