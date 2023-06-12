// CloudDirectSystems.cs
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
    #region CloudDirectSystems
    public class CloudDirectSystems: BaseType
    {
        #region members

        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        [JsonProperty("systems")]
        public List<System.String>? Systems { get; set; }


        #endregion

    #region methods

    public CloudDirectSystems Set(
        List<System.String>? Systems = null
    ) 
    {
        if ( Systems != null ) {
            this.Systems = Systems;
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
        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        if (this.Systems != null) {
            s += ind + "systems\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        if (this.Systems == null && Exploration.Includes(parent + ".systems", true))
        {
            this.Systems = new List<System.String>();
        }
    }


    #endregion

    } // class CloudDirectSystems
    
    #endregion

    public static class ListCloudDirectSystemsExtensions
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
            this List<CloudDirectSystems> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSystems> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSystems());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types