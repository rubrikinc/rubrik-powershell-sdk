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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region PolicyDetail
    public class PolicyDetail: BaseType
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

    public override string GetGqlTypeName() {
        return "PolicyDetail";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? Analyzers
        // GraphQL -> analyzers: Int! (scalar)
        if (this.Analyzers != null) {
            s += ind + "analyzers\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
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
        //      C# -> System.Int32? PendingAnalysisObjects
        // GraphQL -> pendingAnalysisObjects: Int! (scalar)
        if (this.PendingAnalysisObjects != null) {
            s += ind + "pendingAnalysisObjects\n" ;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects != null) {
            s += ind + "totalObjects\n" ;
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "creator {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Analyzers
        // GraphQL -> analyzers: Int! (scalar)
        if (this.Analyzers == null && Exploration.Includes(parent + ".analyzers", true))
        {
            this.Analyzers = Int32.MinValue;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? LastUpdatedTime
        // GraphQL -> lastUpdatedTime: Long! (scalar)
        if (this.LastUpdatedTime == null && Exploration.Includes(parent + ".lastUpdatedTime", true))
        {
            this.LastUpdatedTime = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? PendingAnalysisObjects
        // GraphQL -> pendingAnalysisObjects: Int! (scalar)
        if (this.PendingAnalysisObjects == null && Exploration.Includes(parent + ".pendingAnalysisObjects", true))
        {
            this.PendingAnalysisObjects = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalObjects
        // GraphQL -> totalObjects: Int! (scalar)
        if (this.TotalObjects == null && Exploration.Includes(parent + ".totalObjects", true))
        {
            this.TotalObjects = Int32.MinValue;
        }
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator == null && Exploration.Includes(parent + ".creator"))
        {
            this.Creator = new User();
            this.Creator.ApplyExploratoryFieldSpec(parent + ".creator");
        }
    }


    #endregion

    } // class PolicyDetail
    
    #endregion

    public static class ListPolicyDetailExtensions
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
            this List<PolicyDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types