// TopRiskPrincipalsReply.cs
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
    #region TopRiskPrincipalsReply
    public class TopRiskPrincipalsReply: BaseType
    {
        #region members

        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        [JsonProperty("latestTimelineDate")]
        public System.Int64? LatestTimelineDate { get; set; }

        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        [JsonProperty("topRiskPrincipalSummaries")]
        public List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TopRiskPrincipalsReply";
    }

    public TopRiskPrincipalsReply Set(
        System.Int64? LatestTimelineDate = null,
        List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries = null
    ) 
    {
        if ( LatestTimelineDate != null ) {
            this.LatestTimelineDate = LatestTimelineDate;
        }
        if ( TopRiskPrincipalSummaries != null ) {
            this.TopRiskPrincipalSummaries = TopRiskPrincipalSummaries;
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
        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        if (this.LatestTimelineDate != null) {
            s += ind + "latestTimelineDate\n" ;
        }
        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        if (this.TopRiskPrincipalSummaries != null) {
            var fspec = this.TopRiskPrincipalSummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "topRiskPrincipalSummaries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? LatestTimelineDate
        // GraphQL -> latestTimelineDate: Long! (scalar)
        if (this.LatestTimelineDate == null && ec.Includes("latestTimelineDate",true))
        {
            this.LatestTimelineDate = new System.Int64();
        }
        //      C# -> List<TopRiskPrincipalSummary>? TopRiskPrincipalSummaries
        // GraphQL -> topRiskPrincipalSummaries: [TopRiskPrincipalSummary!]! (type)
        if (this.TopRiskPrincipalSummaries == null && ec.Includes("topRiskPrincipalSummaries",false))
        {
            this.TopRiskPrincipalSummaries = new List<TopRiskPrincipalSummary>();
            this.TopRiskPrincipalSummaries.ApplyExploratoryFieldSpec(ec.NewChild("topRiskPrincipalSummaries"));
        }
    }


    #endregion

    } // class TopRiskPrincipalsReply
    
    #endregion

    public static class ListTopRiskPrincipalsReplyExtensions
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
            this List<TopRiskPrincipalsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TopRiskPrincipalsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TopRiskPrincipalsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TopRiskPrincipalsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types