// TprPolicyRule.cs
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
    #region TprPolicyRule
    public class TprPolicyRule: BaseType
    {
        #region members

        //      C# -> List<TprRule>? TprRules
        // GraphQL -> tprRules: [TprRule!]! (enum)
        [JsonProperty("tprRules")]
        public List<TprRule>? TprRules { get; set; }

        //      C# -> TprPolicyObject? TprPolicyObject
        // GraphQL -> tprPolicyObject: TprPolicyObject (type)
        [JsonProperty("tprPolicyObject")]
        public TprPolicyObject? TprPolicyObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprPolicyRule";
    }

    public TprPolicyRule Set(
        List<TprRule>? TprRules = null,
        TprPolicyObject? TprPolicyObject = null
    ) 
    {
        if ( TprRules != null ) {
            this.TprRules = TprRules;
        }
        if ( TprPolicyObject != null ) {
            this.TprPolicyObject = TprPolicyObject;
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
        //      C# -> List<TprRule>? TprRules
        // GraphQL -> tprRules: [TprRule!]! (enum)
        if (this.TprRules != null) {
            s += ind + "tprRules\n" ;
        }
        //      C# -> TprPolicyObject? TprPolicyObject
        // GraphQL -> tprPolicyObject: TprPolicyObject (type)
        if (this.TprPolicyObject != null) {
            var fspec = this.TprPolicyObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tprPolicyObject {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<TprRule>? TprRules
        // GraphQL -> tprRules: [TprRule!]! (enum)
        if (this.TprRules == null && Exploration.Includes(parent + ".tprRules", true))
        {
            this.TprRules = new List<TprRule>();
        }
        //      C# -> TprPolicyObject? TprPolicyObject
        // GraphQL -> tprPolicyObject: TprPolicyObject (type)
        if (this.TprPolicyObject == null && Exploration.Includes(parent + ".tprPolicyObject"))
        {
            this.TprPolicyObject = new TprPolicyObject();
            this.TprPolicyObject.ApplyExploratoryFieldSpec(parent + ".tprPolicyObject");
        }
    }


    #endregion

    } // class TprPolicyRule
    
    #endregion

    public static class ListTprPolicyRuleExtensions
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
            this List<TprPolicyRule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprPolicyRule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprPolicyRule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types