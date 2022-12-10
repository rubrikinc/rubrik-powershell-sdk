// FilesetSummary.cs
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
    #region FilesetSummary
    public class FilesetSummary: IFragment
    {
        #region members
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        [JsonProperty("enableHardlinkSupport")]
        public System.Boolean? EnableHardlinkSupport { get; set; }

        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        [JsonProperty("enableSymlinkResolution")]
        public System.Boolean? EnableSymlinkResolution { get; set; }

        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        [JsonProperty("exceptions")]
        public List<System.String>? Exceptions { get; set; }

        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        [JsonProperty("excludes")]
        public List<System.String>? Excludes { get; set; }

        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        [JsonProperty("failoverClusterAppId")]
        public System.String? FailoverClusterAppId { get; set; }

        //      C# -> System.String? FailoverClusterAppName
        // GraphQL -> failoverClusterAppName: String (scalar)
        [JsonProperty("failoverClusterAppName")]
        public System.String? FailoverClusterAppName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isEffectiveSlaDomainRetentionLocked")]
        public System.Boolean? IsEffectiveSlaDomainRetentionLocked { get; set; }

        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        [JsonProperty("isPassthrough")]
        public System.Boolean? IsPassthrough { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        [JsonProperty("operatingSystemType")]
        public System.String? OperatingSystemType { get; set; }

        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        [JsonProperty("shareId")]
        public System.String? ShareId { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }

        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        [JsonProperty("templateId")]
        public System.String? TemplateId { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> FilesetArraySpec? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpec (type)
        [JsonProperty("arraySpec")]
        public FilesetArraySpec? ArraySpec { get; set; }

        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        [JsonProperty("filesetOptions")]
        public FilesetOptions? FilesetOptions { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        #endregion

    #region methods

    public FilesetSummary Set(
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.Boolean? EnableHardlinkSupport = null,
        System.Boolean? EnableSymlinkResolution = null,
        List<System.String>? Exceptions = null,
        List<System.String>? Excludes = null,
        System.String? FailoverClusterAppId = null,
        System.String? FailoverClusterAppName = null,
        System.String? HostId = null,
        System.String? HostName = null,
        List<System.String>? Includes = null,
        System.Boolean? IsEffectiveSlaDomainRetentionLocked = null,
        System.Boolean? IsPassthrough = null,
        System.Boolean? IsRelic = null,
        System.String? OperatingSystemType = null,
        System.String? ShareId = null,
        System.String? SnapMirrorLabelForFullBackup = null,
        System.String? SnapMirrorLabelForIncrementalBackup = null,
        System.String? TemplateId = null,
        System.String? TemplateName = null,
        FilesetArraySpec? ArraySpec = null,
        FilesetOptions? FilesetOptions = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EnableHardlinkSupport != null ) {
            this.EnableHardlinkSupport = EnableHardlinkSupport;
        }
        if ( EnableSymlinkResolution != null ) {
            this.EnableSymlinkResolution = EnableSymlinkResolution;
        }
        if ( Exceptions != null ) {
            this.Exceptions = Exceptions;
        }
        if ( Excludes != null ) {
            this.Excludes = Excludes;
        }
        if ( FailoverClusterAppId != null ) {
            this.FailoverClusterAppId = FailoverClusterAppId;
        }
        if ( FailoverClusterAppName != null ) {
            this.FailoverClusterAppName = FailoverClusterAppName;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Includes != null ) {
            this.Includes = Includes;
        }
        if ( IsEffectiveSlaDomainRetentionLocked != null ) {
            this.IsEffectiveSlaDomainRetentionLocked = IsEffectiveSlaDomainRetentionLocked;
        }
        if ( IsPassthrough != null ) {
            this.IsPassthrough = IsPassthrough;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( ShareId != null ) {
            this.ShareId = ShareId;
        }
        if ( SnapMirrorLabelForFullBackup != null ) {
            this.SnapMirrorLabelForFullBackup = SnapMirrorLabelForFullBackup;
        }
        if ( SnapMirrorLabelForIncrementalBackup != null ) {
            this.SnapMirrorLabelForIncrementalBackup = SnapMirrorLabelForIncrementalBackup;
        }
        if ( TemplateId != null ) {
            this.TemplateId = TemplateId;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( ArraySpec != null ) {
            this.ArraySpec = ArraySpec;
        }
        if ( FilesetOptions != null ) {
            this.FilesetOptions = FilesetOptions;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
            //      C# -> System.String? EffectiveSlaDomainId
            // GraphQL -> effectiveSlaDomainId: String (scalar)
            if (this.EffectiveSlaDomainId != null)
            {
                 s += ind + "effectiveSlaDomainId\n";

            }
            //      C# -> System.String? EffectiveSlaDomainName
            // GraphQL -> effectiveSlaDomainName: String (scalar)
            if (this.EffectiveSlaDomainName != null)
            {
                 s += ind + "effectiveSlaDomainName\n";

            }
            //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
            // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
            if (this.EffectiveSlaDomainPolarisManagedId != null)
            {
                 s += ind + "effectiveSlaDomainPolarisManagedId\n";

            }
            //      C# -> System.Boolean? EnableHardlinkSupport
            // GraphQL -> enableHardlinkSupport: Boolean (scalar)
            if (this.EnableHardlinkSupport != null)
            {
                 s += ind + "enableHardlinkSupport\n";

            }
            //      C# -> System.Boolean? EnableSymlinkResolution
            // GraphQL -> enableSymlinkResolution: Boolean (scalar)
            if (this.EnableSymlinkResolution != null)
            {
                 s += ind + "enableSymlinkResolution\n";

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
            //      C# -> System.String? FailoverClusterAppId
            // GraphQL -> failoverClusterAppId: String (scalar)
            if (this.FailoverClusterAppId != null)
            {
                 s += ind + "failoverClusterAppId\n";

            }
            //      C# -> System.String? FailoverClusterAppName
            // GraphQL -> failoverClusterAppName: String (scalar)
            if (this.FailoverClusterAppName != null)
            {
                 s += ind + "failoverClusterAppName\n";

            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes != null)
            {
                 s += ind + "includes\n";

            }
            //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
            // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsEffectiveSlaDomainRetentionLocked != null)
            {
                 s += ind + "isEffectiveSlaDomainRetentionLocked\n";

            }
            //      C# -> System.Boolean? IsPassthrough
            // GraphQL -> isPassthrough: Boolean (scalar)
            if (this.IsPassthrough != null)
            {
                 s += ind + "isPassthrough\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String (scalar)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            //      C# -> System.String? ShareId
            // GraphQL -> shareId: String (scalar)
            if (this.ShareId != null)
            {
                 s += ind + "shareId\n";

            }
            //      C# -> System.String? SnapMirrorLabelForFullBackup
            // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
            if (this.SnapMirrorLabelForFullBackup != null)
            {
                 s += ind + "snapMirrorLabelForFullBackup\n";

            }
            //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
            // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
            if (this.SnapMirrorLabelForIncrementalBackup != null)
            {
                 s += ind + "snapMirrorLabelForIncrementalBackup\n";

            }
            //      C# -> System.String? TemplateId
            // GraphQL -> templateId: String! (scalar)
            if (this.TemplateId != null)
            {
                 s += ind + "templateId\n";

            }
            //      C# -> System.String? TemplateName
            // GraphQL -> templateName: String! (scalar)
            if (this.TemplateName != null)
            {
                 s += ind + "templateName\n";

            }
            //      C# -> FilesetArraySpec? ArraySpec
            // GraphQL -> arraySpec: FilesetArraySpec (type)
            if (this.ArraySpec != null)
            {
                 s += ind + "arraySpec\n";

                 s += ind + "{\n" + 
                 this.ArraySpec.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain != null)
            {
                 s += ind + "pendingSlaDomain\n";

                 s += ind + "{\n" + 
                 this.PendingSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EffectiveSlaDomainId
            // GraphQL -> effectiveSlaDomainId: String (scalar)
            if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId$"))
            {
                this.EffectiveSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaDomainName
            // GraphQL -> effectiveSlaDomainName: String (scalar)
            if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName$"))
            {
                this.EffectiveSlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
            // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
            if (this.EffectiveSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".effectiveSlaDomainPolarisManagedId$"))
            {
                this.EffectiveSlaDomainPolarisManagedId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? EnableHardlinkSupport
            // GraphQL -> enableHardlinkSupport: Boolean (scalar)
            if (this.EnableHardlinkSupport == null && Exploration.Includes(parent + ".enableHardlinkSupport$"))
            {
                this.EnableHardlinkSupport = new System.Boolean();
            }
            //      C# -> System.Boolean? EnableSymlinkResolution
            // GraphQL -> enableSymlinkResolution: Boolean (scalar)
            if (this.EnableSymlinkResolution == null && Exploration.Includes(parent + ".enableSymlinkResolution$"))
            {
                this.EnableSymlinkResolution = new System.Boolean();
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
            //      C# -> System.String? FailoverClusterAppId
            // GraphQL -> failoverClusterAppId: String (scalar)
            if (this.FailoverClusterAppId == null && Exploration.Includes(parent + ".failoverClusterAppId$"))
            {
                this.FailoverClusterAppId = new System.String("FETCH");
            }
            //      C# -> System.String? FailoverClusterAppName
            // GraphQL -> failoverClusterAppName: String (scalar)
            if (this.FailoverClusterAppName == null && Exploration.Includes(parent + ".failoverClusterAppName$"))
            {
                this.FailoverClusterAppName = new System.String("FETCH");
            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes == null && Exploration.Includes(parent + ".includes$"))
            {
                this.Includes = new List<System.String>();
            }
            //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
            // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsEffectiveSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isEffectiveSlaDomainRetentionLocked$"))
            {
                this.IsEffectiveSlaDomainRetentionLocked = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPassthrough
            // GraphQL -> isPassthrough: Boolean (scalar)
            if (this.IsPassthrough == null && Exploration.Includes(parent + ".isPassthrough$"))
            {
                this.IsPassthrough = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String (scalar)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new System.String("FETCH");
            }
            //      C# -> System.String? ShareId
            // GraphQL -> shareId: String (scalar)
            if (this.ShareId == null && Exploration.Includes(parent + ".shareId$"))
            {
                this.ShareId = new System.String("FETCH");
            }
            //      C# -> System.String? SnapMirrorLabelForFullBackup
            // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
            if (this.SnapMirrorLabelForFullBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForFullBackup$"))
            {
                this.SnapMirrorLabelForFullBackup = new System.String("FETCH");
            }
            //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
            // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
            if (this.SnapMirrorLabelForIncrementalBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForIncrementalBackup$"))
            {
                this.SnapMirrorLabelForIncrementalBackup = new System.String("FETCH");
            }
            //      C# -> System.String? TemplateId
            // GraphQL -> templateId: String! (scalar)
            if (this.TemplateId == null && Exploration.Includes(parent + ".templateId$"))
            {
                this.TemplateId = new System.String("FETCH");
            }
            //      C# -> System.String? TemplateName
            // GraphQL -> templateName: String! (scalar)
            if (this.TemplateName == null && Exploration.Includes(parent + ".templateName$"))
            {
                this.TemplateName = new System.String("FETCH");
            }
            //      C# -> FilesetArraySpec? ArraySpec
            // GraphQL -> arraySpec: FilesetArraySpec (type)
            if (this.ArraySpec == null && Exploration.Includes(parent + ".arraySpec"))
            {
                this.ArraySpec = new FilesetArraySpec();
                this.ArraySpec.ApplyExploratoryFragment(parent + ".arraySpec");
            }
            //      C# -> FilesetOptions? FilesetOptions
            // GraphQL -> filesetOptions: FilesetOptions (type)
            if (this.FilesetOptions == null && Exploration.Includes(parent + ".filesetOptions"))
            {
                this.FilesetOptions = new FilesetOptions();
                this.FilesetOptions.ApplyExploratoryFragment(parent + ".filesetOptions");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
        }


    #endregion

    } // class FilesetSummary
    #endregion

    public static class ListFilesetSummaryExtensions
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
            this List<FilesetSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetSummary> list, 
            String parent = "")
        {
            var item = new FilesetSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types