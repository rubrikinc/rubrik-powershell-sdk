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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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

        //      C# -> System.String? TriggeredTprRule
        // GraphQL -> triggeredTprRule: String! (scalar)
        [JsonProperty("triggeredTprRule")]
        public System.String? TriggeredTprRule { get; set; }

        //      C# -> List<System.String>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [String!]! (scalar)
        [JsonProperty("triggeredTprRules")]
        public List<System.String>? TriggeredTprRules { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        [JsonProperty("details")]
        public TprRequestDetail? Details { get; set; }

        //      C# -> TprRequester? Requester
        // GraphQL -> requester: TprRequester (type)
        [JsonProperty("requester")]
        public TprRequester? Requester { get; set; }

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

    public TprRequestDetailReply Set(
        TprExecutionType? ExecutionType = null,
        TprReqStatus? Status = null,
        DateTime? CreatedAt = null,
        DateTime? ExecutionExpiresAt = null,
        DateTime? ExpiresAt = null,
        System.String? Id = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? TriggeredTprRule = null,
        List<System.String>? TriggeredTprRules = null,
        DateTime? UpdatedAt = null,
        TprRequestDetail? Details = null,
        TprRequester? Requester = null,
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
        if ( TriggeredTprRule != null ) {
            this.TriggeredTprRule = TriggeredTprRule;
        }
        if ( TriggeredTprRules != null ) {
            this.TriggeredTprRules = TriggeredTprRules;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( Details != null ) {
            this.Details = Details;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        if (this.ExecutionType != null) {
            s += ind + "executionType\n" ;
        }
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> DateTime? ExecutionExpiresAt
        // GraphQL -> executionExpiresAt: DateTime (scalar)
        if (this.ExecutionExpiresAt != null) {
            s += ind + "executionExpiresAt\n" ;
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (this.ExpiresAt != null) {
            s += ind + "expiresAt\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> System.String? TriggeredTprRule
        // GraphQL -> triggeredTprRule: String! (scalar)
        if (this.TriggeredTprRule != null) {
            s += ind + "triggeredTprRule\n" ;
        }
        //      C# -> List<System.String>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [String!]! (scalar)
        if (this.TriggeredTprRules != null) {
            s += ind + "triggeredTprRules\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        if (this.Details != null) {
            s += ind + "details {\n" + this.Details.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> TprRequester? Requester
        // GraphQL -> requester: TprRequester (type)
        if (this.Requester != null) {
            s += ind + "requester {\n" + this.Requester.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<TprReqStatusChange>? StatusLog
        // GraphQL -> statusLog: [TprReqStatusChange!]! (type)
        if (this.StatusLog != null) {
            s += ind + "statusLog {\n" + this.StatusLog.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<TriggeredTprPolicy>? TriggeredTprPolicies
        // GraphQL -> triggeredTprPolicies: [TriggeredTprPolicy!]! (type)
        if (this.TriggeredTprPolicies != null) {
            s += ind + "triggeredTprPolicies {\n" + this.TriggeredTprPolicies.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        if (this.ExecutionType == null && Exploration.Includes(parent + ".executionType", true))
        {
            this.ExecutionType = new TprExecutionType();
        }
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new TprReqStatus();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> DateTime? ExecutionExpiresAt
        // GraphQL -> executionExpiresAt: DateTime (scalar)
        if (this.ExecutionExpiresAt == null && Exploration.Includes(parent + ".executionExpiresAt", true))
        {
            this.ExecutionExpiresAt = new DateTime();
        }
        //      C# -> DateTime? ExpiresAt
        // GraphQL -> expiresAt: DateTime (scalar)
        if (this.ExpiresAt == null && Exploration.Includes(parent + ".expiresAt", true))
        {
            this.ExpiresAt = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = new System.String("FETCH");
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName == null && Exploration.Includes(parent + ".orgName", true))
        {
            this.OrgName = new System.String("FETCH");
        }
        //      C# -> System.String? TriggeredTprRule
        // GraphQL -> triggeredTprRule: String! (scalar)
        if (this.TriggeredTprRule == null && Exploration.Includes(parent + ".triggeredTprRule", true))
        {
            this.TriggeredTprRule = new System.String("FETCH");
        }
        //      C# -> List<System.String>? TriggeredTprRules
        // GraphQL -> triggeredTprRules: [String!]! (scalar)
        if (this.TriggeredTprRules == null && Exploration.Includes(parent + ".triggeredTprRules", true))
        {
            this.TriggeredTprRules = new List<System.String>();
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> TprRequestDetail? Details
        // GraphQL -> details: TprRequestDetail (type)
        if (this.Details == null && Exploration.Includes(parent + ".details"))
        {
            this.Details = new TprRequestDetail();
            this.Details.ApplyExploratoryFieldSpec(parent + ".details");
        }
        //      C# -> TprRequester? Requester
        // GraphQL -> requester: TprRequester (type)
        if (this.Requester == null && Exploration.Includes(parent + ".requester"))
        {
            this.Requester = new TprRequester();
            this.Requester.ApplyExploratoryFieldSpec(parent + ".requester");
        }
        //      C# -> List<TprReqStatusChange>? StatusLog
        // GraphQL -> statusLog: [TprReqStatusChange!]! (type)
        if (this.StatusLog == null && Exploration.Includes(parent + ".statusLog"))
        {
            this.StatusLog = new List<TprReqStatusChange>();
            this.StatusLog.ApplyExploratoryFieldSpec(parent + ".statusLog");
        }
        //      C# -> List<TriggeredTprPolicy>? TriggeredTprPolicies
        // GraphQL -> triggeredTprPolicies: [TriggeredTprPolicy!]! (type)
        if (this.TriggeredTprPolicies == null && Exploration.Includes(parent + ".triggeredTprPolicies"))
        {
            this.TriggeredTprPolicies = new List<TriggeredTprPolicy>();
            this.TriggeredTprPolicies.ApplyExploratoryFieldSpec(parent + ".triggeredTprPolicies");
        }
    }


    #endregion

    } // class TprRequestDetailReply
    
    #endregion

    public static class ListTprRequestDetailReplyExtensions
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
            this List<TprRequestDetailReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestDetailReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestDetailReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types