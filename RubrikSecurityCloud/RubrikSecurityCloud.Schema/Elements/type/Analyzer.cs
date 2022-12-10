// Analyzer.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region Analyzer
    public class Analyzer: IFragment
    {
        #region members
        //      C# -> List<System.String>? Dictionary
        // GraphQL -> dictionary: [String!]! (scalar)
        [JsonProperty("dictionary")]
        public List<System.String>? Dictionary { get; set; }

        //      C# -> System.String? DictionaryCsv
        // GraphQL -> dictionaryCsv: String! (scalar)
        [JsonProperty("dictionaryCsv")]
        public System.String? DictionaryCsv { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Regex
        // GraphQL -> regex: String! (scalar)
        [JsonProperty("regex")]
        public System.String? Regex { get; set; }

        //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
        // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
        [JsonProperty("analyzerRiskInstance")]
        public AnalyzerRiskInstance? AnalyzerRiskInstance { get; set; }

        //      C# -> AnalyzerTypeEnum? AnalyzerType
        // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
        [JsonProperty("analyzerType")]
        public AnalyzerTypeEnum? AnalyzerType { get; set; }

        #endregion

    #region methods

    public Analyzer Set(
        List<System.String>? Dictionary = null,
        System.String? DictionaryCsv = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Regex = null,
        AnalyzerRiskInstance? AnalyzerRiskInstance = null,
        AnalyzerTypeEnum? AnalyzerType = null
    ) 
    {
        if ( Dictionary != null ) {
            this.Dictionary = Dictionary;
        }
        if ( DictionaryCsv != null ) {
            this.DictionaryCsv = DictionaryCsv;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Regex != null ) {
            this.Regex = Regex;
        }
        if ( AnalyzerRiskInstance != null ) {
            this.AnalyzerRiskInstance = AnalyzerRiskInstance;
        }
        if ( AnalyzerType != null ) {
            this.AnalyzerType = AnalyzerType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? Dictionary
            // GraphQL -> dictionary: [String!]! (scalar)
            if (this.Dictionary != null)
            {
                 s += ind + "dictionary\n";

            }
            //      C# -> System.String? DictionaryCsv
            // GraphQL -> dictionaryCsv: String! (scalar)
            if (this.DictionaryCsv != null)
            {
                 s += ind + "dictionaryCsv\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? Regex
            // GraphQL -> regex: String! (scalar)
            if (this.Regex != null)
            {
                 s += ind + "regex\n";

            }
            //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
            // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
            if (this.AnalyzerRiskInstance != null)
            {
                 s += ind + "analyzerRiskInstance\n";

                 s += ind + "{\n" + 
                 this.AnalyzerRiskInstance.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnalyzerTypeEnum? AnalyzerType
            // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
            if (this.AnalyzerType != null)
            {
                 s += ind + "analyzerType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Dictionary
            // GraphQL -> dictionary: [String!]! (scalar)
            if (this.Dictionary == null && Exploration.Includes(parent + ".dictionary$"))
            {
                this.Dictionary = new List<System.String>();
            }
            //      C# -> System.String? DictionaryCsv
            // GraphQL -> dictionaryCsv: String! (scalar)
            if (this.DictionaryCsv == null && Exploration.Includes(parent + ".dictionaryCsv$"))
            {
                this.DictionaryCsv = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? Regex
            // GraphQL -> regex: String! (scalar)
            if (this.Regex == null && Exploration.Includes(parent + ".regex$"))
            {
                this.Regex = new System.String("FETCH");
            }
            //      C# -> AnalyzerRiskInstance? AnalyzerRiskInstance
            // GraphQL -> analyzerRiskInstance: AnalyzerRiskInstance (type)
            if (this.AnalyzerRiskInstance == null && Exploration.Includes(parent + ".analyzerRiskInstance"))
            {
                this.AnalyzerRiskInstance = new AnalyzerRiskInstance();
                this.AnalyzerRiskInstance.ApplyExploratoryFragment(parent + ".analyzerRiskInstance");
            }
            //      C# -> AnalyzerTypeEnum? AnalyzerType
            // GraphQL -> analyzerType: AnalyzerTypeEnum! (enum)
            if (this.AnalyzerType == null && Exploration.Includes(parent + ".analyzerType$"))
            {
                this.AnalyzerType = new AnalyzerTypeEnum();
            }
        }


    #endregion

    } // class Analyzer
    #endregion

    public static class ListAnalyzerExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Analyzer> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Analyzer> list, 
            String parent = "")
        {
            var item = new Analyzer();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types