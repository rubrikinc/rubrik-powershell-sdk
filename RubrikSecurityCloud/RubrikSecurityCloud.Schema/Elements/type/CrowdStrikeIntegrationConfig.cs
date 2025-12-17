// CrowdStrikeIntegrationConfig.cs
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
    #region CrowdStrikeIntegrationConfig
    public class CrowdStrikeIntegrationConfig: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? CrowdstrikeTenantUrl
        // GraphQL -> crowdstrikeTenantUrl: String! (scalar)
        [JsonProperty("crowdstrikeTenantUrl")]
        public System.String? CrowdstrikeTenantUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrowdStrikeIntegrationConfig";
    }

    public CrowdStrikeIntegrationConfig Set(
        System.String? ClientId = null,
        System.String? ClientSecret = null,
        System.String? CrowdstrikeTenantUrl = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( ClientSecret != null ) {
            this.ClientSecret = ClientSecret;
        }
        if ( CrowdstrikeTenantUrl != null ) {
            this.CrowdstrikeTenantUrl = CrowdstrikeTenantUrl;
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
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (this.ClientSecret != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientSecret\n" ;
            } else {
                s += ind + "clientSecret\n" ;
            }
        }
        //      C# -> System.String? CrowdstrikeTenantUrl
        // GraphQL -> crowdstrikeTenantUrl: String! (scalar)
        if (this.CrowdstrikeTenantUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "crowdstrikeTenantUrl\n" ;
            } else {
                s += ind + "crowdstrikeTenantUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (ec.Includes("clientSecret",true))
        {
            if(this.ClientSecret == null) {

                this.ClientSecret = "FETCH";

            } else {


            }
        }
        else if (this.ClientSecret != null && ec.Excludes("clientSecret",true))
        {
            this.ClientSecret = null;
        }
        //      C# -> System.String? CrowdstrikeTenantUrl
        // GraphQL -> crowdstrikeTenantUrl: String! (scalar)
        if (ec.Includes("crowdstrikeTenantUrl",true))
        {
            if(this.CrowdstrikeTenantUrl == null) {

                this.CrowdstrikeTenantUrl = "FETCH";

            } else {


            }
        }
        else if (this.CrowdstrikeTenantUrl != null && ec.Excludes("crowdstrikeTenantUrl",true))
        {
            this.CrowdstrikeTenantUrl = null;
        }
    }


    #endregion

    } // class CrowdStrikeIntegrationConfig
    
    #endregion

    public static class ListCrowdStrikeIntegrationConfigExtensions
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
            this List<CrowdStrikeIntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrowdStrikeIntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrowdStrikeIntegrationConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrowdStrikeIntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrowdStrikeIntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types