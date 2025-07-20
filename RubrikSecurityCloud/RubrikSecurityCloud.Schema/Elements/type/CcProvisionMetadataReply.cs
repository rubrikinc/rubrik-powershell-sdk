// CcProvisionMetadataReply.cs
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
    #region CcProvisionMetadataReply
    public class CcProvisionMetadataReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterOpsCdmJobId
        // GraphQL -> clusterOpsCdmJobId: String! (scalar)
        [JsonProperty("clusterOpsCdmJobId")]
        public System.String? ClusterOpsCdmJobId { get; set; }

        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        [JsonProperty("clusterType")]
        public System.String? ClusterType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        [JsonProperty("internalTimestamp")]
        public System.Int64? InternalTimestamp { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> System.String? MarshaledConfig
        // GraphQL -> marshaledConfig: String! (scalar)
        [JsonProperty("marshaledConfig")]
        public System.String? MarshaledConfig { get; set; }

        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        [JsonProperty("nodeToReplace")]
        public System.String? NodeToReplace { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        [JsonProperty("tprRequestId")]
        public System.String? TprRequestId { get; set; }

        //      C# -> System.String? Vendor
        // GraphQL -> vendor: String! (scalar)
        [JsonProperty("vendor")]
        public System.String? Vendor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CcProvisionMetadataReply";
    }

    public CcProvisionMetadataReply Set(
        System.String? ClusterName = null,
        System.String? ClusterOpsCdmJobId = null,
        System.String? ClusterType = null,
        System.String? ClusterUuid = null,
        System.Int64? InternalTimestamp = null,
        System.String? JobType = null,
        System.String? MarshaledConfig = null,
        System.String? NodeToReplace = null,
        System.Int32? Progress = null,
        System.String? Status = null,
        System.String? StatusMessage = null,
        System.String? TprRequestId = null,
        System.String? Vendor = null
    ) 
    {
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterOpsCdmJobId != null ) {
            this.ClusterOpsCdmJobId = ClusterOpsCdmJobId;
        }
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( InternalTimestamp != null ) {
            this.InternalTimestamp = InternalTimestamp;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( MarshaledConfig != null ) {
            this.MarshaledConfig = MarshaledConfig;
        }
        if ( NodeToReplace != null ) {
            this.NodeToReplace = NodeToReplace;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( TprRequestId != null ) {
            this.TprRequestId = TprRequestId;
        }
        if ( Vendor != null ) {
            this.Vendor = Vendor;
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterOpsCdmJobId
        // GraphQL -> clusterOpsCdmJobId: String! (scalar)
        if (this.ClusterOpsCdmJobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterOpsCdmJobId\n" ;
            } else {
                s += ind + "clusterOpsCdmJobId\n" ;
            }
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (this.ClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterType\n" ;
            } else {
                s += ind + "clusterType\n" ;
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
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "internalTimestamp\n" ;
            } else {
                s += ind + "internalTimestamp\n" ;
            }
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobType\n" ;
            } else {
                s += ind + "jobType\n" ;
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
        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        if (this.NodeToReplace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeToReplace\n" ;
            } else {
                s += ind + "nodeToReplace\n" ;
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        if (this.TprRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tprRequestId\n" ;
            } else {
                s += ind + "tprRequestId\n" ;
            }
        }
        //      C# -> System.String? Vendor
        // GraphQL -> vendor: String! (scalar)
        if (this.Vendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendor\n" ;
            } else {
                s += ind + "vendor\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? ClusterOpsCdmJobId
        // GraphQL -> clusterOpsCdmJobId: String! (scalar)
        if (ec.Includes("clusterOpsCdmJobId",true))
        {
            if(this.ClusterOpsCdmJobId == null) {

                this.ClusterOpsCdmJobId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterOpsCdmJobId != null && ec.Excludes("clusterOpsCdmJobId",true))
        {
            this.ClusterOpsCdmJobId = null;
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (ec.Includes("clusterType",true))
        {
            if(this.ClusterType == null) {

                this.ClusterType = "FETCH";

            } else {


            }
        }
        else if (this.ClusterType != null && ec.Excludes("clusterType",true))
        {
            this.ClusterType = null;
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
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (ec.Includes("internalTimestamp",true))
        {
            if(this.InternalTimestamp == null) {

                this.InternalTimestamp = new System.Int64();

            } else {


            }
        }
        else if (this.InternalTimestamp != null && ec.Excludes("internalTimestamp",true))
        {
            this.InternalTimestamp = null;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (ec.Includes("jobType",true))
        {
            if(this.JobType == null) {

                this.JobType = "FETCH";

            } else {


            }
        }
        else if (this.JobType != null && ec.Excludes("jobType",true))
        {
            this.JobType = null;
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
        //      C# -> System.String? NodeToReplace
        // GraphQL -> nodeToReplace: String! (scalar)
        if (ec.Includes("nodeToReplace",true))
        {
            if(this.NodeToReplace == null) {

                this.NodeToReplace = "FETCH";

            } else {


            }
        }
        else if (this.NodeToReplace != null && ec.Excludes("nodeToReplace",true))
        {
            this.NodeToReplace = null;
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
        //      C# -> System.String? TprRequestId
        // GraphQL -> tprRequestId: String! (scalar)
        if (ec.Includes("tprRequestId",true))
        {
            if(this.TprRequestId == null) {

                this.TprRequestId = "FETCH";

            } else {


            }
        }
        else if (this.TprRequestId != null && ec.Excludes("tprRequestId",true))
        {
            this.TprRequestId = null;
        }
        //      C# -> System.String? Vendor
        // GraphQL -> vendor: String! (scalar)
        if (ec.Includes("vendor",true))
        {
            if(this.Vendor == null) {

                this.Vendor = "FETCH";

            } else {


            }
        }
        else if (this.Vendor != null && ec.Excludes("vendor",true))
        {
            this.Vendor = null;
        }
    }


    #endregion

    } // class CcProvisionMetadataReply
    
    #endregion

    public static class ListCcProvisionMetadataReplyExtensions
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
            this List<CcProvisionMetadataReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CcProvisionMetadataReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CcProvisionMetadataReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CcProvisionMetadataReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CcProvisionMetadataReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types