// TprPolicyDetail.cs
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
    #region TprPolicyDetail
    public class TprPolicyDetail: BaseType
    {
        #region members

        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        [JsonProperty("policyScope")]
        public TprPolicyScope? PolicyScope { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [String!]! (scalar)
        [JsonProperty("exemptServiceAccounts")]
        public List<System.String>? ExemptServiceAccounts { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        [JsonProperty("createdBy")]
        public UserSummary? CreatedBy { get; set; }

        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        [JsonProperty("policyRules")]
        public List<TprPolicyRule>? PolicyRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprPolicyDetail";
    }

    public TprPolicyDetail Set(
        TprPolicyScope? PolicyScope = null,
        DateTime? CreatedAt = null,
        System.String? Description = null,
        List<System.String>? ExemptServiceAccounts = null,
        System.String? Name = null,
        System.String? PolicyId = null,
        UserSummary? CreatedBy = null,
        List<TprPolicyRule>? PolicyRules = null
    ) 
    {
        if ( PolicyScope != null ) {
            this.PolicyScope = PolicyScope;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( ExemptServiceAccounts != null ) {
            this.ExemptServiceAccounts = ExemptServiceAccounts;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( PolicyRules != null ) {
            this.PolicyRules = PolicyRules;
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
        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        if (this.PolicyScope != null) {
            s += ind + "policyScope\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> List<System.String>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [String!]! (scalar)
        if (this.ExemptServiceAccounts != null) {
            s += ind + "exemptServiceAccounts\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        if (this.CreatedBy != null) {
            var fspec = this.CreatedBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "createdBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        if (this.PolicyRules != null) {
            var fspec = this.PolicyRules.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyRules {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TprPolicyScope? PolicyScope
        // GraphQL -> policyScope: TprPolicyScope! (enum)
        if (this.PolicyScope == null && Exploration.Includes(parent + ".policyScope", true))
        {
            this.PolicyScope = new TprPolicyScope();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> List<System.String>? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: [String!]! (scalar)
        if (this.ExemptServiceAccounts == null && Exploration.Includes(parent + ".exemptServiceAccounts", true))
        {
            this.ExemptServiceAccounts = new List<System.String>();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = "FETCH";
        }
        //      C# -> UserSummary? CreatedBy
        // GraphQL -> createdBy: UserSummary (type)
        if (this.CreatedBy == null && Exploration.Includes(parent + ".createdBy"))
        {
            this.CreatedBy = new UserSummary();
            this.CreatedBy.ApplyExploratoryFieldSpec(parent + ".createdBy");
        }
        //      C# -> List<TprPolicyRule>? PolicyRules
        // GraphQL -> policyRules: [TprPolicyRule!]! (type)
        if (this.PolicyRules == null && Exploration.Includes(parent + ".policyRules"))
        {
            this.PolicyRules = new List<TprPolicyRule>();
            this.PolicyRules.ApplyExploratoryFieldSpec(parent + ".policyRules");
        }
    }


    #endregion

    } // class TprPolicyDetail
    
    #endregion

    public static class ListTprPolicyDetailExtensions
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
            this List<TprPolicyDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprPolicyDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprPolicyDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types