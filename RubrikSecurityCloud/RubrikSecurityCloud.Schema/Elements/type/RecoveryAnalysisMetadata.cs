// RecoveryAnalysisMetadata.cs
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
    #region RecoveryAnalysisMetadata
    public class RecoveryAnalysisMetadata: BaseType
    {
        #region members

        //      C# -> List<O365MvbWorkloadType>? Workloads
        // GraphQL -> workloads: [O365MvbWorkloadType!]! (enum)
        [JsonProperty("workloads")]
        public List<O365MvbWorkloadType>? Workloads { get; set; }

        //      C# -> System.Int64? AnalysisEndTime
        // GraphQL -> analysisEndTime: Long! (scalar)
        [JsonProperty("analysisEndTime")]
        public System.Int64? AnalysisEndTime { get; set; }

        //      C# -> System.Int64? AnalysisIntervalDays
        // GraphQL -> analysisIntervalDays: Long! (scalar)
        [JsonProperty("analysisIntervalDays")]
        public System.Int64? AnalysisIntervalDays { get; set; }

        //      C# -> System.Int64? AnalysisStartTime
        // GraphQL -> analysisStartTime: Long! (scalar)
        [JsonProperty("analysisStartTime")]
        public System.Int64? AnalysisStartTime { get; set; }

        //      C# -> System.String? ExchangeBlobPath
        // GraphQL -> exchangeBlobPath: String! (scalar)
        [JsonProperty("exchangeBlobPath")]
        public System.String? ExchangeBlobPath { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? OnedriveBlobPath
        // GraphQL -> onedriveBlobPath: String! (scalar)
        [JsonProperty("onedriveBlobPath")]
        public System.String? OnedriveBlobPath { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? SharepointBlobPath
        // GraphQL -> sharepointBlobPath: String! (scalar)
        [JsonProperty("sharepointBlobPath")]
        public System.String? SharepointBlobPath { get; set; }

        //      C# -> System.Boolean? ShouldExcludeArchivedMailbox
        // GraphQL -> shouldExcludeArchivedMailbox: Boolean! (scalar)
        [JsonProperty("shouldExcludeArchivedMailbox")]
        public System.Boolean? ShouldExcludeArchivedMailbox { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryAnalysisMetadata";
    }

    public RecoveryAnalysisMetadata Set(
        List<O365MvbWorkloadType>? Workloads = null,
        System.Int64? AnalysisEndTime = null,
        System.Int64? AnalysisIntervalDays = null,
        System.Int64? AnalysisStartTime = null,
        System.String? ExchangeBlobPath = null,
        System.String? GroupId = null,
        System.String? OnedriveBlobPath = null,
        System.String? OrgId = null,
        System.String? SharepointBlobPath = null,
        System.Boolean? ShouldExcludeArchivedMailbox = null,
        DateTime? SnapshotTime = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( Workloads != null ) {
            this.Workloads = Workloads;
        }
        if ( AnalysisEndTime != null ) {
            this.AnalysisEndTime = AnalysisEndTime;
        }
        if ( AnalysisIntervalDays != null ) {
            this.AnalysisIntervalDays = AnalysisIntervalDays;
        }
        if ( AnalysisStartTime != null ) {
            this.AnalysisStartTime = AnalysisStartTime;
        }
        if ( ExchangeBlobPath != null ) {
            this.ExchangeBlobPath = ExchangeBlobPath;
        }
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( OnedriveBlobPath != null ) {
            this.OnedriveBlobPath = OnedriveBlobPath;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( SharepointBlobPath != null ) {
            this.SharepointBlobPath = SharepointBlobPath;
        }
        if ( ShouldExcludeArchivedMailbox != null ) {
            this.ShouldExcludeArchivedMailbox = ShouldExcludeArchivedMailbox;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
        //      C# -> List<O365MvbWorkloadType>? Workloads
        // GraphQL -> workloads: [O365MvbWorkloadType!]! (enum)
        if (this.Workloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloads\n" ;
            } else {
                s += ind + "workloads\n" ;
            }
        }
        //      C# -> System.Int64? AnalysisEndTime
        // GraphQL -> analysisEndTime: Long! (scalar)
        if (this.AnalysisEndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisEndTime\n" ;
            } else {
                s += ind + "analysisEndTime\n" ;
            }
        }
        //      C# -> System.Int64? AnalysisIntervalDays
        // GraphQL -> analysisIntervalDays: Long! (scalar)
        if (this.AnalysisIntervalDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisIntervalDays\n" ;
            } else {
                s += ind + "analysisIntervalDays\n" ;
            }
        }
        //      C# -> System.Int64? AnalysisStartTime
        // GraphQL -> analysisStartTime: Long! (scalar)
        if (this.AnalysisStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisStartTime\n" ;
            } else {
                s += ind + "analysisStartTime\n" ;
            }
        }
        //      C# -> System.String? ExchangeBlobPath
        // GraphQL -> exchangeBlobPath: String! (scalar)
        if (this.ExchangeBlobPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exchangeBlobPath\n" ;
            } else {
                s += ind + "exchangeBlobPath\n" ;
            }
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (this.GroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupId\n" ;
            } else {
                s += ind + "groupId\n" ;
            }
        }
        //      C# -> System.String? OnedriveBlobPath
        // GraphQL -> onedriveBlobPath: String! (scalar)
        if (this.OnedriveBlobPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onedriveBlobPath\n" ;
            } else {
                s += ind + "onedriveBlobPath\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? SharepointBlobPath
        // GraphQL -> sharepointBlobPath: String! (scalar)
        if (this.SharepointBlobPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharepointBlobPath\n" ;
            } else {
                s += ind + "sharepointBlobPath\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldExcludeArchivedMailbox
        // GraphQL -> shouldExcludeArchivedMailbox: Boolean! (scalar)
        if (this.ShouldExcludeArchivedMailbox != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldExcludeArchivedMailbox\n" ;
            } else {
                s += ind + "shouldExcludeArchivedMailbox\n" ;
            }
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (this.TaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainId\n" ;
            } else {
                s += ind + "taskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<O365MvbWorkloadType>? Workloads
        // GraphQL -> workloads: [O365MvbWorkloadType!]! (enum)
        if (ec.Includes("workloads",true))
        {
            if(this.Workloads == null) {

                this.Workloads = new List<O365MvbWorkloadType>();

            } else {


            }
        }
        else if (this.Workloads != null && ec.Excludes("workloads",true))
        {
            this.Workloads = null;
        }
        //      C# -> System.Int64? AnalysisEndTime
        // GraphQL -> analysisEndTime: Long! (scalar)
        if (ec.Includes("analysisEndTime",true))
        {
            if(this.AnalysisEndTime == null) {

                this.AnalysisEndTime = new System.Int64();

            } else {


            }
        }
        else if (this.AnalysisEndTime != null && ec.Excludes("analysisEndTime",true))
        {
            this.AnalysisEndTime = null;
        }
        //      C# -> System.Int64? AnalysisIntervalDays
        // GraphQL -> analysisIntervalDays: Long! (scalar)
        if (ec.Includes("analysisIntervalDays",true))
        {
            if(this.AnalysisIntervalDays == null) {

                this.AnalysisIntervalDays = new System.Int64();

            } else {


            }
        }
        else if (this.AnalysisIntervalDays != null && ec.Excludes("analysisIntervalDays",true))
        {
            this.AnalysisIntervalDays = null;
        }
        //      C# -> System.Int64? AnalysisStartTime
        // GraphQL -> analysisStartTime: Long! (scalar)
        if (ec.Includes("analysisStartTime",true))
        {
            if(this.AnalysisStartTime == null) {

                this.AnalysisStartTime = new System.Int64();

            } else {


            }
        }
        else if (this.AnalysisStartTime != null && ec.Excludes("analysisStartTime",true))
        {
            this.AnalysisStartTime = null;
        }
        //      C# -> System.String? ExchangeBlobPath
        // GraphQL -> exchangeBlobPath: String! (scalar)
        if (ec.Includes("exchangeBlobPath",true))
        {
            if(this.ExchangeBlobPath == null) {

                this.ExchangeBlobPath = "FETCH";

            } else {


            }
        }
        else if (this.ExchangeBlobPath != null && ec.Excludes("exchangeBlobPath",true))
        {
            this.ExchangeBlobPath = null;
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        if (ec.Includes("groupId",true))
        {
            if(this.GroupId == null) {

                this.GroupId = "FETCH";

            } else {


            }
        }
        else if (this.GroupId != null && ec.Excludes("groupId",true))
        {
            this.GroupId = null;
        }
        //      C# -> System.String? OnedriveBlobPath
        // GraphQL -> onedriveBlobPath: String! (scalar)
        if (ec.Includes("onedriveBlobPath",true))
        {
            if(this.OnedriveBlobPath == null) {

                this.OnedriveBlobPath = "FETCH";

            } else {


            }
        }
        else if (this.OnedriveBlobPath != null && ec.Excludes("onedriveBlobPath",true))
        {
            this.OnedriveBlobPath = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? SharepointBlobPath
        // GraphQL -> sharepointBlobPath: String! (scalar)
        if (ec.Includes("sharepointBlobPath",true))
        {
            if(this.SharepointBlobPath == null) {

                this.SharepointBlobPath = "FETCH";

            } else {


            }
        }
        else if (this.SharepointBlobPath != null && ec.Excludes("sharepointBlobPath",true))
        {
            this.SharepointBlobPath = null;
        }
        //      C# -> System.Boolean? ShouldExcludeArchivedMailbox
        // GraphQL -> shouldExcludeArchivedMailbox: Boolean! (scalar)
        if (ec.Includes("shouldExcludeArchivedMailbox",true))
        {
            if(this.ShouldExcludeArchivedMailbox == null) {

                this.ShouldExcludeArchivedMailbox = true;

            } else {


            }
        }
        else if (this.ShouldExcludeArchivedMailbox != null && ec.Excludes("shouldExcludeArchivedMailbox",true))
        {
            this.ShouldExcludeArchivedMailbox = null;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: UUID! (scalar)
        if (ec.Includes("taskchainId",true))
        {
            if(this.TaskchainId == null) {

                this.TaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainId != null && ec.Excludes("taskchainId",true))
        {
            this.TaskchainId = null;
        }
    }


    #endregion

    } // class RecoveryAnalysisMetadata
    
    #endregion

    public static class ListRecoveryAnalysisMetadataExtensions
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
            this List<RecoveryAnalysisMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryAnalysisMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryAnalysisMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryAnalysisMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryAnalysisMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types