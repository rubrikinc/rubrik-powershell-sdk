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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> InsightCategory? Category
        // GraphQL -> category: InsightCategory! (enum)
        if (this.Category != null) {
            s += ind + "category\n" ;
        }
        //      C# -> InsightSeverity? Severity
        // GraphQL -> severity: InsightSeverity! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> InsightType? Type
        // GraphQL -> type: InsightType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? AutomatedCaseId
        // GraphQL -> automatedCaseId: String (scalar)
        if (this.AutomatedCaseId != null) {
            s += ind + "automatedCaseId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> List<System.String>? Labels
        // GraphQL -> labels: [String!]! (scalar)
        if (this.Labels != null) {
            s += ind + "labels\n" ;
        }
        //      C# -> System.String? Resolution
        // GraphQL -> resolution: String! (scalar)
        if (this.Resolution != null) {
            s += ind + "resolution\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> List<ActiveInsightClusterMetadata>? Clusters
        // GraphQL -> clusters: [ActiveInsightClusterMetadata!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusters {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InsightCategory? Category
        // GraphQL -> category: InsightCategory! (enum)
        if (this.Category == null && ec.Includes("category",true))
        {
            this.Category = new InsightCategory();
        }
        //      C# -> InsightSeverity? Severity
        // GraphQL -> severity: InsightSeverity! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new InsightSeverity();
        }
        //      C# -> InsightType? Type
        // GraphQL -> type: InsightType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new InsightType();
        }
        //      C# -> System.String? AutomatedCaseId
        // GraphQL -> automatedCaseId: String (scalar)
        if (this.AutomatedCaseId == null && ec.Includes("automatedCaseId",true))
        {
            this.AutomatedCaseId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> List<System.String>? Labels
        // GraphQL -> labels: [String!]! (scalar)
        if (this.Labels == null && ec.Includes("labels",true))
        {
            this.Labels = new List<System.String>();
        }
        //      C# -> System.String? Resolution
        // GraphQL -> resolution: String! (scalar)
        if (this.Resolution == null && ec.Includes("resolution",true))
        {
            this.Resolution = "FETCH";
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && ec.Includes("title",true))
        {
            this.Title = "FETCH";
        }
        //      C# -> List<ActiveInsightClusterMetadata>? Clusters
        // GraphQL -> clusters: [ActiveInsightClusterMetadata!]! (type)
        if (this.Clusters == null && ec.Includes("clusters",false))
        {
            this.Clusters = new List<ActiveInsightClusterMetadata>();
            this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));
        }
    }


    #endregion

    } // class ActiveInsight
    
    #endregion

    public static class ListActiveInsightExtensions
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
            this List<ActiveInsight> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ActiveInsight> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types