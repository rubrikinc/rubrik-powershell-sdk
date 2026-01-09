// TprFilesetTemplatePatch.cs
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
    #region TprFilesetTemplatePatch
    public class TprFilesetTemplatePatch: BaseType
    {
        #region members

        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        [JsonProperty("backupScriptErrorHandling")]
        public System.String? BackupScriptErrorHandling { get; set; }

        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        [JsonProperty("exceptions")]
        public List<System.String>? Exceptions { get; set; }

        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        [JsonProperty("excludes")]
        public List<System.String>? Excludes { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths
        // GraphQL -> shouldOverrideClusterWideBlocklistedFilesystemPaths: Boolean (scalar)
        [JsonProperty("shouldOverrideClusterWideBlocklistedFilesystemPaths")]
        public System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths { get; set; }

        //      C# -> System.Boolean? ShouldRetryPrescriptIfBackupFails
        // GraphQL -> shouldRetryPrescriptIfBackupFails: Boolean (scalar)
        [JsonProperty("shouldRetryPrescriptIfBackupFails")]
        public System.Boolean? ShouldRetryPrescriptIfBackupFails { get; set; }

        //      C# -> System.String? TemplateBlocklistedFilesystemPaths
        // GraphQL -> templateBlocklistedFilesystemPaths: String (scalar)
        [JsonProperty("templateBlocklistedFilesystemPaths")]
        public System.String? TemplateBlocklistedFilesystemPaths { get; set; }

        //      C# -> TprFilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: TprFilesetOptions (type)
        [JsonProperty("filesetOptions")]
        public TprFilesetOptions? FilesetOptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprFilesetTemplatePatch";
    }

    public TprFilesetTemplatePatch Set(
        System.String? BackupScriptErrorHandling = null,
        List<System.String>? Exceptions = null,
        List<System.String>? Excludes = null,
        System.String? Id = null,
        List<System.String>? Includes = null,
        System.String? Name = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths = null,
        System.Boolean? ShouldRetryPrescriptIfBackupFails = null,
        System.String? TemplateBlocklistedFilesystemPaths = null,
        TprFilesetOptions? FilesetOptions = null
    ) 
    {
        if ( BackupScriptErrorHandling != null ) {
            this.BackupScriptErrorHandling = BackupScriptErrorHandling;
        }
        if ( Exceptions != null ) {
            this.Exceptions = Exceptions;
        }
        if ( Excludes != null ) {
            this.Excludes = Excludes;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Includes != null ) {
            this.Includes = Includes;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( ShouldOverrideClusterWideBlocklistedFilesystemPaths != null ) {
            this.ShouldOverrideClusterWideBlocklistedFilesystemPaths = ShouldOverrideClusterWideBlocklistedFilesystemPaths;
        }
        if ( ShouldRetryPrescriptIfBackupFails != null ) {
            this.ShouldRetryPrescriptIfBackupFails = ShouldRetryPrescriptIfBackupFails;
        }
        if ( TemplateBlocklistedFilesystemPaths != null ) {
            this.TemplateBlocklistedFilesystemPaths = TemplateBlocklistedFilesystemPaths;
        }
        if ( FilesetOptions != null ) {
            this.FilesetOptions = FilesetOptions;
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
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupScriptErrorHandling\n" ;
            } else {
                s += ind + "backupScriptErrorHandling\n" ;
            }
        }
        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        if (this.Exceptions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exceptions\n" ;
            } else {
                s += ind + "exceptions\n" ;
            }
        }
        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        if (this.Excludes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludes\n" ;
            } else {
                s += ind + "excludes\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includes\n" ;
            } else {
                s += ind + "includes\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postBackupScript\n" ;
            } else {
                s += ind + "postBackupScript\n" ;
            }
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preBackupScript\n" ;
            } else {
                s += ind + "preBackupScript\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths
        // GraphQL -> shouldOverrideClusterWideBlocklistedFilesystemPaths: Boolean (scalar)
        if (this.ShouldOverrideClusterWideBlocklistedFilesystemPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldOverrideClusterWideBlocklistedFilesystemPaths\n" ;
            } else {
                s += ind + "shouldOverrideClusterWideBlocklistedFilesystemPaths\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldRetryPrescriptIfBackupFails
        // GraphQL -> shouldRetryPrescriptIfBackupFails: Boolean (scalar)
        if (this.ShouldRetryPrescriptIfBackupFails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldRetryPrescriptIfBackupFails\n" ;
            } else {
                s += ind + "shouldRetryPrescriptIfBackupFails\n" ;
            }
        }
        //      C# -> System.String? TemplateBlocklistedFilesystemPaths
        // GraphQL -> templateBlocklistedFilesystemPaths: String (scalar)
        if (this.TemplateBlocklistedFilesystemPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateBlocklistedFilesystemPaths\n" ;
            } else {
                s += ind + "templateBlocklistedFilesystemPaths\n" ;
            }
        }
        //      C# -> TprFilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: TprFilesetOptions (type)
        if (this.FilesetOptions != null) {
            var fspec = this.FilesetOptions.AsFieldSpec(conf.Child("filesetOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetOptions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (ec.Includes("backupScriptErrorHandling",true))
        {
            if(this.BackupScriptErrorHandling == null) {

                this.BackupScriptErrorHandling = "FETCH";

            } else {


            }
        }
        else if (this.BackupScriptErrorHandling != null && ec.Excludes("backupScriptErrorHandling",true))
        {
            this.BackupScriptErrorHandling = null;
        }
        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        if (ec.Includes("exceptions",true))
        {
            if(this.Exceptions == null) {

                this.Exceptions = new List<System.String>();

            } else {


            }
        }
        else if (this.Exceptions != null && ec.Excludes("exceptions",true))
        {
            this.Exceptions = null;
        }
        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        if (ec.Includes("excludes",true))
        {
            if(this.Excludes == null) {

                this.Excludes = new List<System.String>();

            } else {


            }
        }
        else if (this.Excludes != null && ec.Excludes("excludes",true))
        {
            this.Excludes = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (ec.Includes("includes",true))
        {
            if(this.Includes == null) {

                this.Includes = new List<System.String>();

            } else {


            }
        }
        else if (this.Includes != null && ec.Excludes("includes",true))
        {
            this.Includes = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (ec.Includes("postBackupScript",true))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",true))
        {
            this.PostBackupScript = null;
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (ec.Includes("preBackupScript",true))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",true))
        {
            this.PreBackupScript = null;
        }
        //      C# -> System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths
        // GraphQL -> shouldOverrideClusterWideBlocklistedFilesystemPaths: Boolean (scalar)
        if (ec.Includes("shouldOverrideClusterWideBlocklistedFilesystemPaths",true))
        {
            if(this.ShouldOverrideClusterWideBlocklistedFilesystemPaths == null) {

                this.ShouldOverrideClusterWideBlocklistedFilesystemPaths = true;

            } else {


            }
        }
        else if (this.ShouldOverrideClusterWideBlocklistedFilesystemPaths != null && ec.Excludes("shouldOverrideClusterWideBlocklistedFilesystemPaths",true))
        {
            this.ShouldOverrideClusterWideBlocklistedFilesystemPaths = null;
        }
        //      C# -> System.Boolean? ShouldRetryPrescriptIfBackupFails
        // GraphQL -> shouldRetryPrescriptIfBackupFails: Boolean (scalar)
        if (ec.Includes("shouldRetryPrescriptIfBackupFails",true))
        {
            if(this.ShouldRetryPrescriptIfBackupFails == null) {

                this.ShouldRetryPrescriptIfBackupFails = true;

            } else {


            }
        }
        else if (this.ShouldRetryPrescriptIfBackupFails != null && ec.Excludes("shouldRetryPrescriptIfBackupFails",true))
        {
            this.ShouldRetryPrescriptIfBackupFails = null;
        }
        //      C# -> System.String? TemplateBlocklistedFilesystemPaths
        // GraphQL -> templateBlocklistedFilesystemPaths: String (scalar)
        if (ec.Includes("templateBlocklistedFilesystemPaths",true))
        {
            if(this.TemplateBlocklistedFilesystemPaths == null) {

                this.TemplateBlocklistedFilesystemPaths = "FETCH";

            } else {


            }
        }
        else if (this.TemplateBlocklistedFilesystemPaths != null && ec.Excludes("templateBlocklistedFilesystemPaths",true))
        {
            this.TemplateBlocklistedFilesystemPaths = null;
        }
        //      C# -> TprFilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: TprFilesetOptions (type)
        if (ec.Includes("filesetOptions",false))
        {
            if(this.FilesetOptions == null) {

                this.FilesetOptions = new TprFilesetOptions();
                this.FilesetOptions.ApplyExploratoryFieldSpec(ec.NewChild("filesetOptions"));

            } else {

                this.FilesetOptions.ApplyExploratoryFieldSpec(ec.NewChild("filesetOptions"));

            }
        }
        else if (this.FilesetOptions != null && ec.Excludes("filesetOptions",false))
        {
            this.FilesetOptions = null;
        }
    }


    #endregion

    } // class TprFilesetTemplatePatch
    
    #endregion

    public static class ListTprFilesetTemplatePatchExtensions
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
            this List<TprFilesetTemplatePatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprFilesetTemplatePatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprFilesetTemplatePatch> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprFilesetTemplatePatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprFilesetTemplatePatch> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types