// CloudNativeSqlServerSetupScript.cs
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
    #region CloudNativeSqlServerSetupScript
    public class CloudNativeSqlServerSetupScript: BaseType
    {
        #region members

        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        [JsonProperty("script")]
        public System.String? Script { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeSqlServerSetupScript";
    }

    public CloudNativeSqlServerSetupScript Set(
        System.String? Script = null
    ) 
    {
        if ( Script != null ) {
            this.Script = Script;
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
        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        if (this.Script != null) {
            s += ind + "script\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        if (this.Script == null && ec.Includes("script",true))
        {
            this.Script = "FETCH";
        }
    }


    #endregion

    } // class CloudNativeSqlServerSetupScript
    
    #endregion

    public static class ListCloudNativeSqlServerSetupScriptExtensions
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
            this List<CloudNativeSqlServerSetupScript> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSqlServerSetupScript> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSqlServerSetupScript());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CloudNativeSqlServerSetupScript> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types