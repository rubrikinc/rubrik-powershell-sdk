// PolarisInventorySubHierarchyRoot.cs
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
    #region PolarisInventorySubHierarchyRoot
    public class PolarisInventorySubHierarchyRoot: BaseType
    {
        #region members

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("childConnection")]
        public PolarisHierarchyObjectConnection? ChildConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public PolarisHierarchyObjectConnection? DescendantConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("topLevelDescendantConnection")]
        public PolarisHierarchyObjectConnection? TopLevelDescendantConnection { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ChildConnection { get; set; }

        public RscGqlVars DescendantConnection { get; set; }

        public RscGqlVars TopLevelDescendantConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] childConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                    Tuple.Create("filter", "[Filter!]"),
                    Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                };
            this.ChildConnection =
                new RscGqlVars(null, childConnectionArgs, null, true);
            Tuple<string, string>[] descendantConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                    Tuple.Create("filter", "[Filter!]"),
                    Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                };
            this.DescendantConnection =
                new RscGqlVars(null, descendantConnectionArgs, null, true);
            Tuple<string, string>[] topLevelDescendantConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                    Tuple.Create("filter", "[Filter!]"),
                };
            this.TopLevelDescendantConnection =
                new RscGqlVars(null, topLevelDescendantConnectionArgs, null, true);
        }
    }

    public PolarisInventorySubHierarchyRoot()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "PolarisInventorySubHierarchyRoot";
    }

    public PolarisInventorySubHierarchyRoot Set(
        InventorySubHierarchyRootEnum? RootEnum = null,
        PolarisHierarchyObjectConnection? ChildConnection = null,
        PolarisHierarchyObjectConnection? DescendantConnection = null,
        PolarisHierarchyObjectConnection? TopLevelDescendantConnection = null
    ) 
    {
        if ( RootEnum != null ) {
            this.RootEnum = RootEnum;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( TopLevelDescendantConnection != null ) {
            this.TopLevelDescendantConnection = TopLevelDescendantConnection;
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
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootEnum\n" ;
            } else {
                s += ind + "rootEnum\n" ;
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(conf.Child("childConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childConnection" + "\n(" + this.Vars.ChildConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(conf.Child("descendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "descendantConnection" + "\n(" + this.Vars.DescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection != null) {
            var fspec = this.TopLevelDescendantConnection.AsFieldSpec(conf.Child("topLevelDescendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "topLevelDescendantConnection" + "\n(" + this.Vars.TopLevelDescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (ec.Includes("rootEnum",true))
        {
            if(this.RootEnum == null) {

                this.RootEnum = new InventorySubHierarchyRootEnum();

            } else {


            }
        }
        else if (this.RootEnum != null && ec.Excludes("rootEnum",true))
        {
            this.RootEnum = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("childConnection",false))
        {
            if(this.ChildConnection == null) {

                this.ChildConnection = new PolarisHierarchyObjectConnection();
                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            } else {

                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            }
        }
        else if (this.ChildConnection != null && ec.Excludes("childConnection",false))
        {
            this.ChildConnection = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("descendantConnection",false))
        {
            if(this.DescendantConnection == null) {

                this.DescendantConnection = new PolarisHierarchyObjectConnection();
                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            } else {

                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            }
        }
        else if (this.DescendantConnection != null && ec.Excludes("descendantConnection",false))
        {
            this.DescendantConnection = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("topLevelDescendantConnection",false))
        {
            if(this.TopLevelDescendantConnection == null) {

                this.TopLevelDescendantConnection = new PolarisHierarchyObjectConnection();
                this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("topLevelDescendantConnection"));

            } else {

                this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("topLevelDescendantConnection"));

            }
        }
        else if (this.TopLevelDescendantConnection != null && ec.Excludes("topLevelDescendantConnection",false))
        {
            this.TopLevelDescendantConnection = null;
        }
    }


    #endregion

    } // class PolarisInventorySubHierarchyRoot
    
    #endregion

    public static class ListPolarisInventorySubHierarchyRootExtensions
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
            this List<PolarisInventorySubHierarchyRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisInventorySubHierarchyRoot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisInventorySubHierarchyRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisInventorySubHierarchyRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisInventorySubHierarchyRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types