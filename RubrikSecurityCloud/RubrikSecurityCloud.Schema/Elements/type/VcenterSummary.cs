// VcenterSummary.cs
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
    #region VcenterSummary
    public class VcenterSummary: BaseType
    {
        #region members

        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        [JsonProperty("conflictResolutionAuthz")]
        public VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
        // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("configuredSlaDomainPolarisManagedId")]
        public System.String? ConfiguredSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        [JsonProperty("isHotAddProxyEnabledForOnPremVcenter")]
        public System.Boolean? IsHotAddProxyEnabledForOnPremVcenter { get; set; }

        //      C# -> System.Boolean? IsIoFilterInstalled
        // GraphQL -> isIoFilterInstalled: Boolean (scalar)
        [JsonProperty("isIoFilterInstalled")]
        public System.Boolean? IsIoFilterInstalled { get; set; }

        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean (scalar)
        [JsonProperty("isVmc")]
        public System.Boolean? IsVmc { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? VcenterUuid
        // GraphQL -> vcenterUuid: String (scalar)
        [JsonProperty("vcenterUuid")]
        public System.String? VcenterUuid { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
        // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
        [JsonProperty("computeVisibilityFilter")]
        public List<ClusterVisibilityInfo>? ComputeVisibilityFilter { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        //      C# -> VcenterPatch? VcenterPatch
        // GraphQL -> vcenterPatch: VcenterPatch (type)
        [JsonProperty("vcenterPatch")]
        public VcenterPatch? VcenterPatch { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterSummary";
    }

    public VcenterSummary Set(
        VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz = null,
        System.String? ConfiguredSlaDomainPolarisManagedId = null,
        System.String? Hostname = null,
        System.Boolean? IsHotAddProxyEnabledForOnPremVcenter = null,
        System.Boolean? IsIoFilterInstalled = null,
        System.Boolean? IsVmc = null,
        DateTime? LastRefreshTime = null,
        System.String? Username = null,
        System.String? VcenterUuid = null,
        System.String? Version = null,
        List<ClusterVisibilityInfo>? ComputeVisibilityFilter = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        SlaAssignable? SlaAssignable = null,
        VcenterPatch? VcenterPatch = null
    ) 
    {
        if ( ConflictResolutionAuthz != null ) {
            this.ConflictResolutionAuthz = ConflictResolutionAuthz;
        }
        if ( ConfiguredSlaDomainPolarisManagedId != null ) {
            this.ConfiguredSlaDomainPolarisManagedId = ConfiguredSlaDomainPolarisManagedId;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( IsHotAddProxyEnabledForOnPremVcenter != null ) {
            this.IsHotAddProxyEnabledForOnPremVcenter = IsHotAddProxyEnabledForOnPremVcenter;
        }
        if ( IsIoFilterInstalled != null ) {
            this.IsIoFilterInstalled = IsIoFilterInstalled;
        }
        if ( IsVmc != null ) {
            this.IsVmc = IsVmc;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( VcenterUuid != null ) {
            this.VcenterUuid = VcenterUuid;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ComputeVisibilityFilter != null ) {
            this.ComputeVisibilityFilter = ComputeVisibilityFilter;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
        }
        if ( VcenterPatch != null ) {
            this.VcenterPatch = VcenterPatch;
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
        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        if (this.ConflictResolutionAuthz != null) {
            s += ind + "conflictResolutionAuthz\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
        // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
        if (this.ConfiguredSlaDomainPolarisManagedId != null) {
            s += ind + "configuredSlaDomainPolarisManagedId\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter != null) {
            s += ind + "isHotAddProxyEnabledForOnPremVcenter\n" ;
        }
        //      C# -> System.Boolean? IsIoFilterInstalled
        // GraphQL -> isIoFilterInstalled: Boolean (scalar)
        if (this.IsIoFilterInstalled != null) {
            s += ind + "isIoFilterInstalled\n" ;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean (scalar)
        if (this.IsVmc != null) {
            s += ind + "isVmc\n" ;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            s += ind + "lastRefreshTime\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> System.String? VcenterUuid
        // GraphQL -> vcenterUuid: String (scalar)
        if (this.VcenterUuid != null) {
            s += ind + "vcenterUuid\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
        // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
        if (this.ComputeVisibilityFilter != null) {
            var fspec = this.ComputeVisibilityFilter.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeVisibilityFilter {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VcenterPatch? VcenterPatch
        // GraphQL -> vcenterPatch: VcenterPatch (type)
        if (this.VcenterPatch != null) {
            var fspec = this.VcenterPatch.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vcenterPatch {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        if (this.ConflictResolutionAuthz == null && Exploration.Includes(parent + ".conflictResolutionAuthz", true))
        {
            this.ConflictResolutionAuthz = new VcenterSummaryConflictResolutionAuthz();
        }
        //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
        // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
        if (this.ConfiguredSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".configuredSlaDomainPolarisManagedId", true))
        {
            this.ConfiguredSlaDomainPolarisManagedId = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter == null && Exploration.Includes(parent + ".isHotAddProxyEnabledForOnPremVcenter", true))
        {
            this.IsHotAddProxyEnabledForOnPremVcenter = true;
        }
        //      C# -> System.Boolean? IsIoFilterInstalled
        // GraphQL -> isIoFilterInstalled: Boolean (scalar)
        if (this.IsIoFilterInstalled == null && Exploration.Includes(parent + ".isIoFilterInstalled", true))
        {
            this.IsIoFilterInstalled = true;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean (scalar)
        if (this.IsVmc == null && Exploration.Includes(parent + ".isVmc", true))
        {
            this.IsVmc = true;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime", true))
        {
            this.LastRefreshTime = new DateTime();
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
        //      C# -> System.String? VcenterUuid
        // GraphQL -> vcenterUuid: String (scalar)
        if (this.VcenterUuid == null && Exploration.Includes(parent + ".vcenterUuid", true))
        {
            this.VcenterUuid = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
        //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
        // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
        if (this.ComputeVisibilityFilter == null && Exploration.Includes(parent + ".computeVisibilityFilter"))
        {
            this.ComputeVisibilityFilter = new List<ClusterVisibilityInfo>();
            this.ComputeVisibilityFilter.ApplyExploratoryFieldSpec(parent + ".computeVisibilityFilter");
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new RefreshableObjectConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
        //      C# -> VcenterPatch? VcenterPatch
        // GraphQL -> vcenterPatch: VcenterPatch (type)
        if (this.VcenterPatch == null && Exploration.Includes(parent + ".vcenterPatch"))
        {
            this.VcenterPatch = new VcenterPatch();
            this.VcenterPatch.ApplyExploratoryFieldSpec(parent + ".vcenterPatch");
        }
    }


    #endregion

    } // class VcenterSummary
    
    #endregion

    public static class ListVcenterSummaryExtensions
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
            this List<VcenterSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types