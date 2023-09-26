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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> RubrikCloudVaultLocation? Location
        // GraphQL -> location: RubrikCloudVaultLocation! (type)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(conf.Child("location"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "location {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> RubrikCloudVaultLocation? Location
        // GraphQL -> location: RubrikCloudVaultLocation! (type)
        if (ec.Includes("location",false))
        {
            if(this.Location == null) {

                this.Location = new RubrikCloudVaultLocation();
                this.Location.ApplyExploratoryFieldSpec(ec.NewChild("location"));

            } else {

                this.Location.ApplyExploratoryFieldSpec(ec.NewChild("location"));

            }
        }
        else if (this.Location != null && ec.Excludes("location",false))
        {
            this.Location = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<RubrikCloudVaultRansomwareInvestigationEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types