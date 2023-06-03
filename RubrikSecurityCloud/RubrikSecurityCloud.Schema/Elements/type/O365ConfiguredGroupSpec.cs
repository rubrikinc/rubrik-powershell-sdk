// O365ConfiguredGroupSpec.cs
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
    #region O365ConfiguredGroupSpec
    public class O365ConfiguredGroupSpec: BaseType
    {
        #region members

        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        [JsonProperty("pdls")]
        public List<System.String>? Pdls { get; set; }

        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        [JsonProperty("wildcard")]
        public System.String? Wildcard { get; set; }


        #endregion

    #region methods

    public O365ConfiguredGroupSpec Set(
        List<System.String>? Pdls = null,
        System.String? Wildcard = null
    ) 
    {
        if ( Pdls != null ) {
            this.Pdls = Pdls;
        }
        if ( Wildcard != null ) {
            this.Wildcard = Wildcard;
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
        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        if (this.Pdls != null) {
            s += ind + "pdls\n" ;
        }
        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        if (this.Wildcard != null) {
            s += ind + "wildcard\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        if (this.Pdls == null && Exploration.Includes(parent + ".pdls", true))
        {
            this.Pdls = new List<System.String>();
        }
        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        if (this.Wildcard == null && Exploration.Includes(parent + ".wildcard", true))
        {
            this.Wildcard = new System.String("FETCH");
        }
    }


    #endregion

    } // class O365ConfiguredGroupSpec
    
    #endregion

    public static class ListO365ConfiguredGroupSpecExtensions
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
            this List<O365ConfiguredGroupSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types