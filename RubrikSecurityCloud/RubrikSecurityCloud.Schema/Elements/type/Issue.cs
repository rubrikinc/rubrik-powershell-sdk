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

namespace Rubrik.SecurityCloud.Types
{
    #region Issue
    public class Issue: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? OpenTime
            // GraphQL -> openTime: Long! (scalar)
            if (this.OpenTime != null)
            {
                 s += ind + "openTime\n";

            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId != null)
            {
                 s += ind + "paginationId\n";

            }
            //      C# -> System.Int64? ResolvedTime
            // GraphQL -> resolvedTime: Long! (scalar)
            if (this.ResolvedTime != null)
            {
                 s += ind + "resolvedTime\n";

            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations != null)
            {
                 s += ind + "violations\n";

            }
            //      C# -> List<IssueEvent>? Events
            // GraphQL -> events: [IssueEvent!]! (type)
            if (this.Events != null)
            {
                 s += ind + "events\n";

                 s += ind + "{\n" + 
                 this.Events.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FileResult? FileResult
            // GraphQL -> fileResult: FileResult! (type)
            if (this.FileResult != null)
            {
                 s += ind + "fileResult\n";

                 s += ind + "{\n" + 
                 this.FileResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolicyObj? LatestPolicyObj
            // GraphQL -> latestPolicyObj: PolicyObj! (type)
            if (this.LatestPolicyObj != null)
            {
                 s += ind + "latestPolicyObj\n";

                 s += ind + "{\n" + 
                 this.LatestPolicyObj.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies != null)
            {
                 s += ind + "policies\n";

                 s += ind + "{\n" + 
                 this.Policies.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? OpenTime
            // GraphQL -> openTime: Long! (scalar)
            if (this.OpenTime == null && Exploration.Includes(parent + ".openTime$"))
            {
                this.OpenTime = new System.Int64();
            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId$"))
            {
                this.PaginationId = new System.String("FETCH");
            }
            //      C# -> System.Int64? ResolvedTime
            // GraphQL -> resolvedTime: Long! (scalar)
            if (this.ResolvedTime == null && Exploration.Includes(parent + ".resolvedTime$"))
            {
                this.ResolvedTime = new System.Int64();
            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations == null && Exploration.Includes(parent + ".violations$"))
            {
                this.Violations = new System.Int32();
            }
            //      C# -> List<IssueEvent>? Events
            // GraphQL -> events: [IssueEvent!]! (type)
            if (this.Events == null && Exploration.Includes(parent + ".events"))
            {
                this.Events = new List<IssueEvent>();
                this.Events.ApplyExploratoryFragment(parent + ".events");
            }
            //      C# -> FileResult? FileResult
            // GraphQL -> fileResult: FileResult! (type)
            if (this.FileResult == null && Exploration.Includes(parent + ".fileResult"))
            {
                this.FileResult = new FileResult();
                this.FileResult.ApplyExploratoryFragment(parent + ".fileResult");
            }
            //      C# -> PolicyObj? LatestPolicyObj
            // GraphQL -> latestPolicyObj: PolicyObj! (type)
            if (this.LatestPolicyObj == null && Exploration.Includes(parent + ".latestPolicyObj"))
            {
                this.LatestPolicyObj = new PolicyObj();
                this.LatestPolicyObj.ApplyExploratoryFragment(parent + ".latestPolicyObj");
            }
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies == null && Exploration.Includes(parent + ".policies"))
            {
                this.Policies = new List<ClassificationPolicySummary>();
                this.Policies.ApplyExploratoryFragment(parent + ".policies");
            }
        }


    #endregion

    } // class Issue
    #endregion

    public static class ListIssueExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Issue> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Issue> list, 
            String parent = "")
        {
            var item = new Issue();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types