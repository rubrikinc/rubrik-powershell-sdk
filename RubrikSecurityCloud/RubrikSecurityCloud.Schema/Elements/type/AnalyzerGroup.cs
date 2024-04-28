// AnalyzerGroup.cs
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
    #region AnalyzerGroup
    public class AnalyzerGroup: BaseType
    {
        #region members

        //      C# -> AnalyzerGroupTypeEnum? GroupType
        // GraphQL -> groupType: AnalyzerGroupTypeEnum! (enum)
        [JsonProperty("groupType")]
        public AnalyzerGroupTypeEnum? GroupType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        [JsonProperty("analyzers")]
        public List<Analyzer>? Analyzers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerGroup";
    }

    public AnalyzerGroup Set(
        AnalyzerGroupTypeEnum? GroupType = null,
        System.String? Id = null,
        System.String? Name = null,
        List<Analyzer>? Analyzers = null
    ) 
    {
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Analyzers != null ) {
            this.Analyzers = Analyzers;
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
        //      C# -> AnalyzerGroupTypeEnum? GroupType
        // GraphQL -> groupType: AnalyzerGroupTypeEnum! (enum)
        if (this.GroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupType\n" ;
            } else {
                s += ind + "groupType\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<Analyzer>? Analyzers
        // GraphQL -> analyzers: [Analyzer!]! (type)
        if (this.Analyzers != null) {
            var fspec = this.Analyzers.AsFieldSpec(conf.Child("analyzers"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnalyzerGroupTypeEnum? GroupType
        // GraphQL -> groupType: AnalyzerGroupTypeEnum! (enum)
        if (ec.Includes("groupType",true))
        {
            if(this.GroupType == null) {

                this.GroupType = new AnalyzerGroupTypeEnum();

            } else {


            }
        }
        else if (this.GroupType != null && ec.Excludes("groupType",true))
        {
            this.GroupType = null;
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
    }


    #endregion

    } // class AnalyzerGroup
    
    #endregion

    public static class ListAnalyzerGroupExtensions
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
            this List<AnalyzerGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerGroup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types