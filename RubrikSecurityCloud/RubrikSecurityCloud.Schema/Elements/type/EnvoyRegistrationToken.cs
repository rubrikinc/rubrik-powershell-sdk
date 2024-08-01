// EnvoyRegistrationToken.cs
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
    #region EnvoyRegistrationToken
    public class EnvoyRegistrationToken: BaseType
    {
        #region members

        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        [JsonProperty("expiration")]
        public System.String? Expiration { get; set; }

        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        [JsonProperty("tenantNetworkId")]
        public System.String? TenantNetworkId { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EnvoyRegistrationToken";
    }

    public EnvoyRegistrationToken Set(
        System.String? Expiration = null,
        System.String? TenantNetworkId = null,
        System.String? Token = null
    ) 
    {
        if ( Expiration != null ) {
            this.Expiration = Expiration;
        }
        if ( TenantNetworkId != null ) {
            this.TenantNetworkId = TenantNetworkId;
        }
        if ( Token != null ) {
            this.Token = Token;
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
        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        if (this.Expiration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiration\n" ;
            } else {
                s += ind + "expiration\n" ;
            }
        }
        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        if (this.TenantNetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantNetworkId\n" ;
            } else {
                s += ind + "tenantNetworkId\n" ;
            }
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (this.Token != null) {
            if (conf.Flat) {
                s += conf.Prefix + "token\n" ;
            } else {
                s += ind + "token\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Expiration
        // GraphQL -> expiration: String! (scalar)
        if (ec.Includes("expiration",true))
        {
            if(this.Expiration == null) {

                this.Expiration = "FETCH";

            } else {


            }
        }
        else if (this.Expiration != null && ec.Excludes("expiration",true))
        {
            this.Expiration = null;
        }
        //      C# -> System.String? TenantNetworkId
        // GraphQL -> tenantNetworkId: String! (scalar)
        if (ec.Includes("tenantNetworkId",true))
        {
            if(this.TenantNetworkId == null) {

                this.TenantNetworkId = "FETCH";

            } else {


            }
        }
        else if (this.TenantNetworkId != null && ec.Excludes("tenantNetworkId",true))
        {
            this.TenantNetworkId = null;
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (ec.Includes("token",true))
        {
            if(this.Token == null) {

                this.Token = "FETCH";

            } else {


            }
        }
        else if (this.Token != null && ec.Excludes("token",true))
        {
            this.Token = null;
        }
    }


    #endregion

    } // class EnvoyRegistrationToken
    
    #endregion

    public static class ListEnvoyRegistrationTokenExtensions
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
            this List<EnvoyRegistrationToken> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EnvoyRegistrationToken> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EnvoyRegistrationToken> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EnvoyRegistrationToken());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EnvoyRegistrationToken> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types