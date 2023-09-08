// RecoveryPlanPermission.cs
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
    #region RecoveryPlanPermission
    public class RecoveryPlanPermission: BaseType
    {
        #region members

        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        [JsonProperty("allowedRecoveryTypes")]
        public List<VmwareRecoveryType>? AllowedRecoveryTypes { get; set; }

        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        [JsonProperty("isRecoverable")]
        public System.Boolean? IsRecoverable { get; set; }

        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        [JsonProperty("isViewable")]
        public System.Boolean? IsViewable { get; set; }

        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        [JsonProperty("recoveryPlanFid")]
        public System.String? RecoveryPlanFid { get; set; }

        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        [JsonProperty("recoveryPlanName")]
        public System.String? RecoveryPlanName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanPermission";
    }

    public RecoveryPlanPermission Set(
        List<VmwareRecoveryType>? AllowedRecoveryTypes = null,
        System.Boolean? IsRecoverable = null,
        System.Boolean? IsViewable = null,
        System.String? RecoveryPlanFid = null,
        System.String? RecoveryPlanName = null
    ) 
    {
        if ( AllowedRecoveryTypes != null ) {
            this.AllowedRecoveryTypes = AllowedRecoveryTypes;
        }
        if ( IsRecoverable != null ) {
            this.IsRecoverable = IsRecoverable;
        }
        if ( IsViewable != null ) {
            this.IsViewable = IsViewable;
        }
        if ( RecoveryPlanFid != null ) {
            this.RecoveryPlanFid = RecoveryPlanFid;
        }
        if ( RecoveryPlanName != null ) {
            this.RecoveryPlanName = RecoveryPlanName;
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
        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        if (this.AllowedRecoveryTypes != null) {
            s += ind + "allowedRecoveryTypes\n" ;
        }
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
        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        if (this.RecoveryPlanFid != null) {
            s += ind + "recoveryPlanFid\n" ;
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName != null) {
            s += ind + "recoveryPlanName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VmwareRecoveryType>? AllowedRecoveryTypes
        // GraphQL -> allowedRecoveryTypes: [VmwareRecoveryType!]! (enum)
        if (this.AllowedRecoveryTypes == null && ec.Includes("allowedRecoveryTypes",true))
        {
            this.AllowedRecoveryTypes = new List<VmwareRecoveryType>();
        }
        //      C# -> System.Boolean? IsRecoverable
        // GraphQL -> isRecoverable: Boolean! (scalar)
        if (this.IsRecoverable == null && ec.Includes("isRecoverable",true))
        {
            this.IsRecoverable = true;
        }
        //      C# -> System.Boolean? IsViewable
        // GraphQL -> isViewable: Boolean! (scalar)
        if (this.IsViewable == null && ec.Includes("isViewable",true))
        {
            this.IsViewable = true;
        }
        //      C# -> System.String? RecoveryPlanFid
        // GraphQL -> recoveryPlanFid: UUID! (scalar)
        if (this.RecoveryPlanFid == null && ec.Includes("recoveryPlanFid",true))
        {
            this.RecoveryPlanFid = "FETCH";
        }
        //      C# -> System.String? RecoveryPlanName
        // GraphQL -> recoveryPlanName: String! (scalar)
        if (this.RecoveryPlanName == null && ec.Includes("recoveryPlanName",true))
        {
            this.RecoveryPlanName = "FETCH";
        }
    }


    #endregion

    } // class RecoveryPlanPermission
    
    #endregion

    public static class ListRecoveryPlanPermissionExtensions
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
            this List<RecoveryPlanPermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanPermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RecoveryPlanPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types