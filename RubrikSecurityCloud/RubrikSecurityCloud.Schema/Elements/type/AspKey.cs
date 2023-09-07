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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? ExpirationDate
        // GraphQL -> expirationDate: String! (scalar)
        [JsonProperty("expirationDate")]
        public System.String? ExpirationDate { get; set; }

        //      C# -> System.String? JiraTicket
        // GraphQL -> jiraTicket: String! (scalar)
        [JsonProperty("jiraTicket")]
        public System.String? JiraTicket { get; set; }

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

    public override string GetGqlTypeName() {
        return "ASPKey";
    }

    public AspKey Set(
        ComponentEnum? Component = null,
        System.String? Account = null,
        System.String? ExpirationDate = null,
        System.String? JiraTicket = null,
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
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( JiraTicket != null ) {
            this.JiraTicket = JiraTicket;
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
        //      C# -> System.String? ExpirationDate
        // GraphQL -> expirationDate: String! (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.String? JiraTicket
        // GraphQL -> jiraTicket: String! (scalar)
        if (this.JiraTicket != null) {
            s += ind + "jiraTicket\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        if (this.Component == null && ec.Includes("component",true))
        {
            this.Component = new ComponentEnum();
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account == null && ec.Includes("account",true))
        {
            this.Account = "FETCH";
        }
        //      C# -> System.String? ExpirationDate
        // GraphQL -> expirationDate: String! (scalar)
        if (this.ExpirationDate == null && ec.Includes("expirationDate",true))
        {
            this.ExpirationDate = "FETCH";
        }
        //      C# -> System.String? JiraTicket
        // GraphQL -> jiraTicket: String! (scalar)
        if (this.JiraTicket == null && ec.Includes("jiraTicket",true))
        {
            this.JiraTicket = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId == null && ec.Includes("targetId",true))
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AspKey> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AspKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AspKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types