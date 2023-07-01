// ClusterNodeInterfaceCidr.cs
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
    #region ClusterNodeInterfaceCidr
    public class ClusterNodeInterfaceCidr: BaseType
    {
        #region members

        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        [JsonProperty("cidr")]
        public System.String? Cidr { get; set; }

        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        [JsonProperty("interfaceName")]
        public System.String? InterfaceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNodeInterfaceCidr";
    }

    public ClusterNodeInterfaceCidr Set(
        System.String? Cidr = null,
        System.String? InterfaceName = null
    ) 
    {
        if ( Cidr != null ) {
            this.Cidr = Cidr;
        }
        if ( InterfaceName != null ) {
            this.InterfaceName = InterfaceName;
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
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr != null) {
            s += ind + "cidr\n" ;
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName != null) {
            s += ind + "interfaceName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr == null && Exploration.Includes(parent + ".cidr", true))
        {
            this.Cidr = "FETCH";
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName == null && Exploration.Includes(parent + ".interfaceName", true))
        {
            this.InterfaceName = "FETCH";
        }
    }


    #endregion

    } // class ClusterNodeInterfaceCidr
    
    #endregion

    public static class ListClusterNodeInterfaceCidrExtensions
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
            this List<ClusterNodeInterfaceCidr> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNodeInterfaceCidr> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodeInterfaceCidr());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types