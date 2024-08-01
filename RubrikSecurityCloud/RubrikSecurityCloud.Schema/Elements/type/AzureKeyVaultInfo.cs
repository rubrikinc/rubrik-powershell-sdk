// AzureKeyVaultInfo.cs
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
    #region AzureKeyVaultInfo
 
    public class AzureKeyVaultInfo: BaseType, KeyVaultInfo
    {
        #region members

        //      C# -> KmsType? KeyVaultType
        // GraphQL -> keyVaultType: KmsType! (enum)
        [JsonProperty("keyVaultType")]
        public KmsType? KeyVaultType { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? KeyVaultUrl
        // GraphQL -> keyVaultUrl: String! (scalar)
        [JsonProperty("keyVaultUrl")]
        public System.String? KeyVaultUrl { get; set; }

        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        [JsonProperty("kmsKeyVaultId")]
        public System.String? KmsKeyVaultId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureKeyVaultInfo";
    }

    public AzureKeyVaultInfo Set(
        KmsType? KeyVaultType = null,
        System.String? ClientId = null,
        System.String? KeyVaultUrl = null,
        System.String? KmsKeyVaultId = null,
        System.String? TenantId = null
    ) 
    {
        if ( KeyVaultType != null ) {
            this.KeyVaultType = KeyVaultType;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( KeyVaultUrl != null ) {
            this.KeyVaultUrl = KeyVaultUrl;
        }
        if ( KmsKeyVaultId != null ) {
            this.KmsKeyVaultId = KmsKeyVaultId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
        //      C# -> KmsType? KeyVaultType
        // GraphQL -> keyVaultType: KmsType! (enum)
        if (this.KeyVaultType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVaultType\n" ;
            } else {
                s += ind + "keyVaultType\n" ;
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
        //      C# -> System.String? KeyVaultUrl
        // GraphQL -> keyVaultUrl: String! (scalar)
        if (this.KeyVaultUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVaultUrl\n" ;
            } else {
                s += ind + "keyVaultUrl\n" ;
            }
        }
        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        if (this.KmsKeyVaultId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKeyVaultId\n" ;
            } else {
                s += ind + "kmsKeyVaultId\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> KmsType? KeyVaultType
        // GraphQL -> keyVaultType: KmsType! (enum)
        if (ec.Includes("keyVaultType",true))
        {
            if(this.KeyVaultType == null) {

                this.KeyVaultType = new KmsType();

            } else {


            }
        }
        else if (this.KeyVaultType != null && ec.Excludes("keyVaultType",true))
        {
            this.KeyVaultType = null;
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
        //      C# -> System.String? KeyVaultUrl
        // GraphQL -> keyVaultUrl: String! (scalar)
        if (ec.Includes("keyVaultUrl",true))
        {
            if(this.KeyVaultUrl == null) {

                this.KeyVaultUrl = "FETCH";

            } else {


            }
        }
        else if (this.KeyVaultUrl != null && ec.Excludes("keyVaultUrl",true))
        {
            this.KeyVaultUrl = null;
        }
        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        if (ec.Includes("kmsKeyVaultId",true))
        {
            if(this.KmsKeyVaultId == null) {

                this.KmsKeyVaultId = "FETCH";

            } else {


            }
        }
        else if (this.KmsKeyVaultId != null && ec.Excludes("kmsKeyVaultId",true))
        {
            this.KmsKeyVaultId = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
    }


    #endregion

    } // class AzureKeyVaultInfo
    
    #endregion

    public static class ListAzureKeyVaultInfoExtensions
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
            this List<AzureKeyVaultInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureKeyVaultInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureKeyVaultInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureKeyVaultInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureKeyVaultInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types