// AwsNativeRoot.cs
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
    #region AwsNativeRoot
    public class AwsNativeRoot: BaseType
    {
        #region members

        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        [JsonProperty("objectTypeDescendantConnection")]
        public AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection { get; set; }

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
                };
            this.ObjectTypeDescendantConnection =
                new RscGqlVars(null, objectTypeDescendantConnectionArgs, null, true);
        }
    }

    public AwsNativeRoot()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AwsNativeRoot";
    }

    public AwsNativeRoot Set(
        AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection = null
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        if (this.ObjectTypeDescendantConnection != null) {
            var fspec = this.ObjectTypeDescendantConnection.AsFieldSpec(conf.Child("objectTypeDescendantConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        if (ec.Includes("objectTypeDescendantConnection",false))
        {
            if(this.ObjectTypeDescendantConnection == null) {

                this.ObjectTypeDescendantConnection = new AwsNativeHierarchyObjectConnection();
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

    } // class AwsNativeRoot
    
    #endregion

    public static class ListAwsNativeRootExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsNativeRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeRoot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types