// AzureAdApplication.cs
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
    #region AzureAdApplication
    public class AzureAdApplication: BaseType
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.Int32? AppRolesCount
        // GraphQL -> appRolesCount: Int! (scalar)
        [JsonProperty("appRolesCount")]
        public System.Int32? AppRolesCount { get; set; }

        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? SecretsExpired
        // GraphQL -> secretsExpired: Boolean! (scalar)
        [JsonProperty("secretsExpired")]
        public System.Boolean? SecretsExpired { get; set; }

        //      C# -> List<AzureAdAppRole>? AppRoles
        // GraphQL -> appRoles: [AzureAdAppRole!]! (type)
        [JsonProperty("appRoles")]
        public List<AzureAdAppRole>? AppRoles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdApplication";
    }

    public AzureAdApplication Set(
        System.String? AppId = null,
        System.Int32? AppRolesCount = null,
        DateTime? CreatedDateTime = null,
        System.String? DisplayName = null,
        System.Boolean? SecretsExpired = null,
        List<AzureAdAppRole>? AppRoles = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppRolesCount != null ) {
            this.AppRolesCount = AppRolesCount;
        }
        if ( CreatedDateTime != null ) {
            this.CreatedDateTime = CreatedDateTime;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( SecretsExpired != null ) {
            this.SecretsExpired = SecretsExpired;
        }
        if ( AppRoles != null ) {
            this.AppRoles = AppRoles;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.Int32? AppRolesCount
        // GraphQL -> appRolesCount: Int! (scalar)
        if (this.AppRolesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appRolesCount\n" ;
            } else {
                s += ind + "appRolesCount\n" ;
            }
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (this.CreatedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDateTime\n" ;
            } else {
                s += ind + "createdDateTime\n" ;
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
        //      C# -> System.Boolean? SecretsExpired
        // GraphQL -> secretsExpired: Boolean! (scalar)
        if (this.SecretsExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secretsExpired\n" ;
            } else {
                s += ind + "secretsExpired\n" ;
            }
        }
        //      C# -> List<AzureAdAppRole>? AppRoles
        // GraphQL -> appRoles: [AzureAdAppRole!]! (type)
        if (this.AppRoles != null) {
            var fspec = this.AppRoles.AsFieldSpec(conf.Child("appRoles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "appRoles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.Int32? AppRolesCount
        // GraphQL -> appRolesCount: Int! (scalar)
        if (ec.Includes("appRolesCount",true))
        {
            if(this.AppRolesCount == null) {

                this.AppRolesCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AppRolesCount != null && ec.Excludes("appRolesCount",true))
        {
            this.AppRolesCount = null;
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (ec.Includes("createdDateTime",true))
        {
            if(this.CreatedDateTime == null) {

                this.CreatedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDateTime != null && ec.Excludes("createdDateTime",true))
        {
            this.CreatedDateTime = null;
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
        //      C# -> System.Boolean? SecretsExpired
        // GraphQL -> secretsExpired: Boolean! (scalar)
        if (ec.Includes("secretsExpired",true))
        {
            if(this.SecretsExpired == null) {

                this.SecretsExpired = true;

            } else {


            }
        }
        else if (this.SecretsExpired != null && ec.Excludes("secretsExpired",true))
        {
            this.SecretsExpired = null;
        }
        //      C# -> List<AzureAdAppRole>? AppRoles
        // GraphQL -> appRoles: [AzureAdAppRole!]! (type)
        if (ec.Includes("appRoles",false))
        {
            if(this.AppRoles == null) {

                this.AppRoles = new List<AzureAdAppRole>();
                this.AppRoles.ApplyExploratoryFieldSpec(ec.NewChild("appRoles"));

            } else {

                this.AppRoles.ApplyExploratoryFieldSpec(ec.NewChild("appRoles"));

            }
        }
        else if (this.AppRoles != null && ec.Excludes("appRoles",false))
        {
            this.AppRoles = null;
        }
    }


    #endregion

    } // class AzureAdApplication
    
    #endregion

    public static class ListAzureAdApplicationExtensions
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
            this List<AzureAdApplication> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdApplication> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdApplication> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdApplication());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdApplication> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types