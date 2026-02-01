// GoogleSecOpsIntegrationConfig.cs
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
    #region GoogleSecOpsIntegrationConfig
    public class GoogleSecOpsIntegrationConfig: BaseType
    {
        #region members

        //      C# -> GoogleSecOpsIntegrationConfigType? ConfigType
        // GraphQL -> configType: GoogleSecOpsIntegrationConfigType! (enum)
        [JsonProperty("configType")]
        public GoogleSecOpsIntegrationConfigType? ConfigType { get; set; }

        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String! (scalar)
        [JsonProperty("serviceAccountId")]
        public System.String? ServiceAccountId { get; set; }

        //      C# -> System.Int32? WebhookId
        // GraphQL -> webhookId: Int (scalar)
        [JsonProperty("webhookId")]
        public System.Int32? WebhookId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GoogleSecOpsIntegrationConfig";
    }

    public GoogleSecOpsIntegrationConfig Set(
        GoogleSecOpsIntegrationConfigType? ConfigType = null,
        System.String? ServiceAccountId = null,
        System.Int32? WebhookId = null
    ) 
    {
        if ( ConfigType != null ) {
            this.ConfigType = ConfigType;
        }
        if ( ServiceAccountId != null ) {
            this.ServiceAccountId = ServiceAccountId;
        }
        if ( WebhookId != null ) {
            this.WebhookId = WebhookId;
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
        //      C# -> GoogleSecOpsIntegrationConfigType? ConfigType
        // GraphQL -> configType: GoogleSecOpsIntegrationConfigType! (enum)
        if (this.ConfigType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configType\n" ;
            } else {
                s += ind + "configType\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String! (scalar)
        if (this.ServiceAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountId\n" ;
            } else {
                s += ind + "serviceAccountId\n" ;
            }
        }
        //      C# -> System.Int32? WebhookId
        // GraphQL -> webhookId: Int (scalar)
        if (this.WebhookId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "webhookId\n" ;
            } else {
                s += ind + "webhookId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GoogleSecOpsIntegrationConfigType? ConfigType
        // GraphQL -> configType: GoogleSecOpsIntegrationConfigType! (enum)
        if (ec.Includes("configType",true))
        {
            if(this.ConfigType == null) {

                this.ConfigType = new GoogleSecOpsIntegrationConfigType();

            } else {


            }
        }
        else if (this.ConfigType != null && ec.Excludes("configType",true))
        {
            this.ConfigType = null;
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String! (scalar)
        if (ec.Includes("serviceAccountId",true))
        {
            if(this.ServiceAccountId == null) {

                this.ServiceAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountId != null && ec.Excludes("serviceAccountId",true))
        {
            this.ServiceAccountId = null;
        }
        //      C# -> System.Int32? WebhookId
        // GraphQL -> webhookId: Int (scalar)
        if (ec.Includes("webhookId",true))
        {
            if(this.WebhookId == null) {

                this.WebhookId = Int32.MinValue;

            } else {


            }
        }
        else if (this.WebhookId != null && ec.Excludes("webhookId",true))
        {
            this.WebhookId = null;
        }
    }


    #endregion

    } // class GoogleSecOpsIntegrationConfig
    
    #endregion

    public static class ListGoogleSecOpsIntegrationConfigExtensions
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
            this List<GoogleSecOpsIntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GoogleSecOpsIntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GoogleSecOpsIntegrationConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GoogleSecOpsIntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GoogleSecOpsIntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types