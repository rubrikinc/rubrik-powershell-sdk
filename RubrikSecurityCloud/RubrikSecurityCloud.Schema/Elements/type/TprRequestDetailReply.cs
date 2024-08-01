// TprRequestDetailReply.cs
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
    #region TprRequestDetailReply
    public class TprRequestDetailReply: BaseType
    {
        #region members

        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        [JsonProperty("executionType")]
        public TprExecutionType? ExecutionType { get; set; }

        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        [JsonProperty("status")]
        public TprReqStatus? Status { get; set; }

        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        [JsonProperty("triggeredTprRule")]
        public TprRule? TriggeredTprRule { get; set; }

        //      C# -> List<TprRule>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [TprRule!]! (enum)
        [JsonProperty("triggeredTprRules")]
        public List<TprRule>? TriggeredTprRules { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> DateTime? ExecutionExpiresAt
        // GraphQL -> executionExpiresAt: DateTime (scalar)
        [JsonProperty("executionExpiresAt")]
        public DateTime? ExecutionExpiresAt { get; set; }

        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        [JsonProperty("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        [JsonProperty("details")]
        public TprRequestDetail? Details { get; set; }

        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        [JsonProperty("operations")]
        public AuthorizedOps? Operations { get; set; }

        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary (type)
        [JsonProperty("requester")]
        public UserSummary? Requester { get; set; }

        //      C# -> List<TprReqStatusChange>? StatusLog
        // GraphQL -> statusLog: [TprReqStatusChange!]! (type)
        [JsonProperty("statusLog")]
        public List<TprReqStatusChange>? StatusLog { get; set; }

        //      C# -> List<TriggeredTprPolicy>? TriggeredTprPolicies
        // GraphQL -> triggeredTprPolicies: [TriggeredTprPolicy!]! (type)
        [JsonProperty("triggeredTprPolicies")]
        public List<TriggeredTprPolicy>? TriggeredTprPolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestDetailReply";
    }

    public TprRequestDetailReply Set(
        TprExecutionType? ExecutionType = null,
        TprReqStatus? Status = null,
        TprRule? TriggeredTprRule = null,
        List<TprRule>? TriggeredTprRules = null,
        DateTime? CreatedAt = null,
        DateTime? ExecutionExpiresAt = null,
        DateTime? ExpiresAt = null,
        System.String? Id = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        DateTime? UpdatedAt = null,
        TprRequestDetail? Details = null,
        AuthorizedOps? Operations = null,
        UserSummary? Requester = null,
        List<TprReqStatusChange>? StatusLog = null,
        List<TriggeredTprPolicy>? TriggeredTprPolicies = null
    ) 
    {
        if ( ExecutionType != null ) {
            this.ExecutionType = ExecutionType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TriggeredTprRule != null ) {
            this.TriggeredTprRule = TriggeredTprRule;
        }
        if ( TriggeredTprRules != null ) {
            this.TriggeredTprRules = TriggeredTprRules;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( ExecutionExpiresAt != null ) {
            this.ExecutionExpiresAt = ExecutionExpiresAt;
        }
        if ( ExpiresAt != null ) {
            this.ExpiresAt = ExpiresAt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( Details != null ) {
            this.Details = Details;
        }
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( Requester != null ) {
            this.Requester = Requester;
        }
        if ( StatusLog != null ) {
            this.StatusLog = StatusLog;
        }
        if ( TriggeredTprPolicies != null ) {
            this.TriggeredTprPolicies = TriggeredTprPolicies;
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
        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        if (this.ExecutionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "executionType\n" ;
            } else {
                s += ind + "executionType\n" ;
            }
        }
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (this.TriggeredTprRule != null) {
            if (conf.Flat) {
                s += conf.Prefix + "triggeredTprRule\n" ;
            } else {
                s += ind + "triggeredTprRule\n" ;
            }
        }
        //      C# -> List<TprRule>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [TprRule!]! (enum)
        if (this.TriggeredTprRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "triggeredTprRules\n" ;
            } else {
                s += ind + "triggeredTprRules\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> DateTime? ExecutionExpiresAt
        // GraphQL -> executionExpiresAt: DateTime (scalar)
        if (this.ExecutionExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "executionExpiresAt\n" ;
            } else {
                s += ind + "executionExpiresAt\n" ;
            }
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (this.ExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiresAt\n" ;
            } else {
                s += ind + "expiresAt\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        if (this.Operations != null) {
            var fspec = this.Operations.AsFieldSpec(conf.Child("operations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "operations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary (type)
        if (this.Requester != null) {
            var fspec = this.Requester.AsFieldSpec(conf.Child("requester"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requester" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TprReqStatusChange>? StatusLog
        // GraphQL -> statusLog: [TprReqStatusChange!]! (type)
        if (this.StatusLog != null) {
            var fspec = this.StatusLog.AsFieldSpec(conf.Child("statusLog"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusLog" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TriggeredTprPolicy>? TriggeredTprPolicies
        // GraphQL -> triggeredTprPolicies: [TriggeredTprPolicy!]! (type)
        if (this.TriggeredTprPolicies != null) {
            var fspec = this.TriggeredTprPolicies.AsFieldSpec(conf.Child("triggeredTprPolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "triggeredTprPolicies" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        if (ec.Includes("executionType",true))
        {
            if(this.ExecutionType == null) {

                this.ExecutionType = new TprExecutionType();

            } else {


            }
        }
        else if (this.ExecutionType != null && ec.Excludes("executionType",true))
        {
            this.ExecutionType = null;
        }
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new TprReqStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (ec.Includes("triggeredTprRule",true))
        {
            if(this.TriggeredTprRule == null) {

                this.TriggeredTprRule = new TprRule();

            } else {


            }
        }
        else if (this.TriggeredTprRule != null && ec.Excludes("triggeredTprRule",true))
        {
            this.TriggeredTprRule = null;
        }
        //      C# -> List<TprRule>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [TprRule!]! (enum)
        if (ec.Includes("triggeredTprRules",true))
        {
            if(this.TriggeredTprRules == null) {

                this.TriggeredTprRules = new List<TprRule>();

            } else {


            }
        }
        else if (this.TriggeredTprRules != null && ec.Excludes("triggeredTprRules",true))
        {
            this.TriggeredTprRules = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> DateTime? ExecutionExpiresAt
        // GraphQL -> executionExpiresAt: DateTime (scalar)
        if (ec.Includes("executionExpiresAt",true))
        {
            if(this.ExecutionExpiresAt == null) {

                this.ExecutionExpiresAt = new DateTime();

            } else {


            }
        }
        else if (this.ExecutionExpiresAt != null && ec.Excludes("executionExpiresAt",true))
        {
            this.ExecutionExpiresAt = null;
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (ec.Includes("expiresAt",true))
        {
            if(this.ExpiresAt == null) {

                this.ExpiresAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpiresAt != null && ec.Excludes("expiresAt",true))
        {
            this.ExpiresAt = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                this.Details = new TprRequestDetail();
                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            } else {

                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
        //      C# -> AuthorizedOps? Operations
        // GraphQL -> operations: AuthorizedOps! (type)
        if (ec.Includes("operations",false))
        {
            if(this.Operations == null) {

                this.Operations = new AuthorizedOps();
                this.Operations.ApplyExploratoryFieldSpec(ec.NewChild("operations"));

            } else {

                this.Operations.ApplyExploratoryFieldSpec(ec.NewChild("operations"));

            }
        }
        else if (this.Operations != null && ec.Excludes("operations",false))
        {
            this.Operations = null;
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary (type)
        if (ec.Includes("requester",false))
        {
            if(this.Requester == null) {

                this.Requester = new UserSummary();
                this.Requester.ApplyExploratoryFieldSpec(ec.NewChild("requester"));

            } else {

                this.Requester.ApplyExploratoryFieldSpec(ec.NewChild("requester"));

            }
        }
        else if (this.Requester != null && ec.Excludes("requester",false))
        {
            this.Requester = null;
        }
        //      C# -> List<TprReqStatusChange>? StatusLog
        // GraphQL -> statusLog: [TprReqStatusChange!]! (type)
        if (ec.Includes("statusLog",false))
        {
            if(this.StatusLog == null) {

                this.StatusLog = new List<TprReqStatusChange>();
                this.StatusLog.ApplyExploratoryFieldSpec(ec.NewChild("statusLog"));

            } else {

                this.StatusLog.ApplyExploratoryFieldSpec(ec.NewChild("statusLog"));

            }
        }
        else if (this.StatusLog != null && ec.Excludes("statusLog",false))
        {
            this.StatusLog = null;
        }
        //      C# -> List<TriggeredTprPolicy>? TriggeredTprPolicies
        // GraphQL -> triggeredTprPolicies: [TriggeredTprPolicy!]! (type)
        if (ec.Includes("triggeredTprPolicies",false))
        {
            if(this.TriggeredTprPolicies == null) {

                this.TriggeredTprPolicies = new List<TriggeredTprPolicy>();
                this.TriggeredTprPolicies.ApplyExploratoryFieldSpec(ec.NewChild("triggeredTprPolicies"));

            } else {

                this.TriggeredTprPolicies.ApplyExploratoryFieldSpec(ec.NewChild("triggeredTprPolicies"));

            }
        }
        else if (this.TriggeredTprPolicies != null && ec.Excludes("triggeredTprPolicies",false))
        {
            this.TriggeredTprPolicies = null;
        }
    }


    #endregion

    } // class TprRequestDetailReply
    
    #endregion

    public static class ListTprRequestDetailReplyExtensions
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
            this List<TprRequestDetailReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestDetailReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestDetailReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestDetailReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestDetailReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types