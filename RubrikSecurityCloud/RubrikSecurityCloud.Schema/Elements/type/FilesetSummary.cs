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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            s += ind + "effectiveSlaDomainName\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
        }
        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        if (this.EnableHardlinkSupport != null) {
            s += ind + "enableHardlinkSupport\n" ;
        }
        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        if (this.EnableSymlinkResolution != null) {
            s += ind + "enableSymlinkResolution\n" ;
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
        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        if (this.FailoverClusterAppId != null) {
            s += ind + "failoverClusterAppId\n" ;
        }
        //      C# -> System.String? FailoverClusterAppName
        // GraphQL -> failoverClusterAppName: String (scalar)
        if (this.FailoverClusterAppName != null) {
            s += ind + "failoverClusterAppName\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes != null) {
            s += ind + "includes\n" ;
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked != null) {
            s += ind + "isEffectiveSlaDomainRetentionLocked\n" ;
        }
        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        if (this.IsPassthrough != null) {
            s += ind + "isPassthrough\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        if (this.ShareId != null) {
            s += ind + "shareId\n" ;
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (this.SnapMirrorLabelForFullBackup != null) {
            s += ind + "snapMirrorLabelForFullBackup\n" ;
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (this.SnapMirrorLabelForIncrementalBackup != null) {
            s += ind + "snapMirrorLabelForIncrementalBackup\n" ;
        }
        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        if (this.TemplateId != null) {
            s += ind + "templateId\n" ;
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            s += ind + "templateName\n" ;
        }
        //      C# -> FilesetArraySpec? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpec (type)
        if (this.ArraySpec != null) {
            s += ind + "arraySpec {\n" + this.ArraySpec.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions != null) {
            s += ind + "filesetOptions {\n" + this.FilesetOptions.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            s += ind + "pendingSlaDomain {\n" + this.PendingSlaDomain.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId", true))
        {
            this.EffectiveSlaDomainId = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName", true))
        {
            this.EffectiveSlaDomainName = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".effectiveSlaDomainPolarisManagedId", true))
        {
            this.EffectiveSlaDomainPolarisManagedId = "FETCH";
        }
        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        if (this.EnableHardlinkSupport == null && Exploration.Includes(parent + ".enableHardlinkSupport", true))
        {
            this.EnableHardlinkSupport = true;
        }
        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        if (this.EnableSymlinkResolution == null && Exploration.Includes(parent + ".enableSymlinkResolution", true))
        {
            this.EnableSymlinkResolution = true;
        }
        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        if (this.Exceptions == null && Exploration.Includes(parent + ".exceptions", true))
        {
            this.Exceptions = new List<System.String>();
        }
        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        if (this.Excludes == null && Exploration.Includes(parent + ".excludes", true))
        {
            this.Excludes = new List<System.String>();
        }
        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        if (this.FailoverClusterAppId == null && Exploration.Includes(parent + ".failoverClusterAppId", true))
        {
            this.FailoverClusterAppId = "FETCH";
        }
        //      C# -> System.String? FailoverClusterAppName
        // GraphQL -> failoverClusterAppName: String (scalar)
        if (this.FailoverClusterAppName == null && Exploration.Includes(parent + ".failoverClusterAppName", true))
        {
            this.FailoverClusterAppName = "FETCH";
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        if (this.Includes == null && Exploration.Includes(parent + ".includes", true))
        {
            this.Includes = new List<System.String>();
        }
        //      C# -> System.Boolean? IsEffectiveSlaDomainRetentionLocked
        // GraphQL -> isEffectiveSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsEffectiveSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isEffectiveSlaDomainRetentionLocked", true))
        {
            this.IsEffectiveSlaDomainRetentionLocked = true;
        }
        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        if (this.IsPassthrough == null && Exploration.Includes(parent + ".isPassthrough", true))
        {
            this.IsPassthrough = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String (scalar)
        if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType", true))
        {
            this.OperatingSystemType = "FETCH";
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        if (this.ShareId == null && Exploration.Includes(parent + ".shareId", true))
        {
            this.ShareId = "FETCH";
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (this.SnapMirrorLabelForFullBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForFullBackup", true))
        {
            this.SnapMirrorLabelForFullBackup = "FETCH";
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (this.SnapMirrorLabelForIncrementalBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForIncrementalBackup", true))
        {
            this.SnapMirrorLabelForIncrementalBackup = "FETCH";
        }
        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        if (this.TemplateId == null && Exploration.Includes(parent + ".templateId", true))
        {
            this.TemplateId = "FETCH";
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName == null && Exploration.Includes(parent + ".templateName", true))
        {
            this.TemplateName = "FETCH";
        }
        //      C# -> FilesetArraySpec? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpec (type)
        if (this.ArraySpec == null && Exploration.Includes(parent + ".arraySpec"))
        {
            this.ArraySpec = new FilesetArraySpec();
            this.ArraySpec.ApplyExploratoryFieldSpec(parent + ".arraySpec");
        }
        //      C# -> FilesetOptions? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptions (type)
        if (this.FilesetOptions == null && Exploration.Includes(parent + ".filesetOptions"))
        {
            this.FilesetOptions = new FilesetOptions();
            this.FilesetOptions.ApplyExploratoryFieldSpec(parent + ".filesetOptions");
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(parent + ".pendingSlaDomain");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class FilesetSummary
    
    #endregion

    public static class ListFilesetSummaryExtensions
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
            this List<FilesetSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types