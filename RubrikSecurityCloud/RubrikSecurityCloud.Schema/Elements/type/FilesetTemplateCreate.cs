// FilesetTemplateCreate.cs
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
    #region FilesetTemplateCreate
    public class FilesetTemplateCreate: BaseType
    {
        #region members

        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public FilesetTemplateCreateOperatingSystemType? OperatingSystemType { get; set; }

        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        [JsonProperty("shareType")]
        public FilesetTemplateCreateShareType? ShareType { get; set; }

        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        [JsonProperty("backupScriptErrorHandling")]
        public System.String? BackupScriptErrorHandling { get; set; }

        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        [JsonProperty("backupScriptTimeout")]
        public System.Int64? BackupScriptTimeout { get; set; }

        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        [JsonProperty("exceptions")]
        public List<System.String>? Exceptions { get; set; }

        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        [JsonProperty("excludes")]
        public List<System.String>? Excludes { get; set; }

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        [JsonProperty("isArrayEnabled")]
        public System.Boolean? IsArrayEnabled { get; set; }

        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        [JsonProperty("isCreatedByKupr")]
        public System.Boolean? IsCreatedByKupr { get; set; }

        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        [JsonProperty("isCreatedByPolarisNas")]
        public System.Boolean? IsCreatedByPolarisNas { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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

        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        [JsonProperty("filesetOptions")]
        public FilesetOptions? FilesetOptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetTemplateCreate";
    }

    public FilesetTemplateCreate Set(
        FilesetTemplateCreateOperatingSystemType? OperatingSystemType = null,
        FilesetTemplateCreateShareType? ShareType = null,
        System.String? BackupScriptErrorHandling = null,
        System.Int64? BackupScriptTimeout = null,
        List<System.String>? Exceptions = null,
        List<System.String>? Excludes = null,
        List<System.String>? Includes = null,
        System.Boolean? IsArrayEnabled = null,
        System.Boolean? IsCreatedByKupr = null,
        System.Boolean? IsCreatedByPolarisNas = null,
        System.String? Name = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        FilesetOptions? FilesetOptions = null
    ) 
    {
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( BackupScriptErrorHandling != null ) {
            this.BackupScriptErrorHandling = BackupScriptErrorHandling;
        }
        if ( BackupScriptTimeout != null ) {
            this.BackupScriptTimeout = BackupScriptTimeout;
        }
        if ( Exceptions != null ) {
            this.Exceptions = Exceptions;
        }
        if ( Excludes != null ) {
            this.Excludes = Excludes;
        }
        if ( Includes != null ) {
            this.Includes = Includes;
        }
        if ( IsArrayEnabled != null ) {
            this.IsArrayEnabled = IsArrayEnabled;
        }
        if ( IsCreatedByKupr != null ) {
            this.IsCreatedByKupr = IsCreatedByKupr;
        }
        if ( IsCreatedByPolarisNas != null ) {
            this.IsCreatedByPolarisNas = IsCreatedByPolarisNas;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupScriptErrorHandling\n" ;
            } else {
                s += ind + "backupScriptErrorHandling\n" ;
            }
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupScriptTimeout\n" ;
            } else {
                s += ind + "backupScriptTimeout\n" ;
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
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includes\n" ;
            } else {
                s += ind + "includes\n" ;
            }
        }
        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        if (this.IsArrayEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArrayEnabled\n" ;
            } else {
                s += ind + "isArrayEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCreatedByKupr\n" ;
            } else {
                s += ind + "isCreatedByKupr\n" ;
            }
        }
        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        if (this.IsCreatedByPolarisNas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCreatedByPolarisNas\n" ;
            } else {
                s += ind + "isCreatedByPolarisNas\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions != null) {
            var fspec = this.FilesetOptions.AsFieldSpec(conf.Child("filesetOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetOptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = new FilesetTemplateCreateOperatingSystemType();

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = new FilesetTemplateCreateShareType();

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
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
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (ec.Includes("backupScriptTimeout",true))
        {
            if(this.BackupScriptTimeout == null) {

                this.BackupScriptTimeout = new System.Int64();

            } else {


            }
        }
        else if (this.BackupScriptTimeout != null && ec.Excludes("backupScriptTimeout",true))
        {
            this.BackupScriptTimeout = null;
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
        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        if (ec.Includes("isArrayEnabled",true))
        {
            if(this.IsArrayEnabled == null) {

                this.IsArrayEnabled = true;

            } else {


            }
        }
        else if (this.IsArrayEnabled != null && ec.Excludes("isArrayEnabled",true))
        {
            this.IsArrayEnabled = null;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (ec.Includes("isCreatedByKupr",true))
        {
            if(this.IsCreatedByKupr == null) {

                this.IsCreatedByKupr = true;

            } else {


            }
        }
        else if (this.IsCreatedByKupr != null && ec.Excludes("isCreatedByKupr",true))
        {
            this.IsCreatedByKupr = null;
        }
        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        if (ec.Includes("isCreatedByPolarisNas",true))
        {
            if(this.IsCreatedByPolarisNas == null) {

                this.IsCreatedByPolarisNas = true;

            } else {


            }
        }
        else if (this.IsCreatedByPolarisNas != null && ec.Excludes("isCreatedByPolarisNas",true))
        {
            this.IsCreatedByPolarisNas = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (ec.Includes("filesetOptions",false))
        {
            if(this.FilesetOptions == null) {

                this.FilesetOptions = new FilesetOptions();
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

    } // class FilesetTemplateCreate
    
    #endregion

    public static class ListFilesetTemplateCreateExtensions
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
            this List<FilesetTemplateCreate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetTemplateCreate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetTemplateCreate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetTemplateCreate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types