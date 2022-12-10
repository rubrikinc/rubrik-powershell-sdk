// DhrcActiveRecommendation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    #region DhrcActiveRecommendation
    public class DhrcActiveRecommendation: IFragment
    {
        #region members
        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        [JsonProperty("compiledAt")]
        public DateTime? CompiledAt { get; set; }

        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        [JsonProperty("earliestMetric")]
        public DateTime? EarliestMetric { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        [JsonProperty("weight")]
        public System.Single? Weight { get; set; }

        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        [JsonProperty("translationArgs")]
        public List<DhrcKeyValue>? TranslationArgs { get; set; }

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        [JsonProperty("key")]
        public DhrcRecommendationKey? Key { get; set; }

        #endregion

    #region methods

    public DhrcActiveRecommendation Set(
        DateTime? CompiledAt = null,
        DateTime? EarliestMetric = null,
        System.String? Message = null,
        System.Single? Weight = null,
        List<DhrcKeyValue>? TranslationArgs = null,
        DhrcCategory? Category = null,
        DhrcRecommendationKey? Key = null
    ) 
    {
        if ( CompiledAt != null ) {
            this.CompiledAt = CompiledAt;
        }
        if ( EarliestMetric != null ) {
            this.EarliestMetric = EarliestMetric;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
        }
        if ( TranslationArgs != null ) {
            this.TranslationArgs = TranslationArgs;
        }
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Key != null ) {
            this.Key = Key;
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
            //      C# -> DateTime? CompiledAt
            // GraphQL -> compiledAt: DateTime (scalar)
            if (this.CompiledAt != null)
            {
                 s += ind + "compiledAt\n";

            }
            //      C# -> DateTime? EarliestMetric
            // GraphQL -> earliestMetric: DateTime (scalar)
            if (this.EarliestMetric != null)
            {
                 s += ind + "earliestMetric\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.Single? Weight
            // GraphQL -> weight: Float! (scalar)
            if (this.Weight != null)
            {
                 s += ind + "weight\n";

            }
            //      C# -> List<DhrcKeyValue>? TranslationArgs
            // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
            if (this.TranslationArgs != null)
            {
                 s += ind + "translationArgs\n";

                 s += ind + "{\n" + 
                 this.TranslationArgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DhrcCategory? Category
            // GraphQL -> category: DhrcCategory! (enum)
            if (this.Category != null)
            {
                 s += ind + "category\n";

            }
            //      C# -> DhrcRecommendationKey? Key
            // GraphQL -> key: DhrcRecommendationKey! (enum)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CompiledAt
            // GraphQL -> compiledAt: DateTime (scalar)
            if (this.CompiledAt == null && Exploration.Includes(parent + ".compiledAt$"))
            {
                this.CompiledAt = new DateTime();
            }
            //      C# -> DateTime? EarliestMetric
            // GraphQL -> earliestMetric: DateTime (scalar)
            if (this.EarliestMetric == null && Exploration.Includes(parent + ".earliestMetric$"))
            {
                this.EarliestMetric = new DateTime();
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.Single? Weight
            // GraphQL -> weight: Float! (scalar)
            if (this.Weight == null && Exploration.Includes(parent + ".weight$"))
            {
                this.Weight = new System.Single();
            }
            //      C# -> List<DhrcKeyValue>? TranslationArgs
            // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
            if (this.TranslationArgs == null && Exploration.Includes(parent + ".translationArgs"))
            {
                this.TranslationArgs = new List<DhrcKeyValue>();
                this.TranslationArgs.ApplyExploratoryFragment(parent + ".translationArgs");
            }
            //      C# -> DhrcCategory? Category
            // GraphQL -> category: DhrcCategory! (enum)
            if (this.Category == null && Exploration.Includes(parent + ".category$"))
            {
                this.Category = new DhrcCategory();
            }
            //      C# -> DhrcRecommendationKey? Key
            // GraphQL -> key: DhrcRecommendationKey! (enum)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new DhrcRecommendationKey();
            }
        }


    #endregion

    } // class DhrcActiveRecommendation
    #endregion

    public static class ListDhrcActiveRecommendationExtensions
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
            this List<DhrcActiveRecommendation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DhrcActiveRecommendation> list, 
            String parent = "")
        {
            var item = new DhrcActiveRecommendation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types