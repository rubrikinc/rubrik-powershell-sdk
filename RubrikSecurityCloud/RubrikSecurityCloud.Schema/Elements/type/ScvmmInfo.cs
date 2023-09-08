// ScvmmInfo.cs
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
    #region ScvmmInfo
    public class ScvmmInfo: BaseType
    {
        #region members

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScvmmInfo";
    }

    public ScvmmInfo Set(
        System.String? Version = null
    ) 
    {
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
    }


    #endregion

    } // class ScvmmInfo
    
    #endregion

    public static class ListScvmmInfoExtensions
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
            this List<ScvmmInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ScvmmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScvmmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ScvmmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types