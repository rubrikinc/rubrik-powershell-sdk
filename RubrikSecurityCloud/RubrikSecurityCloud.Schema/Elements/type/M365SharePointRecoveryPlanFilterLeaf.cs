// M365SharePointRecoveryPlanFilterLeaf.cs
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
    #region M365SharePointRecoveryPlanFilterLeaf
    public class M365SharePointRecoveryPlanFilterLeaf: BaseType
    {
        #region members

        //      C# -> M365StringListFilter? FileExtensions
        // GraphQL -> fileExtensions: M365StringListFilter (type)
        [JsonProperty("fileExtensions")]
        public M365StringListFilter? FileExtensions { get; set; }

        //      C# -> M365StringListFilter? FileName
        // GraphQL -> fileName: M365StringListFilter (type)
        [JsonProperty("fileName")]
        public M365StringListFilter? FileName { get; set; }

        //      C# -> M365IntRangeFilter? FileSize
        // GraphQL -> fileSize: M365IntRangeFilter (type)
        [JsonProperty("fileSize")]
        public M365IntRangeFilter? FileSize { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365SharePointRecoveryPlanFilterLeaf";
    }

    public M365SharePointRecoveryPlanFilterLeaf Set(
        M365StringListFilter? FileExtensions = null,
        M365StringListFilter? FileName = null,
        M365IntRangeFilter? FileSize = null
    ) 
    {
        if ( FileExtensions != null ) {
            this.FileExtensions = FileExtensions;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileSize != null ) {
            this.FileSize = FileSize;
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
        //      C# -> M365StringListFilter? FileExtensions
        // GraphQL -> fileExtensions: M365StringListFilter (type)
        if (this.FileExtensions != null) {
            var fspec = this.FileExtensions.AsFieldSpec(conf.Child("fileExtensions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileExtensions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365StringListFilter? FileName
        // GraphQL -> fileName: M365StringListFilter (type)
        if (this.FileName != null) {
            var fspec = this.FileName.AsFieldSpec(conf.Child("fileName"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileName" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365IntRangeFilter? FileSize
        // GraphQL -> fileSize: M365IntRangeFilter (type)
        if (this.FileSize != null) {
            var fspec = this.FileSize.AsFieldSpec(conf.Child("fileSize"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileSize" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> M365StringListFilter? FileExtensions
        // GraphQL -> fileExtensions: M365StringListFilter (type)
        if (ec.Includes("fileExtensions",false))
        {
            if(this.FileExtensions == null) {

                this.FileExtensions = new M365StringListFilter();
                this.FileExtensions.ApplyExploratoryFieldSpec(ec.NewChild("fileExtensions"));

            } else {

                this.FileExtensions.ApplyExploratoryFieldSpec(ec.NewChild("fileExtensions"));

            }
        }
        else if (this.FileExtensions != null && ec.Excludes("fileExtensions",false))
        {
            this.FileExtensions = null;
        }
        //      C# -> M365StringListFilter? FileName
        // GraphQL -> fileName: M365StringListFilter (type)
        if (ec.Includes("fileName",false))
        {
            if(this.FileName == null) {

                this.FileName = new M365StringListFilter();
                this.FileName.ApplyExploratoryFieldSpec(ec.NewChild("fileName"));

            } else {

                this.FileName.ApplyExploratoryFieldSpec(ec.NewChild("fileName"));

            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",false))
        {
            this.FileName = null;
        }
        //      C# -> M365IntRangeFilter? FileSize
        // GraphQL -> fileSize: M365IntRangeFilter (type)
        if (ec.Includes("fileSize",false))
        {
            if(this.FileSize == null) {

                this.FileSize = new M365IntRangeFilter();
                this.FileSize.ApplyExploratoryFieldSpec(ec.NewChild("fileSize"));

            } else {

                this.FileSize.ApplyExploratoryFieldSpec(ec.NewChild("fileSize"));

            }
        }
        else if (this.FileSize != null && ec.Excludes("fileSize",false))
        {
            this.FileSize = null;
        }
    }


    #endregion

    } // class M365SharePointRecoveryPlanFilterLeaf
    
    #endregion

    public static class ListM365SharePointRecoveryPlanFilterLeafExtensions
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
            this List<M365SharePointRecoveryPlanFilterLeaf> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365SharePointRecoveryPlanFilterLeaf> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365SharePointRecoveryPlanFilterLeaf> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365SharePointRecoveryPlanFilterLeaf());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365SharePointRecoveryPlanFilterLeaf> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types