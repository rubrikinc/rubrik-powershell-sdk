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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        if (this.ShareType != null) {
            s += ind + "shareType\n" ;
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling != null) {
            s += ind + "backupScriptErrorHandling\n" ;
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout != null) {
            s += ind + "backupScriptTimeout\n" ;
        }
        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        if (this.Exceptions != null) {
            s += ind + "exceptions\n" ;
        }
        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        if (this.Excludes != null) {
            s += ind + "excludes\n" ;
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes != null) {
            s += ind + "includes\n" ;
        }
        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        if (this.IsArrayEnabled != null) {
            s += ind + "isArrayEnabled\n" ;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr != null) {
            s += ind + "isCreatedByKupr\n" ;
        }
        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        if (this.IsCreatedByPolarisNas != null) {
            s += ind + "isCreatedByPolarisNas\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript != null) {
            s += ind + "postBackupScript\n" ;
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript != null) {
            s += ind + "preBackupScript\n" ;
        }
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions != null) {
            var fspec = this.FilesetOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filesetOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        if (this.OperatingSystemType == null && ec.Includes("operatingSystemType",true))
        {
            this.OperatingSystemType = new FilesetTemplateCreateOperatingSystemType();
        }
        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        if (this.ShareType == null && ec.Includes("shareType",true))
        {
            this.ShareType = new FilesetTemplateCreateShareType();
        }
        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        if (this.BackupScriptErrorHandling == null && ec.Includes("backupScriptErrorHandling",true))
        {
            this.BackupScriptErrorHandling = "FETCH";
        }
        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        if (this.BackupScriptTimeout == null && ec.Includes("backupScriptTimeout",true))
        {
            this.BackupScriptTimeout = new System.Int64();
        }
        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        if (this.Exceptions == null && ec.Includes("exceptions",true))
        {
            this.Exceptions = new List<System.String>();
        }
        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        if (this.Excludes == null && ec.Includes("excludes",true))
        {
            this.Excludes = new List<System.String>();
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes == null && ec.Includes("includes",true))
        {
            this.Includes = new List<System.String>();
        }
        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        if (this.IsArrayEnabled == null && ec.Includes("isArrayEnabled",true))
        {
            this.IsArrayEnabled = true;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr == null && ec.Includes("isCreatedByKupr",true))
        {
            this.IsCreatedByKupr = true;
        }
        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        if (this.IsCreatedByPolarisNas == null && ec.Includes("isCreatedByPolarisNas",true))
        {
            this.IsCreatedByPolarisNas = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        if (this.PostBackupScript == null && ec.Includes("postBackupScript",true))
        {
            this.PostBackupScript = "FETCH";
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        if (this.PreBackupScript == null && ec.Includes("preBackupScript",true))
        {
            this.PreBackupScript = "FETCH";
        }
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions == null && ec.Includes("filesetOptions",false))
        {
            this.FilesetOptions = new FilesetOptions();
            this.FilesetOptions.ApplyExploratoryFieldSpec(ec.NewChild("filesetOptions"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<FilesetTemplateCreate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types