// RubrikCloudVaultRansomwareInvestigationEnablement.cs
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
    #region RubrikCloudVaultRansomwareInvestigationEnablement
    public class RubrikCloudVaultRansomwareInvestigationEnablement: BaseType
    {
        #region members

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> RubrikCloudVaultLocation? Location
        // GraphQL -> location: RubrikCloudVaultLocation! (type)
        [JsonProperty("location")]
        public RubrikCloudVaultLocation? Location { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RubrikCloudVaultRansomwareInvestigationEnablement";
    }

    public RubrikCloudVaultRansomwareInvestigationEnablement Set(
        System.Boolean? Enabled = null,
        RubrikCloudVaultLocation? Location = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( Location != null ) {
            this.Location = Location;
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
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            s += ind + "enabled\n" ;
        }
        //      C# -> RubrikCloudVaultLocation? Location
        // GraphQL -> location: RubrikCloudVaultLocation! (type)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "location {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled == null && ec.Includes("enabled",true))
        {
            this.Enabled = true;
        }
        //      C# -> RubrikCloudVaultLocation? Location
        // GraphQL -> location: RubrikCloudVaultLocation! (type)
        if (this.Location == null && ec.Includes("location",false))
        {
            this.Location = new RubrikCloudVaultLocation();
            this.Location.ApplyExploratoryFieldSpec(ec.NewChild("location"));
        }
    }


    #endregion

    } // class RubrikCloudVaultRansomwareInvestigationEnablement
    
    #endregion

    public static class ListRubrikCloudVaultRansomwareInvestigationEnablementExtensions
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
            this List<RubrikCloudVaultRansomwareInvestigationEnablement> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikCloudVaultRansomwareInvestigationEnablement> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikCloudVaultRansomwareInvestigationEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RubrikCloudVaultRansomwareInvestigationEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types