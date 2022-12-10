// VcenterSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
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
    #region VcenterSummary
    public class VcenterSummary: IFragment
    {
        #region members
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

        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        [JsonProperty("conflictResolutionAuthz")]
        public VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz { get; set; }

        #endregion

    #region methods

    public VcenterSummary Set(
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
        VcenterPatch? VcenterPatch = null,
        VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz = null
    ) 
    {
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
        if ( ConflictResolutionAuthz != null ) {
            this.ConflictResolutionAuthz = ConflictResolutionAuthz;
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
            //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
            // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
            if (this.ConfiguredSlaDomainPolarisManagedId != null)
            {
                 s += ind + "configuredSlaDomainPolarisManagedId\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
            // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
            if (this.IsHotAddProxyEnabledForOnPremVcenter != null)
            {
                 s += ind + "isHotAddProxyEnabledForOnPremVcenter\n";

            }
            //      C# -> System.Boolean? IsIoFilterInstalled
            // GraphQL -> isIoFilterInstalled: Boolean (scalar)
            if (this.IsIoFilterInstalled != null)
            {
                 s += ind + "isIoFilterInstalled\n";

            }
            //      C# -> System.Boolean? IsVmc
            // GraphQL -> isVmc: Boolean (scalar)
            if (this.IsVmc != null)
            {
                 s += ind + "isVmc\n";

            }
            //      C# -> DateTime? LastRefreshTime
            // GraphQL -> lastRefreshTime: DateTime (scalar)
            if (this.LastRefreshTime != null)
            {
                 s += ind + "lastRefreshTime\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> System.String? VcenterUuid
            // GraphQL -> vcenterUuid: String (scalar)
            if (this.VcenterUuid != null)
            {
                 s += ind + "vcenterUuid\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
            // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
            if (this.ComputeVisibilityFilter != null)
            {
                 s += ind + "computeVisibilityFilter\n";

                 s += ind + "{\n" + 
                 this.ComputeVisibilityFilter.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

                 s += ind + "{\n" + 
                 this.ConnectionStatus.AsFragment(indent+1) + 
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
            //      C# -> VcenterPatch? VcenterPatch
            // GraphQL -> vcenterPatch: VcenterPatch (type)
            if (this.VcenterPatch != null)
            {
                 s += ind + "vcenterPatch\n";

                 s += ind + "{\n" + 
                 this.VcenterPatch.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
            // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
            if (this.ConflictResolutionAuthz != null)
            {
                 s += ind + "conflictResolutionAuthz\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
            // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
            if (this.ConfiguredSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".configuredSlaDomainPolarisManagedId$"))
            {
                this.ConfiguredSlaDomainPolarisManagedId = new System.String("FETCH");
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
            // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
            if (this.IsHotAddProxyEnabledForOnPremVcenter == null && Exploration.Includes(parent + ".isHotAddProxyEnabledForOnPremVcenter$"))
            {
                this.IsHotAddProxyEnabledForOnPremVcenter = new System.Boolean();
            }
            //      C# -> System.Boolean? IsIoFilterInstalled
            // GraphQL -> isIoFilterInstalled: Boolean (scalar)
            if (this.IsIoFilterInstalled == null && Exploration.Includes(parent + ".isIoFilterInstalled$"))
            {
                this.IsIoFilterInstalled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsVmc
            // GraphQL -> isVmc: Boolean (scalar)
            if (this.IsVmc == null && Exploration.Includes(parent + ".isVmc$"))
            {
                this.IsVmc = new System.Boolean();
            }
            //      C# -> DateTime? LastRefreshTime
            // GraphQL -> lastRefreshTime: DateTime (scalar)
            if (this.LastRefreshTime == null && Exploration.Includes(parent + ".lastRefreshTime$"))
            {
                this.LastRefreshTime = new DateTime();
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> System.String? VcenterUuid
            // GraphQL -> vcenterUuid: String (scalar)
            if (this.VcenterUuid == null && Exploration.Includes(parent + ".vcenterUuid$"))
            {
                this.VcenterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
            // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
            if (this.ComputeVisibilityFilter == null && Exploration.Includes(parent + ".computeVisibilityFilter"))
            {
                this.ComputeVisibilityFilter = new List<ClusterVisibilityInfo>();
                this.ComputeVisibilityFilter.ApplyExploratoryFragment(parent + ".computeVisibilityFilter");
            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
            {
                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFragment(parent + ".connectionStatus");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
            //      C# -> VcenterPatch? VcenterPatch
            // GraphQL -> vcenterPatch: VcenterPatch (type)
            if (this.VcenterPatch == null && Exploration.Includes(parent + ".vcenterPatch"))
            {
                this.VcenterPatch = new VcenterPatch();
                this.VcenterPatch.ApplyExploratoryFragment(parent + ".vcenterPatch");
            }
            //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
            // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
            if (this.ConflictResolutionAuthz == null && Exploration.Includes(parent + ".conflictResolutionAuthz$"))
            {
                this.ConflictResolutionAuthz = new VcenterSummaryConflictResolutionAuthz();
            }
        }


    #endregion

    } // class VcenterSummary
    #endregion

    public static class ListVcenterSummaryExtensions
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
            this List<VcenterSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VcenterSummary> list, 
            String parent = "")
        {
            var item = new VcenterSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types