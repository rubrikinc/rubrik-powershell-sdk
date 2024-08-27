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

        //      C# -> DataCategoryResult? DataCategoryResult
        // GraphQL -> dataCategoryResult: DataCategoryResult (type)
        [JsonProperty("dataCategoryResult")]
        public DataCategoryResult? DataCategoryResult { get; set; }

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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars AssignmentResources { get; set; }

        public RscGqlVars HierarchyObjectConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] assignmentResourcesArgs = {
                    Tuple.Create("searchObjectName", "String"),
                    Tuple.Create("workloadTypes", "[DataGovObjectType!]"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("directResourceAssignmentSortBy", "DirectResourceAssignmentSortBy"),
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                };
            this.AssignmentResources =
                new RscGqlVars(null, assignmentResourcesArgs, null, true);
            Tuple<string, string>[] hierarchyObjectConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.HierarchyObjectConnection =
                new RscGqlVars(null, hierarchyObjectConnectionArgs, null, true);
        }
    }

    public ClassificationPolicyDetail()
    {
        this.Vars = new InlineVars();
    }

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
        DataCategoryResult? DataCategoryResult = null,
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
        if ( DataCategoryResult != null ) {
            this.DataCategoryResult = DataCategoryResult;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        if (this.ColorEnum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "colorEnum\n" ;
            } else {
                s += ind + "colorEnum\n" ;
            }
        }
        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
            }
        }
        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        if (this.HierarchyObjects != null) {
                var fspec = this.HierarchyObjects.AsFieldSpec(conf.Child("hierarchyObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hierarchyObjects" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        if (this.CreatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdTime\n" ;
            } else {
                s += ind + "createdTime\n" ;
            }
        }
        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        if (this.Deletable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletable\n" ;
            } else {
                s += ind + "deletable\n" ;
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
        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        if (this.HierarchyObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hierarchyObjectIds\n" ;
            } else {
                s += ind + "hierarchyObjectIds\n" ;
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
        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        if (this.LastUpdatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedTime\n" ;
            } else {
                s += ind + "lastUpdatedTime\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        if (this.NumAnalyzers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numAnalyzers\n" ;
            } else {
                s += ind + "numAnalyzers\n" ;
            }
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjects\n" ;
            } else {
                s += ind + "totalObjects\n" ;
            }
        }
        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        if (this.Analyzers != null) {
            var fspec = this.Analyzers.AsFieldSpec(conf.Child("analyzers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AssignmentResourceDetailsConnection? AssignmentResources
        // GraphQL -> assignmentResources: AssignmentResourceDetailsConnection! (type)
        if (this.AssignmentResources != null) {
            var fspec = this.AssignmentResources.AsFieldSpec(conf.Child("assignmentResources"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "assignmentResources" + "\n(" + this.Vars.AssignmentResources.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(conf.Child("creator"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "creator" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DataCategoryResult? DataCategoryResult
        // GraphQL -> dataCategoryResult: DataCategoryResult (type)
        if (this.DataCategoryResult != null) {
            var fspec = this.DataCategoryResult.AsFieldSpec(conf.Child("dataCategoryResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategoryResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        if (this.HierarchyObjectConnection != null) {
            var fspec = this.HierarchyObjectConnection.AsFieldSpec(conf.Child("hierarchyObjectConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hierarchyObjectConnection" + "\n(" + this.Vars.HierarchyObjectConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        if (this.ObjectStatuses != null) {
            var fspec = this.ObjectStatuses.AsFieldSpec(conf.Child("objectStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectStatuses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        if (this.Whitelists != null) {
            var fspec = this.Whitelists.AsFieldSpec(conf.Child("whitelists"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "whitelists" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClassificationPolicyColor? ColorEnum
        // GraphQL -> colorEnum: ClassificationPolicyColor! (enum)
        if (ec.Includes("colorEnum",true))
        {
            if(this.ColorEnum == null) {

                this.ColorEnum = new ClassificationPolicyColor();

            } else {


            }
        }
        else if (this.ColorEnum != null && ec.Excludes("colorEnum",true))
        {
            this.ColorEnum = null;
        }
        //      C# -> ClassificationPolicyMode? Mode
        // GraphQL -> mode: ClassificationPolicyMode! (enum)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = new ClassificationPolicyMode();

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
        }
        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject]! (interface)
        if (ec.Includes("hierarchyObjects",false))
        {
            if(this.HierarchyObjects == null) {

                this.HierarchyObjects = new List<HierarchyObject>();
                this.HierarchyObjects.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjects"));

            } else {

                this.HierarchyObjects.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjects"));

            }
        }
        else if (this.HierarchyObjects != null && ec.Excludes("hierarchyObjects",false))
        {
            this.HierarchyObjects = null;
        }
        //      C# -> System.Int64? CreatedTime
        // GraphQL -> createdTime: Long! (scalar)
        if (ec.Includes("createdTime",true))
        {
            if(this.CreatedTime == null) {

                this.CreatedTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreatedTime != null && ec.Excludes("createdTime",true))
        {
            this.CreatedTime = null;
        }
        //      C# -> System.Boolean? Deletable
        // GraphQL -> deletable: Boolean! (scalar)
        if (ec.Includes("deletable",true))
        {
            if(this.Deletable == null) {

                this.Deletable = true;

            } else {


            }
        }
        else if (this.Deletable != null && ec.Excludes("deletable",true))
        {
            this.Deletable = null;
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
        //      C# -> List<System.String>? HierarchyObjectIds
        // GraphQL -> hierarchyObjectIds: [String!]! (scalar)
        if (ec.Includes("hierarchyObjectIds",true))
        {
            if(this.HierarchyObjectIds == null) {

                this.HierarchyObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.HierarchyObjectIds != null && ec.Excludes("hierarchyObjectIds",true))
        {
            this.HierarchyObjectIds = null;
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
        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        if (ec.Includes("lastUpdatedTime",true))
        {
            if(this.LastUpdatedTime == null) {

                this.LastUpdatedTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastUpdatedTime != null && ec.Excludes("lastUpdatedTime",true))
        {
            this.LastUpdatedTime = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? NumAnalyzers
        // GraphQL -> numAnalyzers: Int! (scalar)
        if (ec.Includes("numAnalyzers",true))
        {
            if(this.NumAnalyzers == null) {

                this.NumAnalyzers = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumAnalyzers != null && ec.Excludes("numAnalyzers",true))
        {
            this.NumAnalyzers = null;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (ec.Includes("totalObjects",true))
        {
            if(this.TotalObjects == null) {

                this.TotalObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalObjects != null && ec.Excludes("totalObjects",true))
        {
            this.TotalObjects = null;
        }
        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        if (ec.Includes("analyzers",false))
        {
            if(this.Analyzers == null) {

                this.Analyzers = new List<Analyzer>();
                this.Analyzers.ApplyExploratoryFieldSpec(ec.NewChild("analyzers"));

            } else {

                this.Analyzers.ApplyExploratoryFieldSpec(ec.NewChild("analyzers"));

            }
        }
        else if (this.Analyzers != null && ec.Excludes("analyzers",false))
        {
            this.Analyzers = null;
        }
        //      C# -> AssignmentResourceDetailsConnection? AssignmentResources
        // GraphQL -> assignmentResources: AssignmentResourceDetailsConnection! (type)
        if (ec.Includes("assignmentResources",false))
        {
            if(this.AssignmentResources == null) {

                this.AssignmentResources = new AssignmentResourceDetailsConnection();
                this.AssignmentResources.ApplyExploratoryFieldSpec(ec.NewChild("assignmentResources"));

            } else {

                this.AssignmentResources.ApplyExploratoryFieldSpec(ec.NewChild("assignmentResources"));

            }
        }
        else if (this.AssignmentResources != null && ec.Excludes("assignmentResources",false))
        {
            this.AssignmentResources = null;
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (ec.Includes("creator",false))
        {
            if(this.Creator == null) {

                this.Creator = new User();
                this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));

            } else {

                this.Creator.ApplyExploratoryFieldSpec(ec.NewChild("creator"));

            }
        }
        else if (this.Creator != null && ec.Excludes("creator",false))
        {
            this.Creator = null;
        }
        //      C# -> DataCategoryResult? DataCategoryResult
        // GraphQL -> dataCategoryResult: DataCategoryResult (type)
        if (ec.Includes("dataCategoryResult",false))
        {
            if(this.DataCategoryResult == null) {

                this.DataCategoryResult = new DataCategoryResult();
                this.DataCategoryResult.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryResult"));

            } else {

                this.DataCategoryResult.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryResult"));

            }
        }
        else if (this.DataCategoryResult != null && ec.Excludes("dataCategoryResult",false))
        {
            this.DataCategoryResult = null;
        }
        //      C# -> HierarchyObjectConnection? HierarchyObjectConnection
        // GraphQL -> hierarchyObjectConnection: HierarchyObjectConnection! (type)
        if (ec.Includes("hierarchyObjectConnection",false))
        {
            if(this.HierarchyObjectConnection == null) {

                this.HierarchyObjectConnection = new HierarchyObjectConnection();
                this.HierarchyObjectConnection.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjectConnection"));

            } else {

                this.HierarchyObjectConnection.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObjectConnection"));

            }
        }
        else if (this.HierarchyObjectConnection != null && ec.Excludes("hierarchyObjectConnection",false))
        {
            this.HierarchyObjectConnection = null;
        }
        //      C# -> List<ObjectStatus>? ObjectStatuses
        // GraphQL -> objectStatuses: [ObjectStatus!]! (type)
        if (ec.Includes("objectStatuses",false))
        {
            if(this.ObjectStatuses == null) {

                this.ObjectStatuses = new List<ObjectStatus>();
                this.ObjectStatuses.ApplyExploratoryFieldSpec(ec.NewChild("objectStatuses"));

            } else {

                this.ObjectStatuses.ApplyExploratoryFieldSpec(ec.NewChild("objectStatuses"));

            }
        }
        else if (this.ObjectStatuses != null && ec.Excludes("objectStatuses",false))
        {
            this.ObjectStatuses = null;
        }
        //      C# -> List<ClassificationPolicyWhitelistDetailedEntry>? Whitelists
        // GraphQL -> whitelists: [ClassificationPolicyWhitelistDetailedEntry!]! (type)
        if (ec.Includes("whitelists",false))
        {
            if(this.Whitelists == null) {

                this.Whitelists = new List<ClassificationPolicyWhitelistDetailedEntry>();
                this.Whitelists.ApplyExploratoryFieldSpec(ec.NewChild("whitelists"));

            } else {

                this.Whitelists.ApplyExploratoryFieldSpec(ec.NewChild("whitelists"));

            }
        }
        else if (this.Whitelists != null && ec.Excludes("whitelists",false))
        {
            this.Whitelists = null;
        }
    }


    #endregion

    } // class ClassificationPolicyDetail
    
    #endregion

    public static class ListClassificationPolicyDetailExtensions
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
            this List<ClassificationPolicyDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClassificationPolicyDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ClassificationPolicyDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types