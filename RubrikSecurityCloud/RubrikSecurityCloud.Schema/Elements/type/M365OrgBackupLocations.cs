// M365OrgBackupLocations.cs
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
    #region M365OrgBackupLocations
    public class M365OrgBackupLocations: BaseType
    {
        #region members

        //      C# -> M365Region? PrimaryLocation
        // GraphQL -> primaryLocation: M365Region (type)
        [JsonProperty("primaryLocation")]
        public M365Region? PrimaryLocation { get; set; }

        //      C# -> List<M365Region>? SecondaryLocations
        // GraphQL -> secondaryLocations: [M365Region!]! (type)
        [JsonProperty("secondaryLocations")]
        public List<M365Region>? SecondaryLocations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365OrgBackupLocations";
    }

    public M365OrgBackupLocations Set(
        M365Region? PrimaryLocation = null,
        List<M365Region>? SecondaryLocations = null
    ) 
    {
        if ( PrimaryLocation != null ) {
            this.PrimaryLocation = PrimaryLocation;
        }
        if ( SecondaryLocations != null ) {
            this.SecondaryLocations = SecondaryLocations;
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
        //      C# -> M365Region? PrimaryLocation
        // GraphQL -> primaryLocation: M365Region (type)
        if (this.PrimaryLocation != null) {
            var fspec = this.PrimaryLocation.AsFieldSpec(conf.Child("primaryLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryLocation {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<M365Region>? SecondaryLocations
        // GraphQL -> secondaryLocations: [M365Region!]! (type)
        if (this.SecondaryLocations != null) {
            var fspec = this.SecondaryLocations.AsFieldSpec(conf.Child("secondaryLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryLocations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> M365Region? PrimaryLocation
        // GraphQL -> primaryLocation: M365Region (type)
        if (ec.Includes("primaryLocation",false))
        {
            if(this.PrimaryLocation == null) {

                this.PrimaryLocation = new M365Region();
                this.PrimaryLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryLocation"));

            } else {

                this.PrimaryLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryLocation"));

            }
        }
        else if (this.PrimaryLocation != null && ec.Excludes("primaryLocation",false))
        {
            this.PrimaryLocation = null;
        }
        //      C# -> List<M365Region>? SecondaryLocations
        // GraphQL -> secondaryLocations: [M365Region!]! (type)
        if (ec.Includes("secondaryLocations",false))
        {
            if(this.SecondaryLocations == null) {

                this.SecondaryLocations = new List<M365Region>();
                this.SecondaryLocations.ApplyExploratoryFieldSpec(ec.NewChild("secondaryLocations"));

            } else {

                this.SecondaryLocations.ApplyExploratoryFieldSpec(ec.NewChild("secondaryLocations"));

            }
        }
        else if (this.SecondaryLocations != null && ec.Excludes("secondaryLocations",false))
        {
            this.SecondaryLocations = null;
        }
    }


    #endregion

    } // class M365OrgBackupLocations
    
    #endregion

    public static class ListM365OrgBackupLocationsExtensions
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
            this List<M365OrgBackupLocations> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<M365OrgBackupLocations> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365OrgBackupLocations> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365OrgBackupLocations());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365OrgBackupLocations> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types