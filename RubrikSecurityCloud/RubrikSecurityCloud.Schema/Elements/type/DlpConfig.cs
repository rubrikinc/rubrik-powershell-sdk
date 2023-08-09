// DlpConfig.cs
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
    #region DlpConfig
    public class DlpConfig: BaseType
    {
        #region members

        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        [JsonProperty("targetType")]
        public DlpConfigTargetType? TargetType { get; set; }

        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!]! (scalar)
        [JsonProperty("policies")]
        public List<System.String>? Policies { get; set; }

        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        [JsonProperty("genericNas")]
        public DlpConfigGenericNas? GenericNas { get; set; }

        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        [JsonProperty("vmwareVm")]
        public DlpConfigVmwareVm? VmwareVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DlpConfig";
    }

    public DlpConfig Set(
        DlpConfigTargetType? TargetType = null,
        List<System.String>? Policies = null,
        DlpConfigGenericNas? GenericNas = null,
        DlpConfigVmwareVm? VmwareVm = null
    ) 
    {
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
        }
        if ( GenericNas != null ) {
            this.GenericNas = GenericNas;
        }
        if ( VmwareVm != null ) {
            this.VmwareVm = VmwareVm;
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
        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!]! (scalar)
        if (this.Policies != null) {
            s += ind + "policies\n" ;
        }
        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        if (this.GenericNas != null) {
            var fspec = this.GenericNas.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "genericNas {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        if (this.VmwareVm != null) {
            var fspec = this.VmwareVm.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareVm {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DlpConfigTargetType? TargetType
        // GraphQL -> targetType: DlpConfigTargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new DlpConfigTargetType();
        }
        //      C# -> List<System.String>? Policies
        // GraphQL -> policies: [String!]! (scalar)
        if (this.Policies == null && Exploration.Includes(parent + ".policies", true))
        {
            this.Policies = new List<System.String>();
        }
        //      C# -> DlpConfigGenericNas? GenericNas
        // GraphQL -> genericNas: DlpConfigGenericNas (type)
        if (this.GenericNas == null && Exploration.Includes(parent + ".genericNas"))
        {
            this.GenericNas = new DlpConfigGenericNas();
            this.GenericNas.ApplyExploratoryFieldSpec(parent + ".genericNas");
        }
        //      C# -> DlpConfigVmwareVm? VmwareVm
        // GraphQL -> vmwareVm: DlpConfigVmwareVm (type)
        if (this.VmwareVm == null && Exploration.Includes(parent + ".vmwareVm"))
        {
            this.VmwareVm = new DlpConfigVmwareVm();
            this.VmwareVm.ApplyExploratoryFieldSpec(parent + ".vmwareVm");
        }
    }


    #endregion

    } // class DlpConfig
    
    #endregion

    public static class ListDlpConfigExtensions
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
            this List<DlpConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DlpConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DlpConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types