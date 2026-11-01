// AwsPermissionDiff.cs
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
    #region AwsPermissionDiff
    public class AwsPermissionDiff: BaseType
    {
        #region members

        //      C# -> List<CloudAccountFeature>? UnresolvedFeatures
        // GraphQL -> unresolvedFeatures: [CloudAccountFeature!]! (enum)
        [JsonProperty("unresolvedFeatures")]
        public List<CloudAccountFeature>? UnresolvedFeatures { get; set; }

        //      C# -> List<AwsPermissionDiffEntry>? Entries
        // GraphQL -> entries: [AwsPermissionDiffEntry!]! (type)
        [JsonProperty("entries")]
        public List<AwsPermissionDiffEntry>? Entries { get; set; }

        //      C# -> List<AwsPermissionsGroupVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [AwsPermissionsGroupVersion!]! (type)
        [JsonProperty("permissionsGroupVersions")]
        public List<AwsPermissionsGroupVersion>? PermissionsGroupVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsPermissionDiff";
    }

    public AwsPermissionDiff Set(
        List<CloudAccountFeature>? UnresolvedFeatures = null,
        List<AwsPermissionDiffEntry>? Entries = null,
        List<AwsPermissionsGroupVersion>? PermissionsGroupVersions = null
    ) 
    {
        if ( UnresolvedFeatures != null ) {
            this.UnresolvedFeatures = UnresolvedFeatures;
        }
        if ( Entries != null ) {
            this.Entries = Entries;
        }
        if ( PermissionsGroupVersions != null ) {
            this.PermissionsGroupVersions = PermissionsGroupVersions;
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
        //      C# -> List<CloudAccountFeature>? UnresolvedFeatures
        // GraphQL -> unresolvedFeatures: [CloudAccountFeature!]! (enum)
        if (this.UnresolvedFeatures != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unresolvedFeatures\n" ;
            } else {
                s += ind + "unresolvedFeatures\n" ;
            }
        }
        //      C# -> List<AwsPermissionDiffEntry>? Entries
        // GraphQL -> entries: [AwsPermissionDiffEntry!]! (type)
        if (this.Entries != null) {
            var fspec = this.Entries.AsFieldSpec(conf.Child("entries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionsGroupVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [AwsPermissionsGroupVersion!]! (type)
        if (this.PermissionsGroupVersions != null) {
            var fspec = this.PermissionsGroupVersions.AsFieldSpec(conf.Child("permissionsGroupVersions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsGroupVersions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<CloudAccountFeature>? UnresolvedFeatures
        // GraphQL -> unresolvedFeatures: [CloudAccountFeature!]! (enum)
        if (ec.Includes("unresolvedFeatures",true))
        {
            if(this.UnresolvedFeatures == null) {

                this.UnresolvedFeatures = new List<CloudAccountFeature>();

            } else {


            }
        }
        else if (this.UnresolvedFeatures != null && ec.Excludes("unresolvedFeatures",true))
        {
            this.UnresolvedFeatures = null;
        }
        //      C# -> List<AwsPermissionDiffEntry>? Entries
        // GraphQL -> entries: [AwsPermissionDiffEntry!]! (type)
        if (ec.Includes("entries",false))
        {
            if(this.Entries == null) {

                this.Entries = new List<AwsPermissionDiffEntry>();
                this.Entries.ApplyExploratoryFieldSpec(ec.NewChild("entries"));

            } else {

                this.Entries.ApplyExploratoryFieldSpec(ec.NewChild("entries"));

            }
        }
        else if (this.Entries != null && ec.Excludes("entries",false))
        {
            this.Entries = null;
        }
        //      C# -> List<AwsPermissionsGroupVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [AwsPermissionsGroupVersion!]! (type)
        if (ec.Includes("permissionsGroupVersions",false))
        {
            if(this.PermissionsGroupVersions == null) {

                this.PermissionsGroupVersions = new List<AwsPermissionsGroupVersion>();
                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            } else {

                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            }
        }
        else if (this.PermissionsGroupVersions != null && ec.Excludes("permissionsGroupVersions",false))
        {
            this.PermissionsGroupVersions = null;
        }
    }


    #endregion

    } // class AwsPermissionDiff
    
    #endregion

    public static class ListAwsPermissionDiffExtensions
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
            this List<AwsPermissionDiff> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsPermissionDiff> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsPermissionDiff> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsPermissionDiff());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsPermissionDiff> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types