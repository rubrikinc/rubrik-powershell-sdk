// KeyVersionInAzureKeyVault.cs
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
    #region KeyVersionInAzureKeyVault
    public class KeyVersionInAzureKeyVault: BaseType
    {
        #region members

        //      C# -> AzureKeyVaultKeyState? KeyState
        // GraphQL -> keyState: AzureKeyVaultKeyState! (enum)
        [JsonProperty("keyState")]
        public AzureKeyVaultKeyState? KeyState { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> DateTime? ExpirationAt
        // GraphQL -> expirationAt: DateTime (scalar)
        [JsonProperty("expirationAt")]
        public DateTime? ExpirationAt { get; set; }

        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        [JsonProperty("keyVersion")]
        public System.String? KeyVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KeyVersionInAzureKeyVault";
    }

    public KeyVersionInAzureKeyVault Set(
        AzureKeyVaultKeyState? KeyState = null,
        DateTime? CreatedAt = null,
        DateTime? ExpirationAt = null,
        System.String? KeyVersion = null
    ) 
    {
        if ( KeyState != null ) {
            this.KeyState = KeyState;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( ExpirationAt != null ) {
            this.ExpirationAt = ExpirationAt;
        }
        if ( KeyVersion != null ) {
            this.KeyVersion = KeyVersion;
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
        //      C# -> AzureKeyVaultKeyState? KeyState
        // GraphQL -> keyState: AzureKeyVaultKeyState! (enum)
        if (this.KeyState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyState\n" ;
            } else {
                s += ind + "keyState\n" ;
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
        //      C# -> DateTime? ExpirationAt
        // GraphQL -> expirationAt: DateTime (scalar)
        if (this.ExpirationAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationAt\n" ;
            } else {
                s += ind + "expirationAt\n" ;
            }
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (this.KeyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVersion\n" ;
            } else {
                s += ind + "keyVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureKeyVaultKeyState? KeyState
        // GraphQL -> keyState: AzureKeyVaultKeyState! (enum)
        if (ec.Includes("keyState",true))
        {
            if(this.KeyState == null) {

                this.KeyState = new AzureKeyVaultKeyState();

            } else {


            }
        }
        else if (this.KeyState != null && ec.Excludes("keyState",true))
        {
            this.KeyState = null;
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
        //      C# -> DateTime? ExpirationAt
        // GraphQL -> expirationAt: DateTime (scalar)
        if (ec.Includes("expirationAt",true))
        {
            if(this.ExpirationAt == null) {

                this.ExpirationAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationAt != null && ec.Excludes("expirationAt",true))
        {
            this.ExpirationAt = null;
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (ec.Includes("keyVersion",true))
        {
            if(this.KeyVersion == null) {

                this.KeyVersion = "FETCH";

            } else {


            }
        }
        else if (this.KeyVersion != null && ec.Excludes("keyVersion",true))
        {
            this.KeyVersion = null;
        }
    }


    #endregion

    } // class KeyVersionInAzureKeyVault
    
    #endregion

    public static class ListKeyVersionInAzureKeyVaultExtensions
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
            this List<KeyVersionInAzureKeyVault> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KeyVersionInAzureKeyVault> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KeyVersionInAzureKeyVault> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KeyVersionInAzureKeyVault());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KeyVersionInAzureKeyVault> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types