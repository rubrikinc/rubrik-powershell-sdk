// HuntScanFileCriteria.cs
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
    #region HuntScanFileCriteria
    public class HuntScanFileCriteria: BaseType
    {
        #region members

        //      C# -> HuntScanFileSizeLimits? FileSizeLimits
        // GraphQL -> fileSizeLimits: HuntScanFileSizeLimits (type)
        [JsonProperty("fileSizeLimits")]
        public HuntScanFileSizeLimits? FileSizeLimits { get; set; }

        //      C# -> HuntScanFileTimeLimits? FileTimeLimits
        // GraphQL -> fileTimeLimits: HuntScanFileTimeLimits (type)
        [JsonProperty("fileTimeLimits")]
        public HuntScanFileTimeLimits? FileTimeLimits { get; set; }

        //      C# -> HuntScanPathFilters? PathFilter
        // GraphQL -> pathFilter: HuntScanPathFilters (type)
        [JsonProperty("pathFilter")]
        public HuntScanPathFilters? PathFilter { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HuntScanFileCriteria";
    }

    public HuntScanFileCriteria Set(
        HuntScanFileSizeLimits? FileSizeLimits = null,
        HuntScanFileTimeLimits? FileTimeLimits = null,
        HuntScanPathFilters? PathFilter = null
    ) 
    {
        if ( FileSizeLimits != null ) {
            this.FileSizeLimits = FileSizeLimits;
        }
        if ( FileTimeLimits != null ) {
            this.FileTimeLimits = FileTimeLimits;
        }
        if ( PathFilter != null ) {
            this.PathFilter = PathFilter;
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
        //      C# -> HuntScanFileSizeLimits? FileSizeLimits
        // GraphQL -> fileSizeLimits: HuntScanFileSizeLimits (type)
        if (this.FileSizeLimits != null) {
            var fspec = this.FileSizeLimits.AsFieldSpec(conf.Child("fileSizeLimits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileSizeLimits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HuntScanFileTimeLimits? FileTimeLimits
        // GraphQL -> fileTimeLimits: HuntScanFileTimeLimits (type)
        if (this.FileTimeLimits != null) {
            var fspec = this.FileTimeLimits.AsFieldSpec(conf.Child("fileTimeLimits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileTimeLimits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HuntScanPathFilters? PathFilter
        // GraphQL -> pathFilter: HuntScanPathFilters (type)
        if (this.PathFilter != null) {
            var fspec = this.PathFilter.AsFieldSpec(conf.Child("pathFilter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pathFilter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HuntScanFileSizeLimits? FileSizeLimits
        // GraphQL -> fileSizeLimits: HuntScanFileSizeLimits (type)
        if (ec.Includes("fileSizeLimits",false))
        {
            if(this.FileSizeLimits == null) {

                this.FileSizeLimits = new HuntScanFileSizeLimits();
                this.FileSizeLimits.ApplyExploratoryFieldSpec(ec.NewChild("fileSizeLimits"));

            } else {

                this.FileSizeLimits.ApplyExploratoryFieldSpec(ec.NewChild("fileSizeLimits"));

            }
        }
        else if (this.FileSizeLimits != null && ec.Excludes("fileSizeLimits",false))
        {
            this.FileSizeLimits = null;
        }
        //      C# -> HuntScanFileTimeLimits? FileTimeLimits
        // GraphQL -> fileTimeLimits: HuntScanFileTimeLimits (type)
        if (ec.Includes("fileTimeLimits",false))
        {
            if(this.FileTimeLimits == null) {

                this.FileTimeLimits = new HuntScanFileTimeLimits();
                this.FileTimeLimits.ApplyExploratoryFieldSpec(ec.NewChild("fileTimeLimits"));

            } else {

                this.FileTimeLimits.ApplyExploratoryFieldSpec(ec.NewChild("fileTimeLimits"));

            }
        }
        else if (this.FileTimeLimits != null && ec.Excludes("fileTimeLimits",false))
        {
            this.FileTimeLimits = null;
        }
        //      C# -> HuntScanPathFilters? PathFilter
        // GraphQL -> pathFilter: HuntScanPathFilters (type)
        if (ec.Includes("pathFilter",false))
        {
            if(this.PathFilter == null) {

                this.PathFilter = new HuntScanPathFilters();
                this.PathFilter.ApplyExploratoryFieldSpec(ec.NewChild("pathFilter"));

            } else {

                this.PathFilter.ApplyExploratoryFieldSpec(ec.NewChild("pathFilter"));

            }
        }
        else if (this.PathFilter != null && ec.Excludes("pathFilter",false))
        {
            this.PathFilter = null;
        }
    }


    #endregion

    } // class HuntScanFileCriteria
    
    #endregion

    public static class ListHuntScanFileCriteriaExtensions
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
            this List<HuntScanFileCriteria> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HuntScanFileCriteria> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HuntScanFileCriteria> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HuntScanFileCriteria());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HuntScanFileCriteria> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types