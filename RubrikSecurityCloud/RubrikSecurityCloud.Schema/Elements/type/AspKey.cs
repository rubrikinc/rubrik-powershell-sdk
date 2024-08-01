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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        if (this.Component != null) {
            if (conf.Flat) {
                s += conf.Prefix + "component\n" ;
            } else {
                s += ind + "component\n" ;
            }
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            if (conf.Flat) {
                s += conf.Prefix + "account\n" ;
            } else {
                s += ind + "account\n" ;
            }
        }
        //      C# -> System.String? ExpirationDate
        // GraphQL -> expirationDate: String! (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.String? JiraTicket
        // GraphQL -> jiraTicket: String! (scalar)
        if (this.JiraTicket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jiraTicket\n" ;
            } else {
                s += ind + "jiraTicket\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetId\n" ;
            } else {
                s += ind + "targetId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComponentEnum? Component
        // GraphQL -> component: ComponentEnum! (enum)
        if (ec.Includes("component",true))
        {
            if(this.Component == null) {

                this.Component = new ComponentEnum();

            } else {


            }
        }
        else if (this.Component != null && ec.Excludes("component",true))
        {
            this.Component = null;
        }
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (ec.Includes("account",true))
        {
            if(this.Account == null) {

                this.Account = "FETCH";

            } else {


            }
        }
        else if (this.Account != null && ec.Excludes("account",true))
        {
            this.Account = null;
        }
        //      C# -> System.String? ExpirationDate
        // GraphQL -> expirationDate: String! (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = "FETCH";

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
        //      C# -> System.String? JiraTicket
        // GraphQL -> jiraTicket: String! (scalar)
        if (ec.Includes("jiraTicket",true))
        {
            if(this.JiraTicket == null) {

                this.JiraTicket = "FETCH";

            } else {


            }
        }
        else if (this.JiraTicket != null && ec.Excludes("jiraTicket",true))
        {
            this.JiraTicket = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (ec.Includes("targetId",true))
        {
            if(this.TargetId == null) {

                this.TargetId = "FETCH";

            } else {


            }
        }
        else if (this.TargetId != null && ec.Excludes("targetId",true))
        {
            this.TargetId = null;
        }
    }


    #endregion

    } // class AspKey
    
    #endregion

    public static class ListAspKeyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AspKey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AspKey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AspKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types