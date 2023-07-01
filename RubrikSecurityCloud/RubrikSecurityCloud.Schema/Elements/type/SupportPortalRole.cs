// SupportPortalRole.cs
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
    #region SupportPortalRole
    public class SupportPortalRole: BaseType
    {
        #region members

        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        [JsonProperty("canCreateCases")]
        public System.Boolean? CanCreateCases { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportPortalRole";
    }

    public SupportPortalRole Set(
        System.Boolean? CanCreateCases = null
    ) 
    {
        if ( CanCreateCases != null ) {
            this.CanCreateCases = CanCreateCases;
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
        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        if (this.CanCreateCases != null) {
            s += ind + "canCreateCases\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? CanCreateCases
        // GraphQL -> canCreateCases: Boolean! (scalar)
        if (this.CanCreateCases == null && Exploration.Includes(parent + ".canCreateCases", true))
        {
            this.CanCreateCases = true;
        }
    }


    #endregion

    } // class SupportPortalRole
    
    #endregion

    public static class ListSupportPortalRoleExtensions
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
            this List<SupportPortalRole> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SupportPortalRole> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportPortalRole());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types