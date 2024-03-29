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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? Analyzers
        // GraphQL -> analyzers: Int! (scalar)
        if (this.Analyzers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzers\n" ;
            } else {
                s += ind + "analyzers\n" ;
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
        //      C# -> System.Int32? PendingAnalysisObjects
        // GraphQL -> pendingAnalysisObjects: Int! (scalar)
        if (this.PendingAnalysisObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingAnalysisObjects\n" ;
            } else {
                s += ind + "pendingAnalysisObjects\n" ;
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
        //      C# -> User? Creator
        // GraphQL -> creator: User (type)
        if (this.Creator != null) {
            var fspec = this.Creator.AsFieldSpec(conf.Child("creator"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "creator {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Analyzers
        // GraphQL -> analyzers: Int! (scalar)
        if (ec.Includes("analyzers",true))
        {
            if(this.Analyzers == null) {

                this.Analyzers = Int32.MinValue;

            } else {


            }
        }
        else if (this.Analyzers != null && ec.Excludes("analyzers",true))
        {
            this.Analyzers = null;
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
        //      C# -> System.Int32? PendingAnalysisObjects
        // GraphQL -> pendingAnalysisObjects: Int! (scalar)
        if (ec.Includes("pendingAnalysisObjects",true))
        {
            if(this.PendingAnalysisObjects == null) {

                this.PendingAnalysisObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.PendingAnalysisObjects != null && ec.Excludes("pendingAnalysisObjects",true))
        {
            this.PendingAnalysisObjects = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PolicyDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types