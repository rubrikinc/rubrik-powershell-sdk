// CheckVmwareVmsRecoveryPermissionReply.cs
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
    #region CheckVmwareVmsRecoveryPermissionReply
    public class CheckVmwareVmsRecoveryPermissionReply: BaseType
    {
        #region members

        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        [JsonProperty("vmwareRecoveryType")]
        public VmwareRecoveryType? VmwareRecoveryType { get; set; }

        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        [JsonProperty("result")]
        public List<VmwareVmRecoveryAccess>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckVmwareVmsRecoveryPermissionReply";
    }

    public CheckVmwareVmsRecoveryPermissionReply Set(
        VmwareRecoveryType? VmwareRecoveryType = null,
        List<VmwareVmRecoveryAccess>? Result = null
    ) 
    {
        if ( VmwareRecoveryType != null ) {
            this.VmwareRecoveryType = VmwareRecoveryType;
        }
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        if (this.VmwareRecoveryType != null) {
            s += ind + "vmwareRecoveryType\n" ;
        }
        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "result {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VmwareRecoveryType? VmwareRecoveryType
        // GraphQL -> vmwareRecoveryType: VmwareRecoveryType! (enum)
        if (this.VmwareRecoveryType == null && ec.Includes("vmwareRecoveryType",true))
        {
            this.VmwareRecoveryType = new VmwareRecoveryType();
        }
        //      C# -> List<VmwareVmRecoveryAccess>? Result
        // GraphQL -> result: [VmwareVmRecoveryAccess!]! (type)
        if (this.Result == null && ec.Includes("result",false))
        {
            this.Result = new List<VmwareVmRecoveryAccess>();
            this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));
        }
    }


    #endregion

    } // class CheckVmwareVmsRecoveryPermissionReply
    
    #endregion

    public static class ListCheckVmwareVmsRecoveryPermissionReplyExtensions
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
            this List<CheckVmwareVmsRecoveryPermissionReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CheckVmwareVmsRecoveryPermissionReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckVmwareVmsRecoveryPermissionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CheckVmwareVmsRecoveryPermissionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types