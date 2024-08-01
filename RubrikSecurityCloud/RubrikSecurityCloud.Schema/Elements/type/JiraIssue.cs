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

        //      C# -> AppItemActionType? ActionType
        // GraphQL -> actionType: AppItemActionType! (enum)
        [JsonProperty("actionType")]
        public AppItemActionType? ActionType { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> DateTime? CreatedAtUtc
        // GraphQL -> createdAtUtc: DateTime (scalar)
        [JsonProperty("createdAtUtc")]
        public DateTime? CreatedAtUtc { get; set; }

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

        //      C# -> DateTime? UpdatedAtUtc
        // GraphQL -> updatedAtUtc: DateTime (scalar)
        [JsonProperty("updatedAtUtc")]
        public DateTime? UpdatedAtUtc { get; set; }

        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        [JsonProperty("assignee")]
        public AtlassianUser? Assignee { get; set; }

        //      C# -> List<JiraProjectComponent>? Components
        // GraphQL -> components: [JiraProjectComponent!]! (type)
        [JsonProperty("components")]
        public List<JiraProjectComponent>? Components { get; set; }

        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
        [JsonProperty("issueType")]
        public JiraIssueType? IssueType { get; set; }

        //      C# -> JiraIssuePriority? Priority
        // GraphQL -> priority: JiraIssuePriority (type)
        [JsonProperty("priority")]
        public JiraIssuePriority? Priority { get; set; }

        //      C# -> AtlassianUser? Reporter
        // GraphQL -> reporter: AtlassianUser (type)
        [JsonProperty("reporter")]
        public AtlassianUser? Reporter { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JiraIssue";
    }

    public JiraIssue Set(
        AppItemActionType? ActionType = null,
        System.String? AppItemTypeToken = null,
        DateTime? CreatedAtUtc = null,
        System.Boolean? IsRelic = null,
        System.String? Key = null,
        System.String? NaturalId = null,
        System.String? ProjectId = null,
        System.String? Summary = null,
        DateTime? UpdatedAtUtc = null,
        AtlassianUser? Assignee = null,
        List<JiraProjectComponent>? Components = null,
        JiraIssueType? IssueType = null,
        JiraIssuePriority? Priority = null,
        AtlassianUser? Reporter = null
    ) 
    {
        if ( ActionType != null ) {
            this.ActionType = ActionType;
        }
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( CreatedAtUtc != null ) {
            this.CreatedAtUtc = CreatedAtUtc;
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
        if ( UpdatedAtUtc != null ) {
            this.UpdatedAtUtc = UpdatedAtUtc;
        }
        if ( Assignee != null ) {
            this.Assignee = Assignee;
        }
        if ( Components != null ) {
            this.Components = Components;
        }
        if ( IssueType != null ) {
            this.IssueType = IssueType;
        }
        if ( Priority != null ) {
            this.Priority = Priority;
        }
        if ( Reporter != null ) {
            this.Reporter = Reporter;
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
        //      C# -> AppItemActionType? ActionType
        // GraphQL -> actionType: AppItemActionType! (enum)
        if (this.ActionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionType\n" ;
            } else {
                s += ind + "actionType\n" ;
            }
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appItemTypeToken\n" ;
            } else {
                s += ind + "appItemTypeToken\n" ;
            }
        }
        //      C# -> DateTime? CreatedAtUtc
        // GraphQL -> createdAtUtc: DateTime (scalar)
        if (this.CreatedAtUtc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAtUtc\n" ;
            } else {
                s += ind + "createdAtUtc\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "naturalId\n" ;
            } else {
                s += ind + "naturalId\n" ;
            }
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectId\n" ;
            } else {
                s += ind + "projectId\n" ;
            }
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (this.Summary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "summary\n" ;
            } else {
                s += ind + "summary\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAtUtc
        // GraphQL -> updatedAtUtc: DateTime (scalar)
        if (this.UpdatedAtUtc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAtUtc\n" ;
            } else {
                s += ind + "updatedAtUtc\n" ;
            }
        }
        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        if (this.Assignee != null) {
            var fspec = this.Assignee.AsFieldSpec(conf.Child("assignee"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "assignee" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<JiraProjectComponent>? Components
        // GraphQL -> components: [JiraProjectComponent!]! (type)
        if (this.Components != null) {
            var fspec = this.Components.AsFieldSpec(conf.Child("components"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "components" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
        if (this.IssueType != null) {
            var fspec = this.IssueType.AsFieldSpec(conf.Child("issueType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "issueType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> JiraIssuePriority? Priority
        // GraphQL -> priority: JiraIssuePriority (type)
        if (this.Priority != null) {
            var fspec = this.Priority.AsFieldSpec(conf.Child("priority"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "priority" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AtlassianUser? Reporter
        // GraphQL -> reporter: AtlassianUser (type)
        if (this.Reporter != null) {
            var fspec = this.Reporter.AsFieldSpec(conf.Child("reporter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reporter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppItemActionType? ActionType
        // GraphQL -> actionType: AppItemActionType! (enum)
        if (ec.Includes("actionType",true))
        {
            if(this.ActionType == null) {

                this.ActionType = new AppItemActionType();

            } else {


            }
        }
        else if (this.ActionType != null && ec.Excludes("actionType",true))
        {
            this.ActionType = null;
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (ec.Includes("appItemTypeToken",true))
        {
            if(this.AppItemTypeToken == null) {

                this.AppItemTypeToken = "FETCH";

            } else {


            }
        }
        else if (this.AppItemTypeToken != null && ec.Excludes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = null;
        }
        //      C# -> DateTime? CreatedAtUtc
        // GraphQL -> createdAtUtc: DateTime (scalar)
        if (ec.Includes("createdAtUtc",true))
        {
            if(this.CreatedAtUtc == null) {

                this.CreatedAtUtc = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAtUtc != null && ec.Excludes("createdAtUtc",true))
        {
            this.CreatedAtUtc = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (ec.Includes("naturalId",true))
        {
            if(this.NaturalId == null) {

                this.NaturalId = "FETCH";

            } else {


            }
        }
        else if (this.NaturalId != null && ec.Excludes("naturalId",true))
        {
            this.NaturalId = null;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (ec.Includes("projectId",true))
        {
            if(this.ProjectId == null) {

                this.ProjectId = "FETCH";

            } else {


            }
        }
        else if (this.ProjectId != null && ec.Excludes("projectId",true))
        {
            this.ProjectId = null;
        }
        //      C# -> System.String? Summary
        // GraphQL -> summary: String! (scalar)
        if (ec.Includes("summary",true))
        {
            if(this.Summary == null) {

                this.Summary = "FETCH";

            } else {


            }
        }
        else if (this.Summary != null && ec.Excludes("summary",true))
        {
            this.Summary = null;
        }
        //      C# -> DateTime? UpdatedAtUtc
        // GraphQL -> updatedAtUtc: DateTime (scalar)
        if (ec.Includes("updatedAtUtc",true))
        {
            if(this.UpdatedAtUtc == null) {

                this.UpdatedAtUtc = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAtUtc != null && ec.Excludes("updatedAtUtc",true))
        {
            this.UpdatedAtUtc = null;
        }
        //      C# -> AtlassianUser? Assignee
        // GraphQL -> assignee: AtlassianUser (type)
        if (ec.Includes("assignee",false))
        {
            if(this.Assignee == null) {

                this.Assignee = new AtlassianUser();
                this.Assignee.ApplyExploratoryFieldSpec(ec.NewChild("assignee"));

            } else {

                this.Assignee.ApplyExploratoryFieldSpec(ec.NewChild("assignee"));

            }
        }
        else if (this.Assignee != null && ec.Excludes("assignee",false))
        {
            this.Assignee = null;
        }
        //      C# -> List<JiraProjectComponent>? Components
        // GraphQL -> components: [JiraProjectComponent!]! (type)
        if (ec.Includes("components",false))
        {
            if(this.Components == null) {

                this.Components = new List<JiraProjectComponent>();
                this.Components.ApplyExploratoryFieldSpec(ec.NewChild("components"));

            } else {

                this.Components.ApplyExploratoryFieldSpec(ec.NewChild("components"));

            }
        }
        else if (this.Components != null && ec.Excludes("components",false))
        {
            this.Components = null;
        }
        //      C# -> JiraIssueType? IssueType
        // GraphQL -> issueType: JiraIssueType (type)
        if (ec.Includes("issueType",false))
        {
            if(this.IssueType == null) {

                this.IssueType = new JiraIssueType();
                this.IssueType.ApplyExploratoryFieldSpec(ec.NewChild("issueType"));

            } else {

                this.IssueType.ApplyExploratoryFieldSpec(ec.NewChild("issueType"));

            }
        }
        else if (this.IssueType != null && ec.Excludes("issueType",false))
        {
            this.IssueType = null;
        }
        //      C# -> JiraIssuePriority? Priority
        // GraphQL -> priority: JiraIssuePriority (type)
        if (ec.Includes("priority",false))
        {
            if(this.Priority == null) {

                this.Priority = new JiraIssuePriority();
                this.Priority.ApplyExploratoryFieldSpec(ec.NewChild("priority"));

            } else {

                this.Priority.ApplyExploratoryFieldSpec(ec.NewChild("priority"));

            }
        }
        else if (this.Priority != null && ec.Excludes("priority",false))
        {
            this.Priority = null;
        }
        //      C# -> AtlassianUser? Reporter
        // GraphQL -> reporter: AtlassianUser (type)
        if (ec.Includes("reporter",false))
        {
            if(this.Reporter == null) {

                this.Reporter = new AtlassianUser();
                this.Reporter.ApplyExploratoryFieldSpec(ec.NewChild("reporter"));

            } else {

                this.Reporter.ApplyExploratoryFieldSpec(ec.NewChild("reporter"));

            }
        }
        else if (this.Reporter != null && ec.Excludes("reporter",false))
        {
            this.Reporter = null;
        }
    }


    #endregion

    } // class JiraIssue
    
    #endregion

    public static class ListJiraIssueExtensions
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
            this List<JiraIssue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<JiraIssue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<JiraIssue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new JiraIssue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<JiraIssue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types