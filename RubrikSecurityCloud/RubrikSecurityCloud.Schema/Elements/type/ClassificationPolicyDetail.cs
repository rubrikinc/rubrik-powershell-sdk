// ClassificationPolicyDetail.cs
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
    #region ClassificationPolicyDetail
    public class ClassificationPolicyDetail: BaseType
    {
        #region members

        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        [JsonProperty("colorEnum")]
        public ClassificationPolicyColor? ColorEnum { get; set; }

        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        [JsonProperty("mode")]
        public ClassificationPolicyMode? Mode { get; set; }

        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        [JsonProperty("hierarchyObjects")]
        public List<HierarchyObject>? HierarchyObjects { get; set; }

        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        [JsonProperty("createdTime")]
        public System.Int64? CreatedTime { get; set; }

        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        [JsonProperty("deletable")]
        public System.Boolean? Deletable { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        [JsonProperty("hierarchyObjectIds")]
        public List<System.String>? HierarchyObjectIds { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        [JsonProperty("lastUpdatedTime")]
        public System.Int64? LastUpdatedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        [JsonProperty("numAnalyzers")]
        public System.Int32? NumAnalyzers { get; set; }

        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        [JsonProperty("totalObjects")]
        public System.Int32? TotalObjects { get; set; }

        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        [JsonProperty("analyzers")]
        public List<Analyzer>? Analyzers { get; set; }

        //      C# -> AssignmentResourceDetailsConnection? AssignmentResources
        // GraphQL -> assignmentResources: AssignmentResourceDetailsConnection! (type)
        [JsonProperty("assignmentResources")]
        public AssignmentResourceDetailsConnection? AssignmentResources { get; set; }

        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        [JsonProperty("creator")]
        public User? Creator { get; set; }

        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        [JsonProperty("hierarchyObjectConnection")]
        public HierarchyObjectConnection? HierarchyObjectConnection { get; set; }

        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        [JsonProperty("objectStatuses")]
        public List<ObjectStatus>? ObjectStatuses { get; set; }

        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        [JsonProperty("whitelists")]
        public List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClassificationPolicyDetail";
    }

    public ClassificationPolicyDetail Set(
        ClassificationPolicyColor? ColorEnum = null,
        ClassificationPolicyMode? Mode = null,
        List<HierarchyObject>? HierarchyObjects = null,
        System.Int64? CreatedTime = null,
        System.Boolean? Deletable = null,
        System.String? Description = null,
        List<System.String>? HierarchyObjectIds = null,
        System.String? Id = null,
        System.Int64? LastUpdatedTime = null,
        System.String? Name = null,
        System.Int32? NumAnalyzers = null,
        System.Int32? TotalObjects = null,
        List<Analyzer>? Analyzers = null,
        AssignmentResourceDetailsConnection? AssignmentResources = null,
        User? Creator = null,
        HierarchyObjectConnection? HierarchyObjectConnection = null,
        List<ObjectStatus>? ObjectStatuses = null,
        List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists = null
    ) 
    {
        if ( ColorEnum != null ) {
            this.ColorEnum = ColorEnum;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( HierarchyObjects != null ) {
            this.HierarchyObjects = HierarchyObjects;
        }
        if ( CreatedTime != null ) {
            this.CreatedTime = CreatedTime;
        }
        if ( Deletable != null ) {
            this.Deletable = Deletable;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( HierarchyObjectIds != null ) {
            this.HierarchyObjectIds = HierarchyObjectIds;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastUpdatedTime != null ) {
            this.LastUpdatedTime = LastUpdatedTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumAnalyzers != null ) {
            this.NumAnalyzers = NumAnalyzers;
        }
        if ( TotalObjects != null ) {
            this.TotalObjects = TotalObjects;
        }
        if ( Analyzers != null ) {
            this.Analyzers = Analyzers;
        }
        if ( AssignmentResources != null ) {
            this.AssignmentResources = AssignmentResources;
        }
        if ( Creator != null ) {
            this.Creator = Creator;
        }
        if ( HierarchyObjectConnection != null ) {
            this.HierarchyObjectConnection = HierarchyObjectConnection;
        }
        if ( ObjectStatuses != null ) {
            this.ObjectStatuses = ObjectStatuses;
        }
        if ( Whitelists != null ) {
            this.Whitelists = Whitelists;
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
        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        if (this.ColorEnum != null) {
            s += ind + "colorEnum\n" ;
        }
        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        if (this.Mode != null) {
            s += ind + "mode\n" ;
        }
        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        if (this.HierarchyObjects != null) {
                var fspec = this.HierarchyObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hierarchyObjects {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        if (this.CreatedTime != null) {
            s += ind + "createdTime\n" ;
        }
        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        if (this.Deletable != null) {
            s += ind + "deletable\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        if (this.HierarchyObjectIds != null) {
            s += ind + "hierarchyObjectIds\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        if (this.LastUpdatedTime != null) {
            s += ind + "lastUpdatedTime\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        if (this.NumAnalyzers != null) {
            s += ind + "numAnalyzers\n" ;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects != null) {
            s += ind + "totalObjects\n" ;
        }
        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        if (this.Analyzers != null) {
            var fspec = this.Analyzers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzers {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AssignmentResourceDetailsConnection? AssignmentResources
        // GraphQL -> assignmentResources: AssignmentResourceDetailsConnection! (type)
        if (this.AssignmentResources != null) {
            var fspec = this.AssignmentResources.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "assignmentResources {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "creator {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        if (this.HierarchyObjectConnection != null) {
            var fspec = this.HierarchyObjectConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hierarchyObjectConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        if (this.ObjectStatuses != null) {
            var fspec = this.ObjectStatuses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectStatuses {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        if (this.Whitelists != null) {
            var fspec = this.Whitelists.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "whitelists {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        if (this.ColorEnum == null && ec.Includes("colorEnum",true))
        {
            this.ColorEnum = new ClassificationPolicyColor();
        }
        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        if (this.Mode == null && ec.Includes("mode",true))
        {
            this.Mode = new ClassificationPolicyMode();
        }
        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        if (this.HierarchyObjects == null && ec.Includes("hierarchyObjects",false))
        {
            this.HierarchyObjects = new List<HierarchyObject>();
            this.HierarchyObjects.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjects"));
        }
        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        if (this.CreatedTime == null && ec.Includes("createdTime",true))
        {
            this.CreatedTime = new System.Int64();
        }
        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        if (this.Deletable == null && ec.Includes("deletable",true))
        {
            this.Deletable = true;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        if (this.HierarchyObjectIds == null && ec.Includes("hierarchyObjectIds",true))
        {
            this.HierarchyObjectIds = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        if (this.LastUpdatedTime == null && ec.Includes("lastUpdatedTime",true))
        {
            this.LastUpdatedTime = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        if (this.NumAnalyzers == null && ec.Includes("numAnalyzers",true))
        {
            this.NumAnalyzers = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects == null && ec.Includes("totalObjects",true))
        {
            this.TotalObjects = Int32.MinValue;
        }
        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        if (this.Analyzers == null && ec.Includes("analyzers",false))
        {
            this.Analyzers = new List<Analyzer>();
            this.Analyzers.ApplyExploratoryFieldSpec(ec.NewChild("analyzers"));
        }
        //      C# -> AssignmentResourceDetailsConnection? AssignmentResources
        // GraphQL -> assignmentResources: AssignmentResourceDetailsConnection! (type)
        if (this.AssignmentResources == null && ec.Includes("assignmentResources",false))
        {
            this.AssignmentResources = new AssignmentResourceDetailsConnection();
            this.AssignmentResources.ApplyExploratoryFieldSpec(ec.NewChild("assignmentResources"));
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator == null && ec.Includes("creator",false))
        {
            this.Creator = new User();
            this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));
        }
        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        if (this.HierarchyObjectConnection == null && ec.Includes("hierarchyObjectConnection",false))
        {
            this.HierarchyObjectConnection = new HierarchyObjectConnection();
            this.HierarchyObjectConnection.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjectConnection"));
        }
        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        if (this.ObjectStatuses == null && ec.Includes("objectStatuses",false))
        {
            this.ObjectStatuses = new List<ObjectStatus>();
            this.ObjectStatuses.ApplyExploratoryFieldSpec(ec.NewChild("objectStatuses"));
        }
        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        if (this.Whitelists == null && ec.Includes("whitelists",false))
        {
            this.Whitelists = new List<ClassificationPolicyWhitelistDetailedEntry>();
            this.Whitelists.ApplyExploratoryFieldSpec(ec.NewChild("whitelists"));
        }
    }


    #endregion

    } // class ClassificationPolicyDetail
    
    #endregion

    public static class ListClassificationPolicyDetailExtensions
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
            this List<ClassificationPolicyDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClassificationPolicyDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClassificationPolicyDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ClassificationPolicyDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types