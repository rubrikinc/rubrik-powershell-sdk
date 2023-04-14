// PolicyDetail.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region PolicyDetail
    public class PolicyDetail: IFragment
    {
        #region members
        //      C# -> System.Int32? Analyzers
        // GraphQL -> analyzers: Int! (scalar)
        [JsonProperty("analyzers")]
        public System.Int32? Analyzers { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

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

        //      C# -> System.Int32? PendingAnalysisObjects
        // GraphQL -> pendingAnalysisObjects: Int! (scalar)
        [JsonProperty("pendingAnalysisObjects")]
        public System.Int32? PendingAnalysisObjects { get; set; }

        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        [JsonProperty("totalObjects")]
        public System.Int32? TotalObjects { get; set; }

        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        [JsonProperty("creator")]
        public User? Creator { get; set; }

        #endregion

    #region methods

    public PolicyDetail Set(
        System.Int32? Analyzers = null,
        System.String? Description = null,
        System.String? Id = null,
        System.Int64? LastUpdatedTime = null,
        System.String? Name = null,
        System.Int32? PendingAnalysisObjects = null,
        System.Int32? TotalObjects = null,
        User? Creator = null
    ) 
    {
        if ( Analyzers != null ) {
            this.Analyzers = Analyzers;
        }
        if ( Description != null ) {
            this.Description = Description;
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
        if ( PendingAnalysisObjects != null ) {
            this.PendingAnalysisObjects = PendingAnalysisObjects;
        }
        if ( TotalObjects != null ) {
            this.TotalObjects = TotalObjects;
        }
        if ( Creator != null ) {
            this.Creator = Creator;
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
            //      C# -> System.Int32? Analyzers
            // GraphQL -> analyzers: Int! (scalar)
            if (this.Analyzers != null)
            {
                 s += ind + "analyzers\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? LastUpdatedTime
            // GraphQL -> lastUpdatedTime: Long! (scalar)
            if (this.LastUpdatedTime != null)
            {
                 s += ind + "lastUpdatedTime\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? PendingAnalysisObjects
            // GraphQL -> pendingAnalysisObjects: Int! (scalar)
            if (this.PendingAnalysisObjects != null)
            {
                 s += ind + "pendingAnalysisObjects\n";

            }
            //      C# -> System.Int32? TotalObjects
            // GraphQL -> totalObjects: Int! (scalar)
            if (this.TotalObjects != null)
            {
                 s += ind + "totalObjects\n";

            }
            //      C# -> User? Creator
            // GraphQL -> creator: User (type)
            if (this.Creator != null)
            {
                 s += ind + "creator\n";

                 s += ind + "{\n" + 
                 this.Creator.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Analyzers
            // GraphQL -> analyzers: Int! (scalar)
            if (this.Analyzers == null && Exploration.Includes(parent + ".analyzers$"))
            {
                this.Analyzers = new System.Int32();
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? LastUpdatedTime
            // GraphQL -> lastUpdatedTime: Long! (scalar)
            if (this.LastUpdatedTime == null && Exploration.Includes(parent + ".lastUpdatedTime$"))
            {
                this.LastUpdatedTime = new System.Int64();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? PendingAnalysisObjects
            // GraphQL -> pendingAnalysisObjects: Int! (scalar)
            if (this.PendingAnalysisObjects == null && Exploration.Includes(parent + ".pendingAnalysisObjects$"))
            {
                this.PendingAnalysisObjects = new System.Int32();
            }
            //      C# -> System.Int32? TotalObjects
            // GraphQL -> totalObjects: Int! (scalar)
            if (this.TotalObjects == null && Exploration.Includes(parent + ".totalObjects$"))
            {
                this.TotalObjects = new System.Int32();
            }
            //      C# -> User? Creator
            // GraphQL -> creator: User (type)
            if (this.Creator == null && Exploration.Includes(parent + ".creator"))
            {
                this.Creator = new User();
                this.Creator.ApplyExploratoryFragment(parent + ".creator");
            }
        }


    #endregion

    } // class PolicyDetail
    #endregion

    public static class ListPolicyDetailExtensions
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
            this List<PolicyDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolicyDetail> list, 
            String parent = "")
        {
            var item = new PolicyDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types