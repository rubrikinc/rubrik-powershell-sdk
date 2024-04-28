// InventoryRoot.cs
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
    #region InventoryRoot
    public class InventoryRoot: BaseType
    {
        #region members

        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public HierarchyObjectConnection? DescendantConnection { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars DescendantConnection { get; set; }


        public InlineVars() {
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
        }
    }

    public InventoryRoot()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "InventoryRoot";
    }

    public InventoryRoot Set(
        HierarchyObjectConnection? DescendantConnection = null
    ) 
    {
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
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
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(conf.Child("descendantConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "descendantConnection" + "\n(" + this.Vars.DescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (ec.Includes("descendantConnection",false))
        {
            if(this.DescendantConnection == null) {

                this.DescendantConnection = new HierarchyObjectConnection();
                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            } else {

                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            }
        }
        else if (this.DescendantConnection != null && ec.Excludes("descendantConnection",false))
        {
            this.DescendantConnection = null;
        }
    }


    #endregion

    } // class InventoryRoot
    
    #endregion

    public static class ListInventoryRootExtensions
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
            this List<InventoryRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InventoryRoot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InventoryRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InventoryRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InventoryRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types