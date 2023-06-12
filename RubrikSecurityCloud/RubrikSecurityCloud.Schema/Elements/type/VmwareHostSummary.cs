// VmwareHostSummary.cs
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
    #region VmwareHostSummary
    public class VmwareHostSummary: BaseType
    {
        #region members

        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public HostFilterStatus? IoFilterStatus { get; set; }

        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        [JsonProperty("ioFilterUiStatus")]
        public HostUiFilterStatus? IoFilterUiStatus { get; set; }

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

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

        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectId")]
        public System.String? EffectiveSlaSourceObjectId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectName")]
        public System.String? EffectiveSlaSourceObjectName { get; set; }

        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        [JsonProperty("esxiVersion")]
        public System.String? EsxiVersion { get; set; }

        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        [JsonProperty("isInVmc")]
        public System.Boolean? IsInVmc { get; set; }

        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        [JsonProperty("datastores")]
        public List<DataStoreSummary>? Datastores { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public VmwareHostSummary Set(
        HostFilterStatus? IoFilterStatus = null,
        HostUiFilterStatus? IoFilterUiStatus = null,
        System.String? ComputeClusterId = null,
        System.String? DatacenterId = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.String? EsxiVersion = null,
        System.Boolean? IsInVmc = null,
        List<DataStoreSummary>? Datastores = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        if ( IoFilterUiStatus != null ) {
            this.IoFilterUiStatus = IoFilterUiStatus;
        }
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EffectiveSlaSourceObjectId != null ) {
            this.EffectiveSlaSourceObjectId = EffectiveSlaSourceObjectId;
        }
        if ( EffectiveSlaSourceObjectName != null ) {
            this.EffectiveSlaSourceObjectName = EffectiveSlaSourceObjectName;
        }
        if ( EsxiVersion != null ) {
            this.EsxiVersion = EsxiVersion;
        }
        if ( IsInVmc != null ) {
            this.IsInVmc = IsInVmc;
        }
        if ( Datastores != null ) {
            this.Datastores = Datastores;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
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
        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            s += ind + "ioFilterStatus\n" ;
        }
        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        if (this.IoFilterUiStatus != null) {
            s += ind + "ioFilterUiStatus\n" ;
        }
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId != null) {
            s += ind + "computeClusterId\n" ;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        if (this.DatacenterId != null) {
            s += ind + "datacenterId\n" ;
        }
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
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId != null) {
            s += ind + "effectiveSlaSourceObjectId\n" ;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName != null) {
            s += ind + "effectiveSlaSourceObjectName\n" ;
        }
        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        if (this.EsxiVersion != null) {
            s += ind + "esxiVersion\n" ;
        }
        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        if (this.IsInVmc != null) {
            s += ind + "isInVmc\n" ;
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores != null) {
            var fspec = this.Datastores.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datastores {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            var fspec = this.EffectiveSlaHolder.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaHolder {\n" + fspec + ind + "}\n" ;
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
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        if (this.IoFilterStatus == null && Exploration.Includes(parent + ".ioFilterStatus", true))
        {
            this.IoFilterStatus = new HostFilterStatus();
        }
        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        if (this.IoFilterUiStatus == null && Exploration.Includes(parent + ".ioFilterUiStatus", true))
        {
            this.IoFilterUiStatus = new HostUiFilterStatus();
        }
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId == null && Exploration.Includes(parent + ".computeClusterId", true))
        {
            this.ComputeClusterId = "FETCH";
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        if (this.DatacenterId == null && Exploration.Includes(parent + ".datacenterId", true))
        {
            this.DatacenterId = "FETCH";
        }
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
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectId", true))
        {
            this.EffectiveSlaSourceObjectId = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName == null && Exploration.Includes(parent + ".effectiveSlaSourceObjectName", true))
        {
            this.EffectiveSlaSourceObjectName = "FETCH";
        }
        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        if (this.EsxiVersion == null && Exploration.Includes(parent + ".esxiVersion", true))
        {
            this.EsxiVersion = "FETCH";
        }
        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        if (this.IsInVmc == null && Exploration.Includes(parent + ".isInVmc", true))
        {
            this.IsInVmc = true;
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores == null && Exploration.Includes(parent + ".datastores"))
        {
            this.Datastores = new List<DataStoreSummary>();
            this.Datastores.ApplyExploratoryFieldSpec(parent + ".datastores");
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder == null && Exploration.Includes(parent + ".effectiveSlaHolder"))
        {
            this.EffectiveSlaHolder = new EffectiveSlaHolder();
            this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(parent + ".effectiveSlaHolder");
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

    } // class VmwareHostSummary
    
    #endregion

    public static class ListVmwareHostSummaryExtensions
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
            this List<VmwareHostSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareHostSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareHostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types