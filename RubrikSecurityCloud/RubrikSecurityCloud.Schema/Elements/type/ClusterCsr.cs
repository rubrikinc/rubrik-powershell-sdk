// ClusterCsr.cs
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
    #region ClusterCsr
    public class ClusterCsr: BaseType
    {
        #region members

        //      C# -> System.String? Csr
        // GraphQL -> csr: String! (scalar)
        [JsonProperty("csr")]
        public System.String? Csr { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterCsr";
    }

    public ClusterCsr Set(
        System.String? Csr = null
    ) 
    {
        if ( Csr != null ) {
            this.Csr = Csr;
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
        //      C# -> System.String? Csr
        // GraphQL -> csr: String! (scalar)
        if (this.Csr != null) {
            s += ind + "csr\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Csr
        // GraphQL -> csr: String! (scalar)
        if (this.Csr == null && Exploration.Includes(parent + ".csr", true))
        {
            this.Csr = "FETCH";
        }
    }


    #endregion

    } // class ClusterCsr
    
    #endregion

    public static class ListClusterCsrExtensions
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
            this List<ClusterCsr> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterCsr> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterCsr());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types