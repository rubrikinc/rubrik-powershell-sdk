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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        if (this.ConflictResolutionAuthz != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conflictResolutionAuthz\n" ;
            } else {
                s += ind + "conflictResolutionAuthz\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
        // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
        if (this.ConfiguredSlaDomainPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainPolarisManagedId\n" ;
            } else {
                s += ind + "configuredSlaDomainPolarisManagedId\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (this.IsHotAddProxyEnabledForOnPremVcenter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHotAddProxyEnabledForOnPremVcenter\n" ;
            } else {
                s += ind + "isHotAddProxyEnabledForOnPremVcenter\n" ;
            }
        }
        //      C# -> System.Boolean? IsIoFilterInstalled
        // GraphQL -> isIoFilterInstalled: Boolean (scalar)
        if (this.IsIoFilterInstalled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIoFilterInstalled\n" ;
            } else {
                s += ind + "isIoFilterInstalled\n" ;
            }
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean (scalar)
        if (this.IsVmc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVmc\n" ;
            } else {
                s += ind + "isVmc\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> System.String? VcenterUuid
        // GraphQL -> vcenterUuid: String (scalar)
        if (this.VcenterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterUuid\n" ;
            } else {
                s += ind + "vcenterUuid\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
        // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
        if (this.ComputeVisibilityFilter != null) {
            var fspec = this.ComputeVisibilityFilter.AsFieldSpec(conf.Child("computeVisibilityFilter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeVisibilityFilter {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VcenterPatch? VcenterPatch
        // GraphQL -> vcenterPatch: VcenterPatch (type)
        if (this.VcenterPatch != null) {
            var fspec = this.VcenterPatch.AsFieldSpec(conf.Child("vcenterPatch"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vcenterPatch {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VcenterSummaryConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterSummaryConflictResolutionAuthz (enum)
        if (ec.Includes("conflictResolutionAuthz",true))
        {
            if(this.ConflictResolutionAuthz == null) {

                this.ConflictResolutionAuthz = new VcenterSummaryConflictResolutionAuthz();

            } else {


            }
        }
        else if (this.ConflictResolutionAuthz != null && ec.Excludes("conflictResolutionAuthz",true))
        {
            this.ConflictResolutionAuthz = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainPolarisManagedId
        // GraphQL -> configuredSlaDomainPolarisManagedId: String (scalar)
        if (ec.Includes("configuredSlaDomainPolarisManagedId",true))
        {
            if(this.ConfiguredSlaDomainPolarisManagedId == null) {

                this.ConfiguredSlaDomainPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainPolarisManagedId != null && ec.Excludes("configuredSlaDomainPolarisManagedId",true))
        {
            this.ConfiguredSlaDomainPolarisManagedId = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Boolean? IsHotAddProxyEnabledForOnPremVcenter
        // GraphQL -> isHotAddProxyEnabledForOnPremVcenter: Boolean (scalar)
        if (ec.Includes("isHotAddProxyEnabledForOnPremVcenter",true))
        {
            if(this.IsHotAddProxyEnabledForOnPremVcenter == null) {

                this.IsHotAddProxyEnabledForOnPremVcenter = true;

            } else {


            }
        }
        else if (this.IsHotAddProxyEnabledForOnPremVcenter != null && ec.Excludes("isHotAddProxyEnabledForOnPremVcenter",true))
        {
            this.IsHotAddProxyEnabledForOnPremVcenter = null;
        }
        //      C# -> System.Boolean? IsIoFilterInstalled
        // GraphQL -> isIoFilterInstalled: Boolean (scalar)
        if (ec.Includes("isIoFilterInstalled",true))
        {
            if(this.IsIoFilterInstalled == null) {

                this.IsIoFilterInstalled = true;

            } else {


            }
        }
        else if (this.IsIoFilterInstalled != null && ec.Excludes("isIoFilterInstalled",true))
        {
            this.IsIoFilterInstalled = null;
        }
        //      C# -> System.Boolean? IsVmc
        // GraphQL -> isVmc: Boolean (scalar)
        if (ec.Includes("isVmc",true))
        {
            if(this.IsVmc == null) {

                this.IsVmc = true;

            } else {


            }
        }
        else if (this.IsVmc != null && ec.Excludes("isVmc",true))
        {
            this.IsVmc = null;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> System.String? VcenterUuid
        // GraphQL -> vcenterUuid: String (scalar)
        if (ec.Includes("vcenterUuid",true))
        {
            if(this.VcenterUuid == null) {

                this.VcenterUuid = "FETCH";

            } else {


            }
        }
        else if (this.VcenterUuid != null && ec.Excludes("vcenterUuid",true))
        {
            this.VcenterUuid = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<ClusterVisibilityInfo>? ComputeVisibilityFilter
        // GraphQL -> computeVisibilityFilter: [ClusterVisibilityInfo!]! (type)
        if (ec.Includes("computeVisibilityFilter",false))
        {
            if(this.ComputeVisibilityFilter == null) {

                this.ComputeVisibilityFilter = new List<ClusterVisibilityInfo>();
                this.ComputeVisibilityFilter.ApplyExploratoryFieldSpec(ec.NewChild("computeVisibilityFilter"));

            } else {

                this.ComputeVisibilityFilter.ApplyExploratoryFieldSpec(ec.NewChild("computeVisibilityFilter"));

            }
        }
        else if (this.ComputeVisibilityFilter != null && ec.Excludes("computeVisibilityFilter",false))
        {
            this.ComputeVisibilityFilter = null;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
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
        //      C# -> VcenterPatch? VcenterPatch
        // GraphQL -> vcenterPatch: VcenterPatch (type)
        if (ec.Includes("vcenterPatch",false))
        {
            if(this.VcenterPatch == null) {

                this.VcenterPatch = new VcenterPatch();
                this.VcenterPatch.ApplyExploratoryFieldSpec(ec.NewChild("vcenterPatch"));

            } else {

                this.VcenterPatch.ApplyExploratoryFieldSpec(ec.NewChild("vcenterPatch"));

            }
        }
        else if (this.VcenterPatch != null && ec.Excludes("vcenterPatch",false))
        {
            this.VcenterPatch = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types