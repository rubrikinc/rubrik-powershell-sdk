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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ClusterMetadata";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CcpClusterType? ClusterType
        // GraphQL -> clusterType: CcpClusterType! (enum)
        if (this.ClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterType\n" ;
            } else {
                s += ind + "clusterType\n" ;
            }
        }
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (this.JobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobStatus\n" ;
            } else {
                s += ind + "jobStatus\n" ;
            }
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobType\n" ;
            } else {
                s += ind + "jobType\n" ;
            }
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendor\n" ;
            } else {
                s += ind + "vendor\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Int64? JobStartTime
        // GraphQL -> jobStartTime: Long! (scalar)
        if (this.JobStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobStartTime\n" ;
            } else {
                s += ind + "jobStartTime\n" ;
            }
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (this.MarshaledConfig != null) {
            if (conf.Flat) {
                s += conf.Prefix + "marshaledConfig\n" ;
            } else {
                s += ind + "marshaledConfig\n" ;
            }
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CcpClusterType? ClusterType
        // GraphQL -> clusterType: CcpClusterType! (enum)
        if (ec.Includes("clusterType",true))
        {
            if(this.ClusterType == null) {

                this.ClusterType = new CcpClusterType();

            } else {


            }
        }
        else if (this.ClusterType != null && ec.Excludes("clusterType",true))
        {
            this.ClusterType = null;
        }
        //      C# -> CcpJobStatus? JobStatus
        // GraphQL -> jobStatus: CcpJobStatus! (enum)
        if (ec.Includes("jobStatus",true))
        {
            if(this.JobStatus == null) {

                this.JobStatus = new CcpJobStatus();

            } else {


            }
        }
        else if (this.JobStatus != null && ec.Excludes("jobStatus",true))
        {
            this.JobStatus = null;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (ec.Includes("jobType",true))
        {
            if(this.JobType == null) {

                this.JobType = new CcpJobType();

            } else {


            }
        }
        else if (this.JobType != null && ec.Excludes("jobType",true))
        {
            this.JobType = null;
        }
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (ec.Includes("vendor",true))
        {
            if(this.Vendor == null) {

                this.Vendor = new CcpVendorType();

            } else {


            }
        }
        else if (this.Vendor != null && ec.Excludes("vendor",true))
        {
            this.Vendor = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Int64? JobStartTime
        // GraphQL -> jobStartTime: Long! (scalar)
        if (ec.Includes("jobStartTime",true))
        {
            if(this.JobStartTime == null) {

                this.JobStartTime = new System.Int64();

            } else {


            }
        }
        else if (this.JobStartTime != null && ec.Excludes("jobStartTime",true))
        {
            this.JobStartTime = null;
        }
        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        if (ec.Includes("marshaledConfig",true))
        {
            if(this.MarshaledConfig == null) {

                this.MarshaledConfig = "FETCH";

            } else {


            }
        }
        else if (this.MarshaledConfig != null && ec.Excludes("marshaledConfig",true))
        {
            this.MarshaledConfig = null;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = Int32.MinValue;

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
    }


    #endregion

    } // class ClusterMetadata
    
    #endregion

    public static class ListClusterMetadataExtensions
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
            this List<ClusterMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types