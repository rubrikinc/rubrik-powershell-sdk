// InterfaceCidr.cs
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
    #region InterfaceCidr
    public class InterfaceCidr: BaseType
    {
        #region members

        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        [JsonProperty("interfaceType")]
        public InterfaceType? InterfaceType { get; set; }

        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        [JsonProperty("cidr")]
        public System.String? Cidr { get; set; }

        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        [JsonProperty("selected")]
        public System.Boolean? Selected { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InterfaceCidr";
    }

    public InterfaceCidr Set(
        InterfaceType? InterfaceType = null,
        System.String? Cidr = null,
        System.Boolean? Selected = null
    ) 
    {
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
        }
        if ( Cidr != null ) {
            this.Cidr = Cidr;
        }
        if ( Selected != null ) {
            this.Selected = Selected;
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
        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        if (this.InterfaceType != null) {
            s += ind + "interfaceType\n" ;
        }
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr != null) {
            s += ind + "cidr\n" ;
        }
        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        if (this.Selected != null) {
            s += ind + "selected\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        if (this.InterfaceType == null && Exploration.Includes(parent + ".interfaceType", true))
        {
            this.InterfaceType = new InterfaceType();
        }
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr == null && Exploration.Includes(parent + ".cidr", true))
        {
            this.Cidr = "FETCH";
        }
        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        if (this.Selected == null && Exploration.Includes(parent + ".selected", true))
        {
            this.Selected = true;
        }
    }


    #endregion

    } // class InterfaceCidr
    
    #endregion

    public static class ListInterfaceCidrExtensions
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
            this List<InterfaceCidr> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<InterfaceCidr> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new InterfaceCidr());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types