// CloudNativeApplication.cs
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
    #region CloudNativeApplication
    public class CloudNativeApplication: BaseType
    {
        #region members

        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        [JsonProperty("cloudType")]
        public CloudServiceProvider? CloudType { get; set; }

        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        [JsonProperty("protectionStatus")]
        public CloudNativeProtectionStatus? ProtectionStatus { get; set; }

        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        [JsonProperty("refreshStatus")]
        public CloudNativeApplicationRefreshStatus? RefreshStatus { get; set; }

        //      C# -> System.Int64? AutoId
        // GraphQL -> autoId: Long! (scalar)
        [JsonProperty("autoId")]
        public System.Int64? AutoId { get; set; }

        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: UUID! (scalar)
        [JsonProperty("cloudNativeAccountId")]
        public System.String? CloudNativeAccountId { get; set; }

        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        [JsonProperty("cloudNativeAccountName")]
        public System.String? CloudNativeAccountName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastRefreshAt
        // GraphQL -> lastRefreshAt: DateTime (scalar)
        [JsonProperty("lastRefreshAt")]
        public DateTime? LastRefreshAt { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? PostRecoveryScriptConfigured
        // GraphQL -> postRecoveryScriptConfigured: Boolean! (scalar)
        [JsonProperty("postRecoveryScriptConfigured")]
        public System.Boolean? PostRecoveryScriptConfigured { get; set; }

        //      C# -> List<System.String>? ResourceExclusionList
        // GraphQL -> resourceExclusionList: [String!]! (scalar)
        [JsonProperty("resourceExclusionList")]
        public List<System.String>? ResourceExclusionList { get; set; }

        //      C# -> List<System.String>? ResourceInclusionList
        // GraphQL -> resourceInclusionList: [String!]! (scalar)
        [JsonProperty("resourceInclusionList")]
        public List<System.String>? ResourceInclusionList { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        [JsonProperty("targetCloudNativeAccountId")]
        public System.String? TargetCloudNativeAccountId { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> MatchingTags? MatchingTags
        // GraphQL -> matchingTags: MatchingTags! (type)
        [JsonProperty("matchingTags")]
        public MatchingTags? MatchingTags { get; set; }

        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion! (type)
        [JsonProperty("region")]
        public CloudRegion? Region { get; set; }

        //      C# -> ApplicationServiceConfiguration? ServiceConfigured
        // GraphQL -> serviceConfigured: ApplicationServiceConfiguration! (type)
        [JsonProperty("serviceConfigured")]
        public ApplicationServiceConfiguration? ServiceConfigured { get; set; }

        //      C# -> TargetCloudAccountInfo? TargetCloudAccountInfo
        // GraphQL -> targetCloudAccountInfo: TargetCloudAccountInfo (type)
        [JsonProperty("targetCloudAccountInfo")]
        public TargetCloudAccountInfo? TargetCloudAccountInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeApplication";
    }

    public CloudNativeApplication Set(
        CloudServiceProvider? CloudType = null,
        CloudNativeProtectionStatus? ProtectionStatus = null,
        CloudNativeApplicationRefreshStatus? RefreshStatus = null,
        System.Int64? AutoId = null,
        System.String? CloudNativeAccountId = null,
        System.String? CloudNativeAccountName = null,
        System.String? Id = null,
        DateTime? LastRefreshAt = null,
        System.String? Name = null,
        System.Boolean? PostRecoveryScriptConfigured = null,
        List<System.String>? ResourceExclusionList = null,
        List<System.String>? ResourceInclusionList = null,
        System.String? State = null,
        System.String? TargetCloudNativeAccountId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        MatchingTags? MatchingTags = null,
        CloudRegion? Region = null,
        ApplicationServiceConfiguration? ServiceConfigured = null,
        TargetCloudAccountInfo? TargetCloudAccountInfo = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( RefreshStatus != null ) {
            this.RefreshStatus = RefreshStatus;
        }
        if ( AutoId != null ) {
            this.AutoId = AutoId;
        }
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( CloudNativeAccountName != null ) {
            this.CloudNativeAccountName = CloudNativeAccountName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastRefreshAt != null ) {
            this.LastRefreshAt = LastRefreshAt;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PostRecoveryScriptConfigured != null ) {
            this.PostRecoveryScriptConfigured = PostRecoveryScriptConfigured;
        }
        if ( ResourceExclusionList != null ) {
            this.ResourceExclusionList = ResourceExclusionList;
        }
        if ( ResourceInclusionList != null ) {
            this.ResourceInclusionList = ResourceInclusionList;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( TargetCloudNativeAccountId != null ) {
            this.TargetCloudNativeAccountId = TargetCloudNativeAccountId;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( MatchingTags != null ) {
            this.MatchingTags = MatchingTags;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ServiceConfigured != null ) {
            this.ServiceConfigured = ServiceConfigured;
        }
        if ( TargetCloudAccountInfo != null ) {
            this.TargetCloudAccountInfo = TargetCloudAccountInfo;
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
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        if (this.RefreshStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshStatus\n" ;
            } else {
                s += ind + "refreshStatus\n" ;
            }
        }
        //      C# -> System.Int64? AutoId
        // GraphQL -> autoId: Long! (scalar)
        if (this.AutoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoId\n" ;
            } else {
                s += ind + "autoId\n" ;
            }
        }
        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: UUID! (scalar)
        if (this.CloudNativeAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeAccountId\n" ;
            } else {
                s += ind + "cloudNativeAccountId\n" ;
            }
        }
        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        if (this.CloudNativeAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeAccountName\n" ;
            } else {
                s += ind + "cloudNativeAccountName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshAt
        // GraphQL -> lastRefreshAt: DateTime (scalar)
        if (this.LastRefreshAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshAt\n" ;
            } else {
                s += ind + "lastRefreshAt\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Boolean? PostRecoveryScriptConfigured
        // GraphQL -> postRecoveryScriptConfigured: Boolean! (scalar)
        if (this.PostRecoveryScriptConfigured != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postRecoveryScriptConfigured\n" ;
            } else {
                s += ind + "postRecoveryScriptConfigured\n" ;
            }
        }
        //      C# -> List<System.String>? ResourceExclusionList
        // GraphQL -> resourceExclusionList: [String!]! (scalar)
        if (this.ResourceExclusionList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceExclusionList\n" ;
            } else {
                s += ind + "resourceExclusionList\n" ;
            }
        }
        //      C# -> List<System.String>? ResourceInclusionList
        // GraphQL -> resourceInclusionList: [String!]! (scalar)
        if (this.ResourceInclusionList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceInclusionList\n" ;
            } else {
                s += ind + "resourceInclusionList\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        if (this.TargetCloudNativeAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetCloudNativeAccountId\n" ;
            } else {
                s += ind + "targetCloudNativeAccountId\n" ;
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(conf.Child("authorizedOperations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authorizedOperations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MatchingTags? MatchingTags
        // GraphQL -> matchingTags: MatchingTags! (type)
        if (this.MatchingTags != null) {
            var fspec = this.MatchingTags.AsFieldSpec(conf.Child("matchingTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matchingTags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion! (type)
        if (this.Region != null) {
            var fspec = this.Region.AsFieldSpec(conf.Child("region"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "region" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ApplicationServiceConfiguration? ServiceConfigured
        // GraphQL -> serviceConfigured: ApplicationServiceConfiguration! (type)
        if (this.ServiceConfigured != null) {
            var fspec = this.ServiceConfigured.AsFieldSpec(conf.Child("serviceConfigured"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "serviceConfigured" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TargetCloudAccountInfo? TargetCloudAccountInfo
        // GraphQL -> targetCloudAccountInfo: TargetCloudAccountInfo (type)
        if (this.TargetCloudAccountInfo != null) {
            var fspec = this.TargetCloudAccountInfo.AsFieldSpec(conf.Child("targetCloudAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetCloudAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudServiceProvider();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> CloudNativeProtectionStatus? ProtectionStatus
        // GraphQL -> protectionStatus: CloudNativeProtectionStatus! (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new CloudNativeProtectionStatus();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> CloudNativeApplicationRefreshStatus? RefreshStatus
        // GraphQL -> refreshStatus: CloudNativeApplicationRefreshStatus! (enum)
        if (ec.Includes("refreshStatus",true))
        {
            if(this.RefreshStatus == null) {

                this.RefreshStatus = new CloudNativeApplicationRefreshStatus();

            } else {


            }
        }
        else if (this.RefreshStatus != null && ec.Excludes("refreshStatus",true))
        {
            this.RefreshStatus = null;
        }
        //      C# -> System.Int64? AutoId
        // GraphQL -> autoId: Long! (scalar)
        if (ec.Includes("autoId",true))
        {
            if(this.AutoId == null) {

                this.AutoId = new System.Int64();

            } else {


            }
        }
        else if (this.AutoId != null && ec.Excludes("autoId",true))
        {
            this.AutoId = null;
        }
        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: UUID! (scalar)
        if (ec.Includes("cloudNativeAccountId",true))
        {
            if(this.CloudNativeAccountId == null) {

                this.CloudNativeAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudNativeAccountId != null && ec.Excludes("cloudNativeAccountId",true))
        {
            this.CloudNativeAccountId = null;
        }
        //      C# -> System.String? CloudNativeAccountName
        // GraphQL -> cloudNativeAccountName: String! (scalar)
        if (ec.Includes("cloudNativeAccountName",true))
        {
            if(this.CloudNativeAccountName == null) {

                this.CloudNativeAccountName = "FETCH";

            } else {


            }
        }
        else if (this.CloudNativeAccountName != null && ec.Excludes("cloudNativeAccountName",true))
        {
            this.CloudNativeAccountName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DateTime? LastRefreshAt
        // GraphQL -> lastRefreshAt: DateTime (scalar)
        if (ec.Includes("lastRefreshAt",true))
        {
            if(this.LastRefreshAt == null) {

                this.LastRefreshAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshAt != null && ec.Excludes("lastRefreshAt",true))
        {
            this.LastRefreshAt = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Boolean? PostRecoveryScriptConfigured
        // GraphQL -> postRecoveryScriptConfigured: Boolean! (scalar)
        if (ec.Includes("postRecoveryScriptConfigured",true))
        {
            if(this.PostRecoveryScriptConfigured == null) {

                this.PostRecoveryScriptConfigured = true;

            } else {


            }
        }
        else if (this.PostRecoveryScriptConfigured != null && ec.Excludes("postRecoveryScriptConfigured",true))
        {
            this.PostRecoveryScriptConfigured = null;
        }
        //      C# -> List<System.String>? ResourceExclusionList
        // GraphQL -> resourceExclusionList: [String!]! (scalar)
        if (ec.Includes("resourceExclusionList",true))
        {
            if(this.ResourceExclusionList == null) {

                this.ResourceExclusionList = new List<System.String>();

            } else {


            }
        }
        else if (this.ResourceExclusionList != null && ec.Excludes("resourceExclusionList",true))
        {
            this.ResourceExclusionList = null;
        }
        //      C# -> List<System.String>? ResourceInclusionList
        // GraphQL -> resourceInclusionList: [String!]! (scalar)
        if (ec.Includes("resourceInclusionList",true))
        {
            if(this.ResourceInclusionList == null) {

                this.ResourceInclusionList = new List<System.String>();

            } else {


            }
        }
        else if (this.ResourceInclusionList != null && ec.Excludes("resourceInclusionList",true))
        {
            this.ResourceInclusionList = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? TargetCloudNativeAccountId
        // GraphQL -> targetCloudNativeAccountId: UUID! (scalar)
        if (ec.Includes("targetCloudNativeAccountId",true))
        {
            if(this.TargetCloudNativeAccountId == null) {

                this.TargetCloudNativeAccountId = "FETCH";

            } else {


            }
        }
        else if (this.TargetCloudNativeAccountId != null && ec.Excludes("targetCloudNativeAccountId",true))
        {
            this.TargetCloudNativeAccountId = null;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (ec.Includes("authorizedOperations",false))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            } else {

                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",false))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> MatchingTags? MatchingTags
        // GraphQL -> matchingTags: MatchingTags! (type)
        if (ec.Includes("matchingTags",false))
        {
            if(this.MatchingTags == null) {

                this.MatchingTags = new MatchingTags();
                this.MatchingTags.ApplyExploratoryFieldSpec(ec.NewChild("matchingTags"));

            } else {

                this.MatchingTags.ApplyExploratoryFieldSpec(ec.NewChild("matchingTags"));

            }
        }
        else if (this.MatchingTags != null && ec.Excludes("matchingTags",false))
        {
            this.MatchingTags = null;
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion! (type)
        if (ec.Includes("region",false))
        {
            if(this.Region == null) {

                this.Region = new CloudRegion();
                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            } else {

                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            }
        }
        else if (this.Region != null && ec.Excludes("region",false))
        {
            this.Region = null;
        }
        //      C# -> ApplicationServiceConfiguration? ServiceConfigured
        // GraphQL -> serviceConfigured: ApplicationServiceConfiguration! (type)
        if (ec.Includes("serviceConfigured",false))
        {
            if(this.ServiceConfigured == null) {

                this.ServiceConfigured = new ApplicationServiceConfiguration();
                this.ServiceConfigured.ApplyExploratoryFieldSpec(ec.NewChild("serviceConfigured"));

            } else {

                this.ServiceConfigured.ApplyExploratoryFieldSpec(ec.NewChild("serviceConfigured"));

            }
        }
        else if (this.ServiceConfigured != null && ec.Excludes("serviceConfigured",false))
        {
            this.ServiceConfigured = null;
        }
        //      C# -> TargetCloudAccountInfo? TargetCloudAccountInfo
        // GraphQL -> targetCloudAccountInfo: TargetCloudAccountInfo (type)
        if (ec.Includes("targetCloudAccountInfo",false))
        {
            if(this.TargetCloudAccountInfo == null) {

                this.TargetCloudAccountInfo = new TargetCloudAccountInfo();
                this.TargetCloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetCloudAccountInfo"));

            } else {

                this.TargetCloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetCloudAccountInfo"));

            }
        }
        else if (this.TargetCloudAccountInfo != null && ec.Excludes("targetCloudAccountInfo",false))
        {
            this.TargetCloudAccountInfo = null;
        }
    }


    #endregion

    } // class CloudNativeApplication
    
    #endregion

    public static class ListCloudNativeApplicationExtensions
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
            this List<CloudNativeApplication> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeApplication> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeApplication> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeApplication());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeApplication> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types