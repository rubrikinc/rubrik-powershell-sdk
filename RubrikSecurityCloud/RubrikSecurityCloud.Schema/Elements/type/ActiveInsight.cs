// ActiveInsight.cs
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
    #region ActiveInsight
    public class ActiveInsight: BaseType
    {
        #region members

        //      C# -> InsightCategory? Category
        // GraphQL -> category: InsightCategory! (enum)
        [JsonProperty("category")]
        public InsightCategory? Category { get; set; }

        //      C# -> InsightSeverity? Severity
        // GraphQL -> severity: InsightSeverity! (enum)
        [JsonProperty("severity")]
        public InsightSeverity? Severity { get; set; }

        //      C# -> InsightType? Type
        // GraphQL -> type: InsightType! (enum)
        [JsonProperty("type")]
        public InsightType? Type { get; set; }

        //      C# -> System.String? AutomatedCaseId
        // GraphQL -> automatedCaseId: String (scalar)
        [JsonProperty("automatedCaseId")]
        public System.String? AutomatedCaseId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Labels
        // GraphQL -> labels: [String!]! (scalar)
        [JsonProperty("labels")]
        public List<System.String>? Labels { get; set; }

        //      C# -> System.String? Resolution
        // GraphQL -> resolution: String! (scalar)
        [JsonProperty("resolution")]
        public System.String? Resolution { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> List<ActiveInsightClusterMetadata>? Clusters
        // GraphQL -> clusters: [ActiveInsightClusterMetadata!]! (type)
        [JsonProperty("clusters")]
        public List<ActiveInsightClusterMetadata>? Clusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveInsight";
    }

    public ActiveInsight Set(
        InsightCategory? Category = null,
        InsightSeverity? Severity = null,
        InsightType? Type = null,
        System.String? AutomatedCaseId = null,
        System.String? Description = null,
        System.String? Id = null,
        List<System.String>? Labels = null,
        System.String? Resolution = null,
        System.String? Title = null,
        List<ActiveInsightClusterMetadata>? Clusters = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( AutomatedCaseId != null ) {
            this.AutomatedCaseId = AutomatedCaseId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
        }
        if ( Resolution != null ) {
            this.Resolution = Resolution;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
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
        //      C# -> InsightCategory? Category
        // GraphQL -> category: InsightCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> InsightSeverity? Severity
        // GraphQL -> severity: InsightSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> InsightType? Type
        // GraphQL -> type: InsightType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? AutomatedCaseId
        // GraphQL -> automatedCaseId: String (scalar)
        if (this.AutomatedCaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "automatedCaseId\n" ;
            } else {
                s += ind + "automatedCaseId\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        //      C# -> List<System.String>? Labels
        // GraphQL -> labels: [String!]! (scalar)
        if (this.Labels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labels\n" ;
            } else {
                s += ind + "labels\n" ;
            }
        }
        //      C# -> System.String? Resolution
        // GraphQL -> resolution: String! (scalar)
        if (this.Resolution != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolution\n" ;
            } else {
                s += ind + "resolution\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> List<ActiveInsightClusterMetadata>? Clusters
        // GraphQL -> clusters: [ActiveInsightClusterMetadata!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(conf.Child("clusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InsightCategory? Category
        // GraphQL -> category: InsightCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new InsightCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> InsightSeverity? Severity
        // GraphQL -> severity: InsightSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new InsightSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> InsightType? Type
        // GraphQL -> type: InsightType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new InsightType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? AutomatedCaseId
        // GraphQL -> automatedCaseId: String (scalar)
        if (ec.Includes("automatedCaseId",true))
        {
            if(this.AutomatedCaseId == null) {

                this.AutomatedCaseId = "FETCH";

            } else {


            }
        }
        else if (this.AutomatedCaseId != null && ec.Excludes("automatedCaseId",true))
        {
            this.AutomatedCaseId = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
        //      C# -> List<System.String>? Labels
        // GraphQL -> labels: [String!]! (scalar)
        if (ec.Includes("labels",true))
        {
            if(this.Labels == null) {

                this.Labels = new List<System.String>();

            } else {


            }
        }
        else if (this.Labels != null && ec.Excludes("labels",true))
        {
            this.Labels = null;
        }
        //      C# -> System.String? Resolution
        // GraphQL -> resolution: String! (scalar)
        if (ec.Includes("resolution",true))
        {
            if(this.Resolution == null) {

                this.Resolution = "FETCH";

            } else {


            }
        }
        else if (this.Resolution != null && ec.Excludes("resolution",true))
        {
            this.Resolution = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> List<ActiveInsightClusterMetadata>? Clusters
        // GraphQL -> clusters: [ActiveInsightClusterMetadata!]! (type)
        if (ec.Includes("clusters",false))
        {
            if(this.Clusters == null) {

                this.Clusters = new List<ActiveInsightClusterMetadata>();
                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            } else {

                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            }
        }
        else if (this.Clusters != null && ec.Excludes("clusters",false))
        {
            this.Clusters = null;
        }
    }


    #endregion

    } // class ActiveInsight
    
    #endregion

    public static class ListActiveInsightExtensions
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
            this List<ActiveInsight> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveInsight> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveInsight> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveInsight());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveInsight> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types