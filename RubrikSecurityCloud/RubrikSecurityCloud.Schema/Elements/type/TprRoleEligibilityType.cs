// TprRoleEligibilityType.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region TprRoleEligibilityType
    public class TprRoleEligibilityType: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsTprRoleEligible
        // GraphQL -> isTprRoleEligible: Boolean! (scalar)
        [JsonProperty("isTprRoleEligible")]
        public System.Boolean? IsTprRoleEligible { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public TprRoleEligibilityType Set(
        System.Boolean? IsTprRoleEligible = null,
        System.String? Reason = null
    ) 
    {
        if ( IsTprRoleEligible != null ) {
            this.IsTprRoleEligible = IsTprRoleEligible;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> System.Boolean? IsTprRoleEligible
        // GraphQL -> isTprRoleEligible: Boolean! (scalar)
        if (this.IsTprRoleEligible != null) {
            s += ind + "isTprRoleEligible\n" ;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason != null) {
            s += ind + "reason\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsTprRoleEligible
        // GraphQL -> isTprRoleEligible: Boolean! (scalar)
        if (this.IsTprRoleEligible == null && Exploration.Includes(parent + ".isTprRoleEligible", true))
        {
            this.IsTprRoleEligible = true;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason == null && Exploration.Includes(parent + ".reason", true))
        {
            this.Reason = "FETCH";
        }
    }


    #endregion

    } // class TprRoleEligibilityType
    
    #endregion

    public static class ListTprRoleEligibilityTypeExtensions
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
            this List<TprRoleEligibilityType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRoleEligibilityType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRoleEligibilityType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types