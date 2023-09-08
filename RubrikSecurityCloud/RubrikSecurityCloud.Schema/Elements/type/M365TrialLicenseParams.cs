// M365TrialLicenseParams.cs
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
    #region M365TrialLicenseParams
 
    public class M365TrialLicenseParams: BaseType, TrialParams
    {
        #region members

        //      C# -> M365LicenseParams? Value
        // GraphQL -> value: M365LicenseParams! (type)
        [JsonProperty("value")]
        public M365LicenseParams? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365TrialLicenseParams";
    }

    public M365TrialLicenseParams Set(
        M365LicenseParams? Value = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> M365LicenseParams? Value
        // GraphQL -> value: M365LicenseParams! (type)
        if (this.Value != null) {
            var fspec = this.Value.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "value {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> M365LicenseParams? Value
        // GraphQL -> value: M365LicenseParams! (type)
        if (this.Value == null && ec.Includes("value",false))
        {
            this.Value = new M365LicenseParams();
            this.Value.ApplyExploratoryFieldSpec(ec.NewChild("value"));
        }
    }


    #endregion

    } // class M365TrialLicenseParams
    
    #endregion

    public static class ListM365TrialLicenseParamsExtensions
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
            this List<M365TrialLicenseParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<M365TrialLicenseParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365TrialLicenseParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<M365TrialLicenseParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types