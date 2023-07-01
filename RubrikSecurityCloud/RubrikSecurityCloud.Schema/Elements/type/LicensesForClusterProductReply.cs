// LicensesForClusterProductReply.cs
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
    #region LicensesForClusterProductReply
    public class LicensesForClusterProductReply: BaseType
    {
        #region members

        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        [JsonProperty("infos")]
        public List<ProductTypeInfo>? Infos { get; set; }

        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        [JsonProperty("overview")]
        public LicensedClusterProduct? Overview { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicensesForClusterProductReply";
    }

    public LicensesForClusterProductReply Set(
        List<ProductTypeInfo>? Infos = null,
        LicensedClusterProduct? Overview = null
    ) 
    {
        if ( Infos != null ) {
            this.Infos = Infos;
        }
        if ( Overview != null ) {
            this.Overview = Overview;
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
        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        if (this.Infos != null) {
            var fspec = this.Infos.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "infos {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        if (this.Overview != null) {
            var fspec = this.Overview.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "overview {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ProductTypeInfo>? Infos
        // GraphQL -> infos: [ProductTypeInfo!]! (type)
        if (this.Infos == null && Exploration.Includes(parent + ".infos"))
        {
            this.Infos = new List<ProductTypeInfo>();
            this.Infos.ApplyExploratoryFieldSpec(parent + ".infos");
        }
        //      C# -> LicensedClusterProduct? Overview
        // GraphQL -> overview: LicensedClusterProduct (type)
        if (this.Overview == null && Exploration.Includes(parent + ".overview"))
        {
            this.Overview = new LicensedClusterProduct();
            this.Overview.ApplyExploratoryFieldSpec(parent + ".overview");
        }
    }


    #endregion

    } // class LicensesForClusterProductReply
    
    #endregion

    public static class ListLicensesForClusterProductReplyExtensions
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
            this List<LicensesForClusterProductReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LicensesForClusterProductReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LicensesForClusterProductReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types