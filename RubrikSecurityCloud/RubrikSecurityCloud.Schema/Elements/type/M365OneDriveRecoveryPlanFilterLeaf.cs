// M365OneDriveRecoveryPlanFilterLeaf.cs
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
    #region M365OneDriveRecoveryPlanFilterLeaf
    public class M365OneDriveRecoveryPlanFilterLeaf: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasUniquePermissions
        // GraphQL -> hasUniquePermissions: Boolean (scalar)
        [JsonProperty("hasUniquePermissions")]
        public System.Boolean? HasUniquePermissions { get; set; }

        //      C# -> RecoveryPlanFilterTimeRange? CreateTime
        // GraphQL -> createTime: RecoveryPlanFilterTimeRange (type)
        [JsonProperty("createTime")]
        public RecoveryPlanFilterTimeRange? CreateTime { get; set; }

        //      C# -> M365StringListFilter? CreatedByEmail
        // GraphQL -> createdByEmail: M365StringListFilter (type)
        [JsonProperty("createdByEmail")]
        public M365StringListFilter? CreatedByEmail { get; set; }

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

        //      C# -> M365StringListFilter? LastModifiedByEmail
        // GraphQL -> lastModifiedByEmail: M365StringListFilter (type)
        [JsonProperty("lastModifiedByEmail")]
        public M365StringListFilter? LastModifiedByEmail { get; set; }

        //      C# -> RecoveryPlanFilterTimeRange? ModifiedTime
        // GraphQL -> modifiedTime: RecoveryPlanFilterTimeRange (type)
        [JsonProperty("modifiedTime")]
        public RecoveryPlanFilterTimeRange? ModifiedTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365OneDriveRecoveryPlanFilterLeaf";
    }

    public M365OneDriveRecoveryPlanFilterLeaf Set(
        System.Boolean? HasUniquePermissions = null,
        RecoveryPlanFilterTimeRange? CreateTime = null,
        M365StringListFilter? CreatedByEmail = null,
        M365StringListFilter? FileExtensions = null,
        M365StringListFilter? FileName = null,
        M365IntRangeFilter? FileSize = null,
        M365StringListFilter? LastModifiedByEmail = null,
        RecoveryPlanFilterTimeRange? ModifiedTime = null
    ) 
    {
        if ( HasUniquePermissions != null ) {
            this.HasUniquePermissions = HasUniquePermissions;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( CreatedByEmail != null ) {
            this.CreatedByEmail = CreatedByEmail;
        }
        if ( FileExtensions != null ) {
            this.FileExtensions = FileExtensions;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileSize != null ) {
            this.FileSize = FileSize;
        }
        if ( LastModifiedByEmail != null ) {
            this.LastModifiedByEmail = LastModifiedByEmail;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
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
        //      C# -> System.Boolean? HasUniquePermissions
        // GraphQL -> hasUniquePermissions: Boolean (scalar)
        if (this.HasUniquePermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUniquePermissions\n" ;
            } else {
                s += ind + "hasUniquePermissions\n" ;
            }
        }
        //      C# -> RecoveryPlanFilterTimeRange? CreateTime
        // GraphQL -> createTime: RecoveryPlanFilterTimeRange (type)
        if (this.CreateTime != null) {
            var fspec = this.CreateTime.AsFieldSpec(conf.Child("createTime"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "createTime" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> M365StringListFilter? CreatedByEmail
        // GraphQL -> createdByEmail: M365StringListFilter (type)
        if (this.CreatedByEmail != null) {
            var fspec = this.CreatedByEmail.AsFieldSpec(conf.Child("createdByEmail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "createdByEmail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
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
        //      C# -> M365StringListFilter? LastModifiedByEmail
        // GraphQL -> lastModifiedByEmail: M365StringListFilter (type)
        if (this.LastModifiedByEmail != null) {
            var fspec = this.LastModifiedByEmail.AsFieldSpec(conf.Child("lastModifiedByEmail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastModifiedByEmail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanFilterTimeRange? ModifiedTime
        // GraphQL -> modifiedTime: RecoveryPlanFilterTimeRange (type)
        if (this.ModifiedTime != null) {
            var fspec = this.ModifiedTime.AsFieldSpec(conf.Child("modifiedTime"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "modifiedTime" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? HasUniquePermissions
        // GraphQL -> hasUniquePermissions: Boolean (scalar)
        if (ec.Includes("hasUniquePermissions",true))
        {
            if(this.HasUniquePermissions == null) {

                this.HasUniquePermissions = true;

            } else {


            }
        }
        else if (this.HasUniquePermissions != null && ec.Excludes("hasUniquePermissions",true))
        {
            this.HasUniquePermissions = null;
        }
        //      C# -> RecoveryPlanFilterTimeRange? CreateTime
        // GraphQL -> createTime: RecoveryPlanFilterTimeRange (type)
        if (ec.Includes("createTime",false))
        {
            if(this.CreateTime == null) {

                this.CreateTime = new RecoveryPlanFilterTimeRange();
                this.CreateTime.ApplyExploratoryFieldSpec(ec.NewChild("createTime"));

            } else {

                this.CreateTime.ApplyExploratoryFieldSpec(ec.NewChild("createTime"));

            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",false))
        {
            this.CreateTime = null;
        }
        //      C# -> M365StringListFilter? CreatedByEmail
        // GraphQL -> createdByEmail: M365StringListFilter (type)
        if (ec.Includes("createdByEmail",false))
        {
            if(this.CreatedByEmail == null) {

                this.CreatedByEmail = new M365StringListFilter();
                this.CreatedByEmail.ApplyExploratoryFieldSpec(ec.NewChild("createdByEmail"));

            } else {

                this.CreatedByEmail.ApplyExploratoryFieldSpec(ec.NewChild("createdByEmail"));

            }
        }
        else if (this.CreatedByEmail != null && ec.Excludes("createdByEmail",false))
        {
            this.CreatedByEmail = null;
        }
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
        //      C# -> M365StringListFilter? LastModifiedByEmail
        // GraphQL -> lastModifiedByEmail: M365StringListFilter (type)
        if (ec.Includes("lastModifiedByEmail",false))
        {
            if(this.LastModifiedByEmail == null) {

                this.LastModifiedByEmail = new M365StringListFilter();
                this.LastModifiedByEmail.ApplyExploratoryFieldSpec(ec.NewChild("lastModifiedByEmail"));

            } else {

                this.LastModifiedByEmail.ApplyExploratoryFieldSpec(ec.NewChild("lastModifiedByEmail"));

            }
        }
        else if (this.LastModifiedByEmail != null && ec.Excludes("lastModifiedByEmail",false))
        {
            this.LastModifiedByEmail = null;
        }
        //      C# -> RecoveryPlanFilterTimeRange? ModifiedTime
        // GraphQL -> modifiedTime: RecoveryPlanFilterTimeRange (type)
        if (ec.Includes("modifiedTime",false))
        {
            if(this.ModifiedTime == null) {

                this.ModifiedTime = new RecoveryPlanFilterTimeRange();
                this.ModifiedTime.ApplyExploratoryFieldSpec(ec.NewChild("modifiedTime"));

            } else {

                this.ModifiedTime.ApplyExploratoryFieldSpec(ec.NewChild("modifiedTime"));

            }
        }
        else if (this.ModifiedTime != null && ec.Excludes("modifiedTime",false))
        {
            this.ModifiedTime = null;
        }
    }


    #endregion

    } // class M365OneDriveRecoveryPlanFilterLeaf
    
    #endregion

    public static class ListM365OneDriveRecoveryPlanFilterLeafExtensions
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
            this List<M365OneDriveRecoveryPlanFilterLeaf> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365OneDriveRecoveryPlanFilterLeaf> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365OneDriveRecoveryPlanFilterLeaf> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365OneDriveRecoveryPlanFilterLeaf());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365OneDriveRecoveryPlanFilterLeaf> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types