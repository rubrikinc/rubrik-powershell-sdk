// ClusterLicenseCapacityValidations.cs
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
    #region ClusterLicenseCapacityValidations
    public class ClusterLicenseCapacityValidations: BaseType
    {
        #region members

        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        [JsonProperty("errors")]
        public List<ClusterLicenseInfo>? Errors { get; set; }

        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        [JsonProperty("warnings")]
        public List<ClusterLicenseInfo>? Warnings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterLicenseCapacityValidations";
    }

    public ClusterLicenseCapacityValidations Set(
        List<ClusterLicenseInfo>? Errors = null,
        List<ClusterLicenseInfo>? Warnings = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( Warnings != null ) {
            this.Warnings = Warnings;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(conf.Child("errors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        if (this.Warnings != null) {
            var fspec = this.Warnings.AsFieldSpec(conf.Child("warnings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "warnings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        if (ec.Includes("errors",false))
        {
            if(this.Errors == null) {

                this.Errors = new List<ClusterLicenseInfo>();
                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            } else {

                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            }
        }
        else if (this.Errors != null && ec.Excludes("errors",false))
        {
            this.Errors = null;
        }
        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        if (ec.Includes("warnings",false))
        {
            if(this.Warnings == null) {

                this.Warnings = new List<ClusterLicenseInfo>();
                this.Warnings.ApplyExploratoryFieldSpec(ec.NewChild("warnings"));

            } else {

                this.Warnings.ApplyExploratoryFieldSpec(ec.NewChild("warnings"));

            }
        }
        else if (this.Warnings != null && ec.Excludes("warnings",false))
        {
            this.Warnings = null;
        }
    }


    #endregion

    } // class ClusterLicenseCapacityValidations
    
    #endregion

    public static class ListClusterLicenseCapacityValidationsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterLicenseCapacityValidations> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterLicenseCapacityValidations> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterLicenseCapacityValidations> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterLicenseCapacityValidations());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterLicenseCapacityValidations> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types