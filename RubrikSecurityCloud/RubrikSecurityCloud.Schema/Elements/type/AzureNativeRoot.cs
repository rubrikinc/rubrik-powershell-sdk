// AzureNativeRoot.cs
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
    #region AzureNativeRoot
    public class AzureNativeRoot: BaseType
    {
        #region members

        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        [JsonProperty("objectTypeDescendantConnection")]
        public AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ObjectTypeDescendantConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] objectTypeDescendantConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("objectTypeFilter", "HierarchyObjectTypeEnum!"),
                    Tuple.Create("filter", "[Filter!]"),
                    Tuple.Create("includeSecurityMetadata", "Boolean"),
                    Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                };
            this.ObjectTypeDescendantConnection =
                new RscGqlVars(null, objectTypeDescendantConnectionArgs, null, true);
        }
    }

    public AzureNativeRoot()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AzureNativeRoot";
    }

    public AzureNativeRoot Set(
        AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection = null
    ) 
    {
        if ( ObjectTypeDescendantConnection != null ) {
            this.ObjectTypeDescendantConnection = ObjectTypeDescendantConnection;
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
        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        if (this.ObjectTypeDescendantConnection != null) {
            var fspec = this.ObjectTypeDescendantConnection.AsFieldSpec(conf.Child("objectTypeDescendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectTypeDescendantConnection" + "\n(" + this.Vars.ObjectTypeDescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureNativeHierarchyObjectTypeConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AzureNativeHierarchyObjectTypeConnection! (type)
        if (ec.Includes("objectTypeDescendantConnection",false))
        {
            if(this.ObjectTypeDescendantConnection == null) {

                this.ObjectTypeDescendantConnection = new AzureNativeHierarchyObjectTypeConnection();
                this.ObjectTypeDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeDescendantConnection"));

            } else {

                this.ObjectTypeDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeDescendantConnection"));

            }
        }
        else if (this.ObjectTypeDescendantConnection != null && ec.Excludes("objectTypeDescendantConnection",false))
        {
            this.ObjectTypeDescendantConnection = null;
        }
    }


    #endregion

    } // class AzureNativeRoot
    
    #endregion

    public static class ListAzureNativeRootExtensions
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
            this List<AzureNativeRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeRoot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types