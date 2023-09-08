// MutateRoleReqChangesTemplate.cs
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
    #region MutateRoleReqChangesTemplate
 
    public class MutateRoleReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        [JsonProperty("newPolicies")]
        public List<TprPolicySummary>? NewPolicies { get; set; }

        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        [JsonProperty("oldPolicies")]
        public List<TprPolicySummary>? OldPolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MutateRoleReqChangesTemplate";
    }

    public MutateRoleReqChangesTemplate Set(
        System.String? TemplateName = null,
        List<TprPolicySummary>? NewPolicies = null,
        List<TprPolicySummary>? OldPolicies = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( NewPolicies != null ) {
            this.NewPolicies = NewPolicies;
        }
        if ( OldPolicies != null ) {
            this.OldPolicies = OldPolicies;
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
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            s += ind + "templateName\n" ;
        }
        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        if (this.NewPolicies != null) {
            var fspec = this.NewPolicies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newPolicies {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        if (this.OldPolicies != null) {
            var fspec = this.OldPolicies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldPolicies {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName == null && ec.Includes("templateName",true))
        {
            this.TemplateName = "FETCH";
        }
        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        if (this.NewPolicies == null && ec.Includes("newPolicies",false))
        {
            this.NewPolicies = new List<TprPolicySummary>();
            this.NewPolicies.ApplyExploratoryFieldSpec(ec.NewChild("newPolicies"));
        }
        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        if (this.OldPolicies == null && ec.Includes("oldPolicies",false))
        {
            this.OldPolicies = new List<TprPolicySummary>();
            this.OldPolicies.ApplyExploratoryFieldSpec(ec.NewChild("oldPolicies"));
        }
    }


    #endregion

    } // class MutateRoleReqChangesTemplate
    
    #endregion

    public static class ListMutateRoleReqChangesTemplateExtensions
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
            this List<MutateRoleReqChangesTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MutateRoleReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MutateRoleReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MutateRoleReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types