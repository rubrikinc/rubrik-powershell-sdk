// FilesetSummary.cs
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
    #region FilesetSummary
    public class FilesetSummary: BaseType
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

    public override string GetGqlTypeName() {
        return "FilesetSummary";
    }

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
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainPolarisManagedId\n" ;
            } else {
                s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
            }
        }
        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        if (this.EnableHardlinkSupport != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableHardlinkSupport\n" ;
            } else {
                s += ind + "enableHardlinkSupport\n" ;
            }
        }
        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        if (this.EnableSymlinkResolution != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableSymlinkResolution\n" ;
            } else {
                s += ind + "enableSymlinkResolution\n" ;
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
        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        if (this.FailoverClusterAppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverClusterAppId\n" ;
            } else {
                s += ind + "failoverClusterAppId\n" ;
            }
        }
        //      C# -> System.String? FailoverClusterAppName
        // GraphQL -> failoverClusterAppName: String (scalar)
        if (this.FailoverClusterAppName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverClusterAppName\n" ;
            } else {
                s += ind + "failoverClusterAppName\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
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
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEffectiveSlaDomainRetentionLocked\n" ;
            } else {
                s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
            }
        }
        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        if (this.IsPassthrough != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPassthrough\n" ;
            } else {
                s += ind + "isPassthrough\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        if (this.ShareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareId\n" ;
            } else {
                s += ind + "shareId\n" ;
            }
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (this.SnapMirrorLabelForFullBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapMirrorLabelForFullBackup\n" ;
            } else {
                s += ind + "snapMirrorLabelForFullBackup\n" ;
            }
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (this.SnapMirrorLabelForIncrementalBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapMirrorLabelForIncrementalBackup\n" ;
            } else {
                s += ind + "snapMirrorLabelForIncrementalBackup\n" ;
            }
        }
        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        if (this.TemplateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateId\n" ;
            } else {
                s += ind + "templateId\n" ;
            }
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        //      C# -> FilesetArraySpec? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpec (type)
        if (this.ArraySpec != null) {
            var fspec = this.ArraySpec.AsFieldSpec(conf.Child("arraySpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "arraySpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions != null) {
            var fspec = this.FilesetOptions.AsFieldSpec(conf.Child("filesetOptions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetOptions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(conf.Child("pendingSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSlaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (ec.Includes("effectiveSlaDomainId",true))
        {
            if(this.EffectiveSlaDomainId == null) {

                this.EffectiveSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainId != null && ec.Excludes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (ec.Includes("effectiveSlaDomainName",true))
        {
            if(this.EffectiveSlaDomainName == null) {

                this.EffectiveSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainName != null && ec.Excludes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = null;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (ec.Includes("effectiveSlaDomainPolarisManagedId",true))
        {
            if(this.EffectiveSlaDomainPolarisManagedId == null) {

                this.EffectiveSlaDomainPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainPolarisManagedId != null && ec.Excludes("effectiveSlaDomainPolarisManagedId",true))
        {
            this.EffectiveSlaDomainPolarisManagedId = null;
        }
        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        if (ec.Includes("enableHardlinkSupport",true))
        {
            if(this.EnableHardlinkSupport == null) {

                this.EnableHardlinkSupport = true;

            } else {


            }
        }
        else if (this.EnableHardlinkSupport != null && ec.Excludes("enableHardlinkSupport",true))
        {
            this.EnableHardlinkSupport = null;
        }
        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        if (ec.Includes("enableSymlinkResolution",true))
        {
            if(this.EnableSymlinkResolution == null) {

                this.EnableSymlinkResolution = true;

            } else {


            }
        }
        else if (this.EnableSymlinkResolution != null && ec.Excludes("enableSymlinkResolution",true))
        {
            this.EnableSymlinkResolution = null;
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
        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        if (ec.Includes("failoverClusterAppId",true))
        {
            if(this.FailoverClusterAppId == null) {

                this.FailoverClusterAppId = "FETCH";

            } else {


            }
        }
        else if (this.FailoverClusterAppId != null && ec.Excludes("failoverClusterAppId",true))
        {
            this.FailoverClusterAppId = null;
        }
        //      C# -> System.String? FailoverClusterAppName
        // GraphQL -> failoverClusterAppName: String (scalar)
        if (ec.Includes("failoverClusterAppName",true))
        {
            if(this.FailoverClusterAppName == null) {

                this.FailoverClusterAppName = "FETCH";

            } else {


            }
        }
        else if (this.FailoverClusterAppName != null && ec.Excludes("failoverClusterAppName",true))
        {
            this.FailoverClusterAppName = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
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
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (ec.Includes("isEffectiveSlaDomainRetentionLocked",true))
        {
            if(this.IsEffectiveSlaDomainRetentionLocked == null) {

                this.IsEffectiveSlaDomainRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsEffectiveSlaDomainRetentionLocked != null && ec.Excludes("isEffectiveSlaDomainRetentionLocked",true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = null;
        }
        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        if (ec.Includes("isPassthrough",true))
        {
            if(this.IsPassthrough == null) {

                this.IsPassthrough = true;

            } else {


            }
        }
        else if (this.IsPassthrough != null && ec.Excludes("isPassthrough",true))
        {
            this.IsPassthrough = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        if (ec.Includes("shareId",true))
        {
            if(this.ShareId == null) {

                this.ShareId = "FETCH";

            } else {


            }
        }
        else if (this.ShareId != null && ec.Excludes("shareId",true))
        {
            this.ShareId = null;
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (ec.Includes("snapMirrorLabelForFullBackup",true))
        {
            if(this.SnapMirrorLabelForFullBackup == null) {

                this.SnapMirrorLabelForFullBackup = "FETCH";

            } else {


            }
        }
        else if (this.SnapMirrorLabelForFullBackup != null && ec.Excludes("snapMirrorLabelForFullBackup",true))
        {
            this.SnapMirrorLabelForFullBackup = null;
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (ec.Includes("snapMirrorLabelForIncrementalBackup",true))
        {
            if(this.SnapMirrorLabelForIncrementalBackup == null) {

                this.SnapMirrorLabelForIncrementalBackup = "FETCH";

            } else {


            }
        }
        else if (this.SnapMirrorLabelForIncrementalBackup != null && ec.Excludes("snapMirrorLabelForIncrementalBackup",true))
        {
            this.SnapMirrorLabelForIncrementalBackup = null;
        }
        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        if (ec.Includes("templateId",true))
        {
            if(this.TemplateId == null) {

                this.TemplateId = "FETCH";

            } else {


            }
        }
        else if (this.TemplateId != null && ec.Excludes("templateId",true))
        {
            this.TemplateId = null;
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
        //      C# -> FilesetArraySpec? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpec (type)
        if (ec.Includes("arraySpec",false))
        {
            if(this.ArraySpec == null) {

                this.ArraySpec = new FilesetArraySpec();
                this.ArraySpec.ApplyExploratoryFieldSpec(ec.NewChild("arraySpec"));

            } else {

                this.ArraySpec.ApplyExploratoryFieldSpec(ec.NewChild("arraySpec"));

            }
        }
        else if (this.ArraySpec != null && ec.Excludes("arraySpec",false))
        {
            this.ArraySpec = null;
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
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (ec.Includes("pendingSlaDomain",false))
        {
            if(this.PendingSlaDomain == null) {

                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            } else {

                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            }
        }
        else if (this.PendingSlaDomain != null && ec.Excludes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class FilesetSummary
    
    #endregion

    public static class ListFilesetSummaryExtensions
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
            this List<FilesetSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types