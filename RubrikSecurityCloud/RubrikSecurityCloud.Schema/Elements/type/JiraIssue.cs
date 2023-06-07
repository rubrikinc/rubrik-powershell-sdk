// JiraIssue.cs
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
    #region JiraIssue
    public class JiraIssue: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? JiraProjectId
        // GraphQL -> jiraProjectId: String! (scalar)
        [JsonProperty("jiraProjectId")]
        public System.String? JiraProjectId { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        [JsonProperty("summary")]
        public System.String? Summary { get; set; }

        //      C# -> JiraUser? Assignee
        // GraphQL -> assignee: JiraUser (type)
        [JsonProperty("assignee")]
        public JiraUser? Assignee { get; set; }

        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType! (type)
        [JsonProperty("issueType")]
        public JiraIssueType? IssueType { get; set; }


        #endregion

    #region methods

    public JiraIssue Set(
        System.Boolean? IsRelic = null,
        System.String? JiraProjectId = null,
        System.String? Key = null,
        System.String? NaturalId = null,
        System.String? Summary = null,
        JiraUser? Assignee = null,
        JiraIssueType? IssueType = null
    ) 
    {
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( JiraProjectId != null ) {
            this.JiraProjectId = JiraProjectId;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
        }
        if ( Assignee != null ) {
            this.Assignee = Assignee;
        }
        if ( IssueType != null ) {
            this.IssueType = IssueType;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? JiraProjectId
        // GraphQL -> jiraProjectId: String! (scalar)
        if (this.JiraProjectId != null) {
            s += ind + "jiraProjectId\n" ;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (this.Summary != null) {
            s += ind + "summary\n" ;
        }
        //      C# -> JiraUser? Assignee
        // GraphQL -> assignee: JiraUser (type)
        if (this.Assignee != null) {
            s += ind + "assignee {\n" + this.Assignee.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType! (type)
        if (this.IssueType != null) {
            s += ind + "issueType {\n" + this.IssueType.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? JiraProjectId
        // GraphQL -> jiraProjectId: String! (scalar)
        if (this.JiraProjectId == null && Exploration.Includes(parent + ".jiraProjectId", true))
        {
            this.JiraProjectId = "FETCH";
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = "FETCH";
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId", true))
        {
            this.NaturalId = "FETCH";
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (this.Summary == null && Exploration.Includes(parent + ".summary", true))
        {
            this.Summary = "FETCH";
        }
        //      C# -> JiraUser? Assignee
        // GraphQL -> assignee: JiraUser (type)
        if (this.Assignee == null && Exploration.Includes(parent + ".assignee"))
        {
            this.Assignee = new JiraUser();
            this.Assignee.ApplyExploratoryFieldSpec(parent + ".assignee");
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType! (type)
        if (this.IssueType == null && Exploration.Includes(parent + ".issueType"))
        {
            this.IssueType = new JiraIssueType();
            this.IssueType.ApplyExploratoryFieldSpec(parent + ".issueType");
        }
    }


    #endregion

    } // class JiraIssue
    
    #endregion

    public static class ListJiraIssueExtensions
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
            this List<JiraIssue> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<JiraIssue> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new JiraIssue());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types