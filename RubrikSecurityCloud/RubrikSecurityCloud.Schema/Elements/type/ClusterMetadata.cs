// ClusterMetadata.cs
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
    #region ClusterMetadata
    public class ClusterMetadata: BaseType
    {
        #region members

        //      C# -> CcpClusterType? ClusterType
        // GraphQL -> clusterType: CcpClusterType! (enum)
        [JsonProperty("clusterType")]
        public CcpClusterType? ClusterType { get; set; }

        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CcpJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? JobStartTime
        // GraphQL -> jobStartTime: Long! (scalar)
        [JsonProperty("jobStartTime")]
        public System.Int64? JobStartTime { get; set; }

        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        [JsonProperty("marshaledConfig")]
        public System.String? MarshaledConfig { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }


        #endregion

    #region methods

    public ClusterMetadata Set(
        CcpClusterType? ClusterType = null,
        CcpJobStatus? JobStatus = null,
        CcpJobType? JobType = null,
        CcpVendorType? Vendor = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.Int64? JobStartTime = null,
        System.String? MarshaledConfig = null,
        System.Int32? Progress = null,
        System.String? StatusMessage = null
    ) 
    {
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( Vendor != null ) {
            this.Vendor = Vendor;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( JobStartTime != null ) {
            this.JobStartTime = JobStartTime;
        }
        if ( MarshaledConfig != null ) {
            this.MarshaledConfig = MarshaledConfig;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
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
        //      C# -> CcpClusterType? ClusterType
        // GraphQL -> clusterType: CcpClusterType! (enum)
        if (this.ClusterType != null) {
            s += ind + "clusterType\n" ;
        }
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus != null) {
            s += ind + "jobStatus\n" ;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            s += ind + "vendor\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Int64? JobStartTime
        // GraphQL -> jobStartTime: Long! (scalar)
        if (this.JobStartTime != null) {
            s += ind + "jobStartTime\n" ;
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig != null) {
            s += ind + "marshaledConfig\n" ;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            s += ind + "statusMessage\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CcpClusterType? ClusterType
        // GraphQL -> clusterType: CcpClusterType! (enum)
        if (this.ClusterType == null && Exploration.Includes(parent + ".clusterType", true))
        {
            this.ClusterType = new CcpClusterType();
        }
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus == null && Exploration.Includes(parent + ".jobStatus", true))
        {
            this.JobStatus = new CcpJobStatus();
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = new CcpJobType();
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor == null && Exploration.Includes(parent + ".vendor", true))
        {
            this.Vendor = new CcpVendorType();
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Int64? JobStartTime
        // GraphQL -> jobStartTime: Long! (scalar)
        if (this.JobStartTime == null && Exploration.Includes(parent + ".jobStartTime", true))
        {
            this.JobStartTime = new System.Int64();
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig == null && Exploration.Includes(parent + ".marshaledConfig", true))
        {
            this.MarshaledConfig = "FETCH";
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = Int32.MinValue;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage", true))
        {
            this.StatusMessage = "FETCH";
        }
    }


    #endregion

    } // class ClusterMetadata
    
    #endregion

    public static class ListClusterMetadataExtensions
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
            this List<ClusterMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types