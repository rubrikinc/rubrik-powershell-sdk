// Issue.cs
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
    #region Issue
    public class Issue: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? OpenTime
        // GraphQL -> openTime: Long! (scalar)
        [JsonProperty("openTime")]
        public System.Int64? OpenTime { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> System.Int64? ResolvedTime
        // GraphQL -> resolvedTime: Long! (scalar)
        [JsonProperty("resolvedTime")]
        public System.Int64? ResolvedTime { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> List<IssueEvent>? Events
        // GraphQL -> events: [IssueEvent!]! (type)
        [JsonProperty("events")]
        public List<IssueEvent>? Events { get; set; }

        //      C# -> FileResult? FileResult
        // GraphQL -> fileResult: FileResult! (type)
        [JsonProperty("fileResult")]
        public FileResult? FileResult { get; set; }

        //      C# -> PolicyObj? LatestPolicyObj
        // GraphQL -> latestPolicyObj: PolicyObj! (type)
        [JsonProperty("latestPolicyObj")]
        public PolicyObj? LatestPolicyObj { get; set; }

        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicySummary>? Policies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Issue";
    }

    public Issue Set(
        System.String? Id = null,
        System.Int64? OpenTime = null,
        System.String? PaginationId = null,
        System.Int64? ResolvedTime = null,
        System.Int32? Violations = null,
        List<IssueEvent>? Events = null,
        FileResult? FileResult = null,
        PolicyObj? LatestPolicyObj = null,
        List<ClassificationPolicySummary>? Policies = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OpenTime != null ) {
            this.OpenTime = OpenTime;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( ResolvedTime != null ) {
            this.ResolvedTime = ResolvedTime;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( Events != null ) {
            this.Events = Events;
        }
        if ( FileResult != null ) {
            this.FileResult = FileResult;
        }
        if ( LatestPolicyObj != null ) {
            this.LatestPolicyObj = LatestPolicyObj;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? OpenTime
        // GraphQL -> openTime: Long! (scalar)
        if (this.OpenTime != null) {
            s += ind + "openTime\n" ;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            s += ind + "paginationId\n" ;
        }
        //      C# -> System.Int64? ResolvedTime
        // GraphQL -> resolvedTime: Long! (scalar)
        if (this.ResolvedTime != null) {
            s += ind + "resolvedTime\n" ;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            s += ind + "violations\n" ;
        }
        //      C# -> List<IssueEvent>? Events
        // GraphQL -> events: [IssueEvent!]! (type)
        if (this.Events != null) {
            var fspec = this.Events.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "events {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FileResult? FileResult
        // GraphQL -> fileResult: FileResult! (type)
        if (this.FileResult != null) {
            var fspec = this.FileResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "fileResult {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolicyObj? LatestPolicyObj
        // GraphQL -> latestPolicyObj: PolicyObj! (type)
        if (this.LatestPolicyObj != null) {
            var fspec = this.LatestPolicyObj.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestPolicyObj {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policies {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? OpenTime
        // GraphQL -> openTime: Long! (scalar)
        if (this.OpenTime == null && Exploration.Includes(parent + ".openTime", true))
        {
            this.OpenTime = new System.Int64();
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId", true))
        {
            this.PaginationId = "FETCH";
        }
        //      C# -> System.Int64? ResolvedTime
        // GraphQL -> resolvedTime: Long! (scalar)
        if (this.ResolvedTime == null && Exploration.Includes(parent + ".resolvedTime", true))
        {
            this.ResolvedTime = new System.Int64();
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations == null && Exploration.Includes(parent + ".violations", true))
        {
            this.Violations = Int32.MinValue;
        }
        //      C# -> List<IssueEvent>? Events
        // GraphQL -> events: [IssueEvent!]! (type)
        if (this.Events == null && Exploration.Includes(parent + ".events"))
        {
            this.Events = new List<IssueEvent>();
            this.Events.ApplyExploratoryFieldSpec(parent + ".events");
        }
        //      C# -> FileResult? FileResult
        // GraphQL -> fileResult: FileResult! (type)
        if (this.FileResult == null && Exploration.Includes(parent + ".fileResult"))
        {
            this.FileResult = new FileResult();
            this.FileResult.ApplyExploratoryFieldSpec(parent + ".fileResult");
        }
        //      C# -> PolicyObj? LatestPolicyObj
        // GraphQL -> latestPolicyObj: PolicyObj! (type)
        if (this.LatestPolicyObj == null && Exploration.Includes(parent + ".latestPolicyObj"))
        {
            this.LatestPolicyObj = new PolicyObj();
            this.LatestPolicyObj.ApplyExploratoryFieldSpec(parent + ".latestPolicyObj");
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies == null && Exploration.Includes(parent + ".policies"))
        {
            this.Policies = new List<ClassificationPolicySummary>();
            this.Policies.ApplyExploratoryFieldSpec(parent + ".policies");
        }
    }


    #endregion

    } // class Issue
    
    #endregion

    public static class ListIssueExtensions
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
            this List<Issue> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Issue> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Issue());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types