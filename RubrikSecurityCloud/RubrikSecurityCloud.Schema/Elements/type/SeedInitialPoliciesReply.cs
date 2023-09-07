// SeedInitialPoliciesReply.cs
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
    #region SeedInitialPoliciesReply
    public class SeedInitialPoliciesReply: BaseType
    {
        #region members

        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicyDetail>? Policies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SeedInitialPoliciesReply";
    }

    public SeedInitialPoliciesReply Set(
        List<ClassificationPolicyDetail>? Policies = null
    ) 
    {
        if ( Policies != null ) {
            this.Policies = Policies;
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
        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policies {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        if (this.Policies == null && ec.Includes("policies",false))
        {
            this.Policies = new List<ClassificationPolicyDetail>();
            this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));
        }
    }


    #endregion

    } // class SeedInitialPoliciesReply
    
    #endregion

    public static class ListSeedInitialPoliciesReplyExtensions
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
            this List<SeedInitialPoliciesReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SeedInitialPoliciesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SeedInitialPoliciesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SeedInitialPoliciesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types