// Passkey.cs
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
    #region Passkey
    public class Passkey: BaseType
    {
        #region members

        //      C# -> KeyTypeEnumType? KeyType
        // GraphQL -> keyType: KeyTypeEnumType! (enum)
        [JsonProperty("keyType")]
        public KeyTypeEnumType? KeyType { get; set; }

        //      C# -> System.String? Browser
        // GraphQL -> browser: String! (scalar)
        [JsonProperty("browser")]
        public System.String? Browser { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        [JsonProperty("credentialId")]
        public System.String? CredentialId { get; set; }

        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        [JsonProperty("os")]
        public System.String? Os { get; set; }

        //      C# -> System.String? PasskeyName
        // GraphQL -> passkeyName: String! (scalar)
        [JsonProperty("passkeyName")]
        public System.String? PasskeyName { get; set; }

        //      C# -> DateTime? UserLastValidatedAt
        // GraphQL -> userLastValidatedAt: DateTime (scalar)
        [JsonProperty("userLastValidatedAt")]
        public DateTime? UserLastValidatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Passkey";
    }

    public Passkey Set(
        KeyTypeEnumType? KeyType = null,
        System.String? Browser = null,
        DateTime? CreatedAt = null,
        System.String? CredentialId = null,
        System.String? Os = null,
        System.String? PasskeyName = null,
        DateTime? UserLastValidatedAt = null
    ) 
    {
        if ( KeyType != null ) {
            this.KeyType = KeyType;
        }
        if ( Browser != null ) {
            this.Browser = Browser;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CredentialId != null ) {
            this.CredentialId = CredentialId;
        }
        if ( Os != null ) {
            this.Os = Os;
        }
        if ( PasskeyName != null ) {
            this.PasskeyName = PasskeyName;
        }
        if ( UserLastValidatedAt != null ) {
            this.UserLastValidatedAt = UserLastValidatedAt;
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
        //      C# -> KeyTypeEnumType? KeyType
        // GraphQL -> keyType: KeyTypeEnumType! (enum)
        if (this.KeyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyType\n" ;
            } else {
                s += ind + "keyType\n" ;
            }
        }
        //      C# -> System.String? Browser
        // GraphQL -> browser: String! (scalar)
        if (this.Browser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "browser\n" ;
            } else {
                s += ind + "browser\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        if (this.CredentialId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "credentialId\n" ;
            } else {
                s += ind + "credentialId\n" ;
            }
        }
        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        if (this.Os != null) {
            if (conf.Flat) {
                s += conf.Prefix + "os\n" ;
            } else {
                s += ind + "os\n" ;
            }
        }
        //      C# -> System.String? PasskeyName
        // GraphQL -> passkeyName: String! (scalar)
        if (this.PasskeyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passkeyName\n" ;
            } else {
                s += ind + "passkeyName\n" ;
            }
        }
        //      C# -> DateTime? UserLastValidatedAt
        // GraphQL -> userLastValidatedAt: DateTime (scalar)
        if (this.UserLastValidatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userLastValidatedAt\n" ;
            } else {
                s += ind + "userLastValidatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> KeyTypeEnumType? KeyType
        // GraphQL -> keyType: KeyTypeEnumType! (enum)
        if (ec.Includes("keyType",true))
        {
            if(this.KeyType == null) {

                this.KeyType = new KeyTypeEnumType();

            } else {


            }
        }
        else if (this.KeyType != null && ec.Excludes("keyType",true))
        {
            this.KeyType = null;
        }
        //      C# -> System.String? Browser
        // GraphQL -> browser: String! (scalar)
        if (ec.Includes("browser",true))
        {
            if(this.Browser == null) {

                this.Browser = "FETCH";

            } else {


            }
        }
        else if (this.Browser != null && ec.Excludes("browser",true))
        {
            this.Browser = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        if (ec.Includes("credentialId",true))
        {
            if(this.CredentialId == null) {

                this.CredentialId = "FETCH";

            } else {


            }
        }
        else if (this.CredentialId != null && ec.Excludes("credentialId",true))
        {
            this.CredentialId = null;
        }
        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        if (ec.Includes("os",true))
        {
            if(this.Os == null) {

                this.Os = "FETCH";

            } else {


            }
        }
        else if (this.Os != null && ec.Excludes("os",true))
        {
            this.Os = null;
        }
        //      C# -> System.String? PasskeyName
        // GraphQL -> passkeyName: String! (scalar)
        if (ec.Includes("passkeyName",true))
        {
            if(this.PasskeyName == null) {

                this.PasskeyName = "FETCH";

            } else {


            }
        }
        else if (this.PasskeyName != null && ec.Excludes("passkeyName",true))
        {
            this.PasskeyName = null;
        }
        //      C# -> DateTime? UserLastValidatedAt
        // GraphQL -> userLastValidatedAt: DateTime (scalar)
        if (ec.Includes("userLastValidatedAt",true))
        {
            if(this.UserLastValidatedAt == null) {

                this.UserLastValidatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UserLastValidatedAt != null && ec.Excludes("userLastValidatedAt",true))
        {
            this.UserLastValidatedAt = null;
        }
    }


    #endregion

    } // class Passkey
    
    #endregion

    public static class ListPasskeyExtensions
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
            this List<Passkey> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Passkey> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Passkey> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Passkey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Passkey> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types