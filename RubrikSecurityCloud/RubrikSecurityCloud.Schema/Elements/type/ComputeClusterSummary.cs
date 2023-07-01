// ComputeClusterSummary.cs
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
    #region ComputeClusterSummary
    public class ComputeClusterSummary: BaseType
    {
        #region members

        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public IoFilterStatus? IoFilterStatus { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        [JsonProperty("drsStatus")]
        public System.Boolean? DrsStatus { get; set; }

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

        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        [JsonProperty("hostVersions")]
        public List<System.String>? HostVersions { get; set; }

        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        [JsonProperty("lastUsedFqdn")]
        public System.String? LastUsedFqdn { get; set; }

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

    public override string GetGqlTypeName() {
        return "ComputeClusterSummary";
    }

    public ComputeClusterSummary Set(
        IoFilterStatus? IoFilterStatus = null,
        System.String? DatacenterId = null,
        System.Boolean? DrsStatus = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        List<System.String>? HostVersions = null,
        System.String? LastUsedFqdn = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( DrsStatus != null ) {
            this.DrsStatus = DrsStatus;
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
        if ( HostVersions != null ) {
            this.HostVersions = HostVersions;
        }
        if ( LastUsedFqdn != null ) {
            this.LastUsedFqdn = LastUsedFqdn;
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
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            s += ind + "ioFilterStatus\n" ;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId != null) {
            s += ind + "datacenterId\n" ;
        }
        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        if (this.DrsStatus != null) {
            s += ind + "drsStatus\n" ;
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
        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        if (this.HostVersions != null) {
            s += ind + "hostVersions\n" ;
        }
        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        if (this.LastUsedFqdn != null) {
            s += ind + "lastUsedFqdn\n" ;
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
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus == null && Exploration.Includes(parent + ".ioFilterStatus", true))
        {
            this.IoFilterStatus = new IoFilterStatus();
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId == null && Exploration.Includes(parent + ".datacenterId", true))
        {
            this.DatacenterId = "FETCH";
        }
        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        if (this.DrsStatus == null && Exploration.Includes(parent + ".drsStatus", true))
        {
            this.DrsStatus = true;
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
        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        if (this.HostVersions == null && Exploration.Includes(parent + ".hostVersions", true))
        {
            this.HostVersions = new List<System.String>();
        }
        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        if (this.LastUsedFqdn == null && Exploration.Includes(parent + ".lastUsedFqdn", true))
        {
            this.LastUsedFqdn = "FETCH";
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

    } // class ComputeClusterSummary
    
    #endregion

    public static class ListComputeClusterSummaryExtensions
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
            this List<ComputeClusterSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types