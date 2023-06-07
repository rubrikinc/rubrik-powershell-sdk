// AspKey.cs
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
    #region AspKey
    public class AspKey: BaseType
    {
        #region members

        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        [JsonProperty("component")]
        public ComponentEnum? Component { get; set; }

        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        [JsonProperty("targetId")]
        public System.String? TargetId { get; set; }


        #endregion

    #region methods

    public AspKey Set(
        ComponentEnum? Component = null,
        System.String? Account = null,
        System.String? Name = null,
        System.String? TargetId = null
    ) 
    {
        if ( Component != null ) {
            this.Component = Component;
        }
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TargetId != null ) {
            this.TargetId = TargetId;
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
        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        if (this.Component != null) {
            s += ind + "component\n" ;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            s += ind + "account\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId != null) {
            s += ind + "targetId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        if (this.Component == null && Exploration.Includes(parent + ".component", true))
        {
            this.Component = new ComponentEnum();
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account == null && Exploration.Includes(parent + ".account", true))
        {
            this.Account = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId == null && Exploration.Includes(parent + ".targetId", true))
        {
            this.TargetId = "FETCH";
        }
    }


    #endregion

    } // class AspKey
    
    #endregion

    public static class ListAspKeyExtensions
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
            this List<AspKey> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AspKey> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AspKey());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types