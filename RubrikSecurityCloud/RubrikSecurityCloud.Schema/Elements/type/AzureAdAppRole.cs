// AzureAdAppRole.cs
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
    #region AzureAdAppRole
    public class AzureAdAppRole: BaseType
    {
        #region members

        //      C# -> List<AzureAdObjectType>? AllowedMemberTypes
        // GraphQL -> allowedMemberTypes: [AzureAdObjectType!]! (enum)
        [JsonProperty("allowedMemberTypes")]
        public List<AzureAdObjectType>? AllowedMemberTypes { get; set; }

        //      C# -> AzureAdObjectType? Origin
        // GraphQL -> origin: AzureAdObjectType! (enum)
        [JsonProperty("origin")]
        public AzureAdObjectType? Origin { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdAppRole";
    }

    public AzureAdAppRole Set(
        List<AzureAdObjectType>? AllowedMemberTypes = null,
        AzureAdObjectType? Origin = null,
        System.String? Description = null,
        System.String? DisplayName = null,
        System.String? Id = null,
        System.Boolean? IsEnabled = null,
        System.String? Value = null
    ) 
    {
        if ( AllowedMemberTypes != null ) {
            this.AllowedMemberTypes = AllowedMemberTypes;
        }
        if ( Origin != null ) {
            this.Origin = Origin;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> List<AzureAdObjectType>? AllowedMemberTypes
        // GraphQL -> allowedMemberTypes: [AzureAdObjectType!]! (enum)
        if (this.AllowedMemberTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedMemberTypes\n" ;
            } else {
                s += ind + "allowedMemberTypes\n" ;
            }
        }
        //      C# -> AzureAdObjectType? Origin
        // GraphQL -> origin: AzureAdObjectType! (enum)
        if (this.Origin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "origin\n" ;
            } else {
                s += ind + "origin\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureAdObjectType>? AllowedMemberTypes
        // GraphQL -> allowedMemberTypes: [AzureAdObjectType!]! (enum)
        if (ec.Includes("allowedMemberTypes",true))
        {
            if(this.AllowedMemberTypes == null) {

                this.AllowedMemberTypes = new List<AzureAdObjectType>();

            } else {


            }
        }
        else if (this.AllowedMemberTypes != null && ec.Excludes("allowedMemberTypes",true))
        {
            this.AllowedMemberTypes = null;
        }
        //      C# -> AzureAdObjectType? Origin
        // GraphQL -> origin: AzureAdObjectType! (enum)
        if (ec.Includes("origin",true))
        {
            if(this.Origin == null) {

                this.Origin = new AzureAdObjectType();

            } else {


            }
        }
        else if (this.Origin != null && ec.Excludes("origin",true))
        {
            this.Origin = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = "FETCH";

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
    }


    #endregion

    } // class AzureAdAppRole
    
    #endregion

    public static class ListAzureAdAppRoleExtensions
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
            this List<AzureAdAppRole> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdAppRole> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdAppRole> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdAppRole());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdAppRole> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types