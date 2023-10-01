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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? OpenTime
        // GraphQL -> openTime: Long! (scalar)
        if (this.OpenTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "openTime\n" ;
            } else {
                s += ind + "openTime\n" ;
            }
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paginationId\n" ;
            } else {
                s += ind + "paginationId\n" ;
            }
        }
        //      C# -> System.Int64? ResolvedTime
        // GraphQL -> resolvedTime: Long! (scalar)
        if (this.ResolvedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolvedTime\n" ;
            } else {
                s += ind + "resolvedTime\n" ;
            }
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violations\n" ;
            } else {
                s += ind + "violations\n" ;
            }
        }
        //      C# -> List<IssueEvent>? Events
        // GraphQL -> events: [IssueEvent!]! (type)
        if (this.Events != null) {
            var fspec = this.Events.AsFieldSpec(conf.Child("events"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "events {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FileResult? FileResult
        // GraphQL -> fileResult: FileResult! (type)
        if (this.FileResult != null) {
            var fspec = this.FileResult.AsFieldSpec(conf.Child("fileResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileResult {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolicyObj? LatestPolicyObj
        // GraphQL -> latestPolicyObj: PolicyObj! (type)
        if (this.LatestPolicyObj != null) {
            var fspec = this.LatestPolicyObj.AsFieldSpec(conf.Child("latestPolicyObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestPolicyObj {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(conf.Child("policies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policies {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.Int64? OpenTime
        // GraphQL -> openTime: Long! (scalar)
        if (ec.Includes("openTime",true))
        {
            if(this.OpenTime == null) {

                this.OpenTime = new System.Int64();

            } else {


            }
        }
        else if (this.OpenTime != null && ec.Excludes("openTime",true))
        {
            this.OpenTime = null;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (ec.Includes("paginationId",true))
        {
            if(this.PaginationId == null) {

                this.PaginationId = "FETCH";

            } else {


            }
        }
        else if (this.PaginationId != null && ec.Excludes("paginationId",true))
        {
            this.PaginationId = null;
        }
        //      C# -> System.Int64? ResolvedTime
        // GraphQL -> resolvedTime: Long! (scalar)
        if (ec.Includes("resolvedTime",true))
        {
            if(this.ResolvedTime == null) {

                this.ResolvedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ResolvedTime != null && ec.Excludes("resolvedTime",true))
        {
            this.ResolvedTime = null;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (ec.Includes("violations",true))
        {
            if(this.Violations == null) {

                this.Violations = Int32.MinValue;

            } else {


            }
        }
        else if (this.Violations != null && ec.Excludes("violations",true))
        {
            this.Violations = null;
        }
        //      C# -> List<IssueEvent>? Events
        // GraphQL -> events: [IssueEvent!]! (type)
        if (ec.Includes("events",false))
        {
            if(this.Events == null) {

                this.Events = new List<IssueEvent>();
                this.Events.ApplyExploratoryFieldSpec(ec.NewChild("events"));

            } else {

                this.Events.ApplyExploratoryFieldSpec(ec.NewChild("events"));

            }
        }
        else if (this.Events != null && ec.Excludes("events",false))
        {
            this.Events = null;
        }
        //      C# -> FileResult? FileResult
        // GraphQL -> fileResult: FileResult! (type)
        if (ec.Includes("fileResult",false))
        {
            if(this.FileResult == null) {

                this.FileResult = new FileResult();
                this.FileResult.ApplyExploratoryFieldSpec(ec.NewChild("fileResult"));

            } else {

                this.FileResult.ApplyExploratoryFieldSpec(ec.NewChild("fileResult"));

            }
        }
        else if (this.FileResult != null && ec.Excludes("fileResult",false))
        {
            this.FileResult = null;
        }
        //      C# -> PolicyObj? LatestPolicyObj
        // GraphQL -> latestPolicyObj: PolicyObj! (type)
        if (ec.Includes("latestPolicyObj",false))
        {
            if(this.LatestPolicyObj == null) {

                this.LatestPolicyObj = new PolicyObj();
                this.LatestPolicyObj.ApplyExploratoryFieldSpec(ec.NewChild("latestPolicyObj"));

            } else {

                this.LatestPolicyObj.ApplyExploratoryFieldSpec(ec.NewChild("latestPolicyObj"));

            }
        }
        else if (this.LatestPolicyObj != null && ec.Excludes("latestPolicyObj",false))
        {
            this.LatestPolicyObj = null;
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (ec.Includes("policies",false))
        {
            if(this.Policies == null) {

                this.Policies = new List<ClassificationPolicySummary>();
                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            } else {

                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            }
        }
        else if (this.Policies != null && ec.Excludes("policies",false))
        {
            this.Policies = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Issue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Issue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Issue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Issue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types