// K8sAppManifest.cs
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
    #region K8sAppManifest
    public class K8sAppManifest: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        [JsonProperty("toApply")]
        public AppManifestInfo? ToApply { get; set; }

        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        [JsonProperty("toDelete")]
        public AppManifestInfo? ToDelete { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sAppManifest";
    }

    public K8sAppManifest Set(
        System.Boolean? IsSuccessful = null,
        System.String? Version = null,
        AppManifestInfo? ToApply = null,
        AppManifestInfo? ToDelete = null
    ) 
    {
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ToApply != null ) {
            this.ToApply = ToApply;
        }
        if ( ToDelete != null ) {
            this.ToDelete = ToDelete;
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
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccessful\n" ;
            } else {
                s += ind + "isSuccessful\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        if (this.ToApply != null) {
            var fspec = this.ToApply.AsFieldSpec(conf.Child("toApply"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "toApply" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        if (this.ToDelete != null) {
            var fspec = this.ToDelete.AsFieldSpec(conf.Child("toDelete"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "toDelete" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (ec.Includes("isSuccessful",true))
        {
            if(this.IsSuccessful == null) {

                this.IsSuccessful = true;

            } else {


            }
        }
        else if (this.IsSuccessful != null && ec.Excludes("isSuccessful",true))
        {
            this.IsSuccessful = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        if (ec.Includes("toApply",false))
        {
            if(this.ToApply == null) {

                this.ToApply = new AppManifestInfo();
                this.ToApply.ApplyExploratoryFieldSpec(ec.NewChild("toApply"));

            } else {

                this.ToApply.ApplyExploratoryFieldSpec(ec.NewChild("toApply"));

            }
        }
        else if (this.ToApply != null && ec.Excludes("toApply",false))
        {
            this.ToApply = null;
        }
        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        if (ec.Includes("toDelete",false))
        {
            if(this.ToDelete == null) {

                this.ToDelete = new AppManifestInfo();
                this.ToDelete.ApplyExploratoryFieldSpec(ec.NewChild("toDelete"));

            } else {

                this.ToDelete.ApplyExploratoryFieldSpec(ec.NewChild("toDelete"));

            }
        }
        else if (this.ToDelete != null && ec.Excludes("toDelete",false))
        {
            this.ToDelete = null;
        }
    }


    #endregion

    } // class K8sAppManifest
    
    #endregion

    public static class ListK8sAppManifestExtensions
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
            this List<K8sAppManifest> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sAppManifest> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sAppManifest> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sAppManifest());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sAppManifest> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types