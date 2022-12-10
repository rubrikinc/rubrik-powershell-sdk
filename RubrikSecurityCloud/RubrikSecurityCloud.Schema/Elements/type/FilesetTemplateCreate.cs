// FilesetTemplateCreate.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region FilesetTemplateCreate
    public class FilesetTemplateCreate: IFragment
    {
        #region members
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

        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public FilesetTemplateCreateOperatingSystemType? OperatingSystemType { get; set; }

        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        [JsonProperty("shareType")]
        public FilesetTemplateCreateShareType? ShareType { get; set; }

        #endregion

    #region methods

    public FilesetTemplateCreate Set(
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
        FilesetOptions? FilesetOptions = null,
        FilesetTemplateCreateOperatingSystemType? OperatingSystemType = null,
        FilesetTemplateCreateShareType? ShareType = null
    ) 
    {
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
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String (scalar)
            if (this.BackupScriptErrorHandling != null)
            {
                 s += ind + "backupScriptErrorHandling\n";

            }
            //      C# -> System.Int64? BackupScriptTimeout
            // GraphQL -> backupScriptTimeout: Long (scalar)
            if (this.BackupScriptTimeout != null)
            {
                 s += ind + "backupScriptTimeout\n";

            }
            //      C# -> List<System.String>? Exceptions
            // GraphQL -> exceptions: [String!]! (scalar)
            if (this.Exceptions != null)
            {
                 s += ind + "exceptions\n";

            }
            //      C# -> List<System.String>? Excludes
            // GraphQL -> excludes: [String!]! (scalar)
            if (this.Excludes != null)
            {
                 s += ind + "excludes\n";

            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes != null)
            {
                 s += ind + "includes\n";

            }
            //      C# -> System.Boolean? IsArrayEnabled
            // GraphQL -> isArrayEnabled: Boolean (scalar)
            if (this.IsArrayEnabled != null)
            {
                 s += ind + "isArrayEnabled\n";

            }
            //      C# -> System.Boolean? IsCreatedByKupr
            // GraphQL -> isCreatedByKupr: Boolean (scalar)
            if (this.IsCreatedByKupr != null)
            {
                 s += ind + "isCreatedByKupr\n";

            }
            //      C# -> System.Boolean? IsCreatedByPolarisNas
            // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
            if (this.IsCreatedByPolarisNas != null)
            {
                 s += ind + "isCreatedByPolarisNas\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String (scalar)
            if (this.PostBackupScript != null)
            {
                 s += ind + "postBackupScript\n";

            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String (scalar)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

            }
            //      C# -> FilesetOptions? FilesetOptions
            // GraphQL -> filesetOptions: FilesetOptions (type)
            if (this.FilesetOptions != null)
            {
                 s += ind + "filesetOptions\n";

                 s += ind + "{\n" + 
                 this.FilesetOptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
            // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            //      C# -> FilesetTemplateCreateShareType? ShareType
            // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String (scalar)
            if (this.BackupScriptErrorHandling == null && Exploration.Includes(parent + ".backupScriptErrorHandling$"))
            {
                this.BackupScriptErrorHandling = new System.String("FETCH");
            }
            //      C# -> System.Int64? BackupScriptTimeout
            // GraphQL -> backupScriptTimeout: Long (scalar)
            if (this.BackupScriptTimeout == null && Exploration.Includes(parent + ".backupScriptTimeout$"))
            {
                this.BackupScriptTimeout = new System.Int64();
            }
            //      C# -> List<System.String>? Exceptions
            // GraphQL -> exceptions: [String!]! (scalar)
            if (this.Exceptions == null && Exploration.Includes(parent + ".exceptions$"))
            {
                this.Exceptions = new List<System.String>();
            }
            //      C# -> List<System.String>? Excludes
            // GraphQL -> excludes: [String!]! (scalar)
            if (this.Excludes == null && Exploration.Includes(parent + ".excludes$"))
            {
                this.Excludes = new List<System.String>();
            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes == null && Exploration.Includes(parent + ".includes$"))
            {
                this.Includes = new List<System.String>();
            }
            //      C# -> System.Boolean? IsArrayEnabled
            // GraphQL -> isArrayEnabled: Boolean (scalar)
            if (this.IsArrayEnabled == null && Exploration.Includes(parent + ".isArrayEnabled$"))
            {
                this.IsArrayEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsCreatedByKupr
            // GraphQL -> isCreatedByKupr: Boolean (scalar)
            if (this.IsCreatedByKupr == null && Exploration.Includes(parent + ".isCreatedByKupr$"))
            {
                this.IsCreatedByKupr = new System.Boolean();
            }
            //      C# -> System.Boolean? IsCreatedByPolarisNas
            // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
            if (this.IsCreatedByPolarisNas == null && Exploration.Includes(parent + ".isCreatedByPolarisNas$"))
            {
                this.IsCreatedByPolarisNas = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String (scalar)
            if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript$"))
            {
                this.PostBackupScript = new System.String("FETCH");
            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String (scalar)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript$"))
            {
                this.PreBackupScript = new System.String("FETCH");
            }
            //      C# -> FilesetOptions? FilesetOptions
            // GraphQL -> filesetOptions: FilesetOptions (type)
            if (this.FilesetOptions == null && Exploration.Includes(parent + ".filesetOptions"))
            {
                this.FilesetOptions = new FilesetOptions();
                this.FilesetOptions.ApplyExploratoryFragment(parent + ".filesetOptions");
            }
            //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
            // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new FilesetTemplateCreateOperatingSystemType();
            }
            //      C# -> FilesetTemplateCreateShareType? ShareType
            // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new FilesetTemplateCreateShareType();
            }
        }


    #endregion

    } // class FilesetTemplateCreate
    #endregion

    public static class ListFilesetTemplateCreateExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<FilesetTemplateCreate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetTemplateCreate> list, 
            String parent = "")
        {
            var item = new FilesetTemplateCreate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types