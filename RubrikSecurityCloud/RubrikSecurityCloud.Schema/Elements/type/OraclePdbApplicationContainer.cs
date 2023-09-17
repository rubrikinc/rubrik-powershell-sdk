// OraclePdbApplicationContainer.cs
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
    #region OraclePdbApplicationContainer
    public class OraclePdbApplicationContainer: BaseType
    {
        #region members

        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        [JsonProperty("applicationPdbs")]
        public List<System.String>? ApplicationPdbs { get; set; }

        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        [JsonProperty("applicationRoot")]
        public System.String? ApplicationRoot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OraclePdbApplicationContainer";
    }

    public OraclePdbApplicationContainer Set(
        List<System.String>? ApplicationPdbs = null,
        System.String? ApplicationRoot = null
    ) 
    {
        if ( ApplicationPdbs != null ) {
            this.ApplicationPdbs = ApplicationPdbs;
        }
        if ( ApplicationRoot != null ) {
            this.ApplicationRoot = ApplicationRoot;
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
        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        if (this.ApplicationPdbs != null) {
            s += ind + "applicationPdbs\n" ;
        }
        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        if (this.ApplicationRoot != null) {
            s += ind + "applicationRoot\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        if (this.ApplicationPdbs == null && ec.Includes("applicationPdbs",true))
        {
            this.ApplicationPdbs = new List<System.String>();
        }
        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        if (this.ApplicationRoot == null && ec.Includes("applicationRoot",true))
        {
            this.ApplicationRoot = "FETCH";
        }
    }


    #endregion

    } // class OraclePdbApplicationContainer
    
    #endregion

    public static class ListOraclePdbApplicationContainerExtensions
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
            this List<OraclePdbApplicationContainer> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OraclePdbApplicationContainer> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OraclePdbApplicationContainer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OraclePdbApplicationContainer> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types