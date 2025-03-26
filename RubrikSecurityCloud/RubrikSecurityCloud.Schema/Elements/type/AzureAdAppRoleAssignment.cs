// AzureAdAppRoleAssignment.cs
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
    #region AzureAdAppRoleAssignment
    public class AzureAdAppRoleAssignment: BaseType
    {
        #region members

        //      C# -> AzureAdObjectType? PrincipalType
        // GraphQL -> principalType: AzureAdObjectType! (enum)
        [JsonProperty("principalType")]
        public AzureAdObjectType? PrincipalType { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppRoleId
        // GraphQL -> appRoleId: String! (scalar)
        [JsonProperty("appRoleId")]
        public System.String? AppRoleId { get; set; }

        //      C# -> System.Boolean? AppRoleIsEnabled
        // GraphQL -> appRoleIsEnabled: Boolean! (scalar)
        [JsonProperty("appRoleIsEnabled")]
        public System.Boolean? AppRoleIsEnabled { get; set; }

        //      C# -> System.String? AppRoleName
        // GraphQL -> appRoleName: String! (scalar)
        [JsonProperty("appRoleName")]
        public System.String? AppRoleName { get; set; }

        //      C# -> System.String? AppRoleValue
        // GraphQL -> appRoleValue: String! (scalar)
        [JsonProperty("appRoleValue")]
        public System.String? AppRoleValue { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }

        //      C# -> System.String? ServicePrincipalId
        // GraphQL -> servicePrincipalId: String! (scalar)
        [JsonProperty("servicePrincipalId")]
        public System.String? ServicePrincipalId { get; set; }

        //      C# -> System.String? ServicePrincipalName
        // GraphQL -> servicePrincipalName: String! (scalar)
        [JsonProperty("servicePrincipalName")]
        public System.String? ServicePrincipalName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdAppRoleAssignment";
    }

    public AzureAdAppRoleAssignment Set(
        AzureAdObjectType? PrincipalType = null,
        System.String? AppId = null,
        System.String? AppRoleId = null,
        System.Boolean? AppRoleIsEnabled = null,
        System.String? AppRoleName = null,
        System.String? AppRoleValue = null,
        System.String? Id = null,
        System.String? PrincipalId = null,
        System.String? PrincipalName = null,
        System.String? ServicePrincipalId = null,
        System.String? ServicePrincipalName = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppRoleId != null ) {
            this.AppRoleId = AppRoleId;
        }
        if ( AppRoleIsEnabled != null ) {
            this.AppRoleIsEnabled = AppRoleIsEnabled;
        }
        if ( AppRoleName != null ) {
            this.AppRoleName = AppRoleName;
        }
        if ( AppRoleValue != null ) {
            this.AppRoleValue = AppRoleValue;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( PrincipalName != null ) {
            this.PrincipalName = PrincipalName;
        }
        if ( ServicePrincipalId != null ) {
            this.ServicePrincipalId = ServicePrincipalId;
        }
        if ( ServicePrincipalName != null ) {
            this.ServicePrincipalName = ServicePrincipalName;
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
        //      C# -> AzureAdObjectType? PrincipalType
        // GraphQL -> principalType: AzureAdObjectType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? AppRoleId
        // GraphQL -> appRoleId: String! (scalar)
        if (this.AppRoleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appRoleId\n" ;
            } else {
                s += ind + "appRoleId\n" ;
            }
        }
        //      C# -> System.Boolean? AppRoleIsEnabled
        // GraphQL -> appRoleIsEnabled: Boolean! (scalar)
        if (this.AppRoleIsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appRoleIsEnabled\n" ;
            } else {
                s += ind + "appRoleIsEnabled\n" ;
            }
        }
        //      C# -> System.String? AppRoleName
        // GraphQL -> appRoleName: String! (scalar)
        if (this.AppRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appRoleName\n" ;
            } else {
                s += ind + "appRoleName\n" ;
            }
        }
        //      C# -> System.String? AppRoleValue
        // GraphQL -> appRoleValue: String! (scalar)
        if (this.AppRoleValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appRoleValue\n" ;
            } else {
                s += ind + "appRoleValue\n" ;
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
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalName\n" ;
            } else {
                s += ind + "principalName\n" ;
            }
        }
        //      C# -> System.String? ServicePrincipalId
        // GraphQL -> servicePrincipalId: String! (scalar)
        if (this.ServicePrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "servicePrincipalId\n" ;
            } else {
                s += ind + "servicePrincipalId\n" ;
            }
        }
        //      C# -> System.String? ServicePrincipalName
        // GraphQL -> servicePrincipalName: String! (scalar)
        if (this.ServicePrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "servicePrincipalName\n" ;
            } else {
                s += ind + "servicePrincipalName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdObjectType? PrincipalType
        // GraphQL -> principalType: AzureAdObjectType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new AzureAdObjectType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? AppRoleId
        // GraphQL -> appRoleId: String! (scalar)
        if (ec.Includes("appRoleId",true))
        {
            if(this.AppRoleId == null) {

                this.AppRoleId = "FETCH";

            } else {


            }
        }
        else if (this.AppRoleId != null && ec.Excludes("appRoleId",true))
        {
            this.AppRoleId = null;
        }
        //      C# -> System.Boolean? AppRoleIsEnabled
        // GraphQL -> appRoleIsEnabled: Boolean! (scalar)
        if (ec.Includes("appRoleIsEnabled",true))
        {
            if(this.AppRoleIsEnabled == null) {

                this.AppRoleIsEnabled = true;

            } else {


            }
        }
        else if (this.AppRoleIsEnabled != null && ec.Excludes("appRoleIsEnabled",true))
        {
            this.AppRoleIsEnabled = null;
        }
        //      C# -> System.String? AppRoleName
        // GraphQL -> appRoleName: String! (scalar)
        if (ec.Includes("appRoleName",true))
        {
            if(this.AppRoleName == null) {

                this.AppRoleName = "FETCH";

            } else {


            }
        }
        else if (this.AppRoleName != null && ec.Excludes("appRoleName",true))
        {
            this.AppRoleName = null;
        }
        //      C# -> System.String? AppRoleValue
        // GraphQL -> appRoleValue: String! (scalar)
        if (ec.Includes("appRoleValue",true))
        {
            if(this.AppRoleValue == null) {

                this.AppRoleValue = "FETCH";

            } else {


            }
        }
        else if (this.AppRoleValue != null && ec.Excludes("appRoleValue",true))
        {
            this.AppRoleValue = null;
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
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (ec.Includes("principalName",true))
        {
            if(this.PrincipalName == null) {

                this.PrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalName != null && ec.Excludes("principalName",true))
        {
            this.PrincipalName = null;
        }
        //      C# -> System.String? ServicePrincipalId
        // GraphQL -> servicePrincipalId: String! (scalar)
        if (ec.Includes("servicePrincipalId",true))
        {
            if(this.ServicePrincipalId == null) {

                this.ServicePrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.ServicePrincipalId != null && ec.Excludes("servicePrincipalId",true))
        {
            this.ServicePrincipalId = null;
        }
        //      C# -> System.String? ServicePrincipalName
        // GraphQL -> servicePrincipalName: String! (scalar)
        if (ec.Includes("servicePrincipalName",true))
        {
            if(this.ServicePrincipalName == null) {

                this.ServicePrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.ServicePrincipalName != null && ec.Excludes("servicePrincipalName",true))
        {
            this.ServicePrincipalName = null;
        }
    }


    #endregion

    } // class AzureAdAppRoleAssignment
    
    #endregion

    public static class ListAzureAdAppRoleAssignmentExtensions
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
            this List<AzureAdAppRoleAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdAppRoleAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdAppRoleAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdAppRoleAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdAppRoleAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types