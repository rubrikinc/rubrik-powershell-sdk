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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region JiraIssue
    public class JiraIssue: BaseType
    {
        #region members

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }

        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        [JsonProperty("summary")]
        public System.String? Summary { get; set; }

        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        [JsonProperty("assignee")]
        public AtlassianUser? Assignee { get; set; }

        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
        [JsonProperty("issueType")]
        public JiraIssueType? IssueType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JiraIssue";
    }

    public JiraIssue Set(
        System.String? AppItemTypeToken = null,
        System.Boolean? IsRelic = null,
        System.String? Key = null,
        System.String? NaturalId = null,
        System.String? ProjectId = null,
        System.String? Summary = null,
        AtlassianUser? Assignee = null,
        JiraIssueType? IssueType = null
    ) 
    {
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
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
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            s += ind + "appItemTypeToken\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
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
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (this.Summary != null) {
            s += ind + "summary\n" ;
        }
        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        if (this.Assignee != null) {
            var fspec = this.Assignee.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "assignee {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
        if (this.IssueType != null) {
            var fspec = this.IssueType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "issueType {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken == null && Exploration.Includes(parent + ".appItemTypeToken", true))
        {
            this.AppItemTypeToken = "FETCH";
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
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
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && Exploration.Includes(parent + ".projectId", true))
        {
            this.ProjectId = "FETCH";
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (this.Summary == null && Exploration.Includes(parent + ".summary", true))
        {
            this.Summary = "FETCH";
        }
        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        if (this.Assignee == null && Exploration.Includes(parent + ".assignee"))
        {
            this.Assignee = new AtlassianUser();
            this.Assignee.ApplyExploratoryFieldSpec(parent + ".assignee");
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
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
            return list[0].AsFieldSpec(indent);
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


} // namespace RubrikSecurityCloud.Types