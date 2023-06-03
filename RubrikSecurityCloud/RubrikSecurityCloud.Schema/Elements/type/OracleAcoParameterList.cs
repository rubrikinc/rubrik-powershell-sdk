// OracleAcoParameterList.cs
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
    #region OracleAcoParameterList
    public class OracleAcoParameterList: BaseType
    {
        #region members

        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        [JsonProperty("parameters")]
        public List<System.String>? Parameters { get; set; }


        #endregion

    #region methods

    public OracleAcoParameterList Set(
        List<System.String>? Parameters = null
    ) 
    {
        if ( Parameters != null ) {
            this.Parameters = Parameters;
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
        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        if (this.Parameters != null) {
            s += ind + "parameters\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Parameters
        // GraphQL -> parameters: [String!]! (scalar)
        if (this.Parameters == null && Exploration.Includes(parent + ".parameters", true))
        {
            this.Parameters = new List<System.String>();
        }
    }


    #endregion

    } // class OracleAcoParameterList
    
    #endregion

    public static class ListOracleAcoParameterListExtensions
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
            this List<OracleAcoParameterList> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleAcoParameterList> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleAcoParameterList());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types