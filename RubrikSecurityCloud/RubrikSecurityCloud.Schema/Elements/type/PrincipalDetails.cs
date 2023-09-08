// PrincipalDetails.cs
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
    #region PrincipalDetails
    public class PrincipalDetails: BaseType
    {
        #region members

        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        [JsonProperty("directGroups")]
        public List<UserAccessGroup>? DirectGroups { get; set; }

        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        [JsonProperty("principalSummary")]
        public PrincipalSummary? PrincipalSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalDetails";
    }

    public PrincipalDetails Set(
        List<UserAccessGroup>? DirectGroups = null,
        PrincipalSummary? PrincipalSummary = null
    ) 
    {
        if ( DirectGroups != null ) {
            this.DirectGroups = DirectGroups;
        }
        if ( PrincipalSummary != null ) {
            this.PrincipalSummary = PrincipalSummary;
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
        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        if (this.DirectGroups != null) {
            var fspec = this.DirectGroups.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "directGroups {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        if (this.PrincipalSummary != null) {
            var fspec = this.PrincipalSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "principalSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAccessGroup>? DirectGroups
        // GraphQL -> directGroups: [UserAccessGroup!]! (type)
        if (this.DirectGroups == null && ec.Includes("directGroups",false))
        {
            this.DirectGroups = new List<UserAccessGroup>();
            this.DirectGroups.ApplyExploratoryFieldSpec(ec.NewChild("directGroups"));
        }
        //      C# -> PrincipalSummary? PrincipalSummary
        // GraphQL -> principalSummary: PrincipalSummary! (type)
        if (this.PrincipalSummary == null && ec.Includes("principalSummary",false))
        {
            this.PrincipalSummary = new PrincipalSummary();
            this.PrincipalSummary.ApplyExploratoryFieldSpec(ec.NewChild("principalSummary"));
        }
    }


    #endregion

    } // class PrincipalDetails
    
    #endregion

    public static class ListPrincipalDetailsExtensions
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
            this List<PrincipalDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PrincipalDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types