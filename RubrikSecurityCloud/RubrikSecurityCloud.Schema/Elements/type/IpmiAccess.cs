// IpmiAccess.cs
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
    #region IpmiAccess
    public class IpmiAccess: BaseType
    {
        #region members

        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        [JsonProperty("https")]
        public System.Boolean? Https { get; set; }

        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        [JsonProperty("iKvm")]
        public System.Boolean? Ikvm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IpmiAccess";
    }

    public IpmiAccess Set(
        System.Boolean? Https = null,
        System.Boolean? Ikvm = null
    ) 
    {
        if ( Https != null ) {
            this.Https = Https;
        }
        if ( Ikvm != null ) {
            this.Ikvm = Ikvm;
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
        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        if (this.Https != null) {
            s += ind + "https\n" ;
        }
        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        if (this.Ikvm != null) {
            s += ind + "iKvm\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        if (this.Https == null && ec.Includes("https",true))
        {
            this.Https = true;
        }
        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        if (this.Ikvm == null && ec.Includes("iKvm",true))
        {
            this.Ikvm = true;
        }
    }


    #endregion

    } // class IpmiAccess
    
    #endregion

    public static class ListIpmiAccessExtensions
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
            this List<IpmiAccess> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IpmiAccess> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IpmiAccess());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IpmiAccess> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types