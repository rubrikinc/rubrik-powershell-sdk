// AzureCloudAccountTenantApp.cs
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
    #region AzureCloudAccountTenantApp
    public class AzureCloudAccountTenantApp: BaseType
    {
        #region members

        //      C# -> AzureAuthType? AuthType
        // GraphQL -> authType: AzureAuthType! (enum)
        [JsonProperty("authType")]
        public AzureAuthType? AuthType { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountTenantApp";
    }

    public AzureCloudAccountTenantApp Set(
        AzureAuthType? AuthType = null,
        System.String? AppName = null,
        System.String? ClientId = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
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
        //      C# -> AzureAuthType? AuthType
        // GraphQL -> authType: AzureAuthType! (enum)
        if (this.AuthType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authType\n" ;
            } else {
                s += ind + "authType\n" ;
            }
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appName\n" ;
            } else {
                s += ind + "appName\n" ;
            }
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAuthType? AuthType
        // GraphQL -> authType: AzureAuthType! (enum)
        if (ec.Includes("authType",true))
        {
            if(this.AuthType == null) {

                this.AuthType = new AzureAuthType();

            } else {


            }
        }
        else if (this.AuthType != null && ec.Excludes("authType",true))
        {
            this.AuthType = null;
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (ec.Includes("appName",true))
        {
            if(this.AppName == null) {

                this.AppName = "FETCH";

            } else {


            }
        }
        else if (this.AppName != null && ec.Excludes("appName",true))
        {
            this.AppName = null;
        }
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
    }


    #endregion

    } // class AzureCloudAccountTenantApp
    
    #endregion

    public static class ListAzureCloudAccountTenantAppExtensions
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
            this List<AzureCloudAccountTenantApp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountTenantApp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountTenantApp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountTenantApp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountTenantApp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types