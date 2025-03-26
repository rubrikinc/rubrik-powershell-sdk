// NtpSymmKeyConfiguration.cs
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
    #region NtpSymmKeyConfiguration
    public class NtpSymmKeyConfiguration: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Int32? KeyId
        // GraphQL -> keyId: Int! (scalar)
        [JsonProperty("keyId")]
        public System.Int32? KeyId { get; set; }

        //      C# -> System.String? KeyType
        // GraphQL -> keyType: String! (scalar)
        [JsonProperty("keyType")]
        public System.String? KeyType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NtpSymmKeyConfiguration";
    }

    public NtpSymmKeyConfiguration Set(
        System.String? Key = null,
        System.Int32? KeyId = null,
        System.String? KeyType = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyId != null ) {
            this.KeyId = KeyId;
        }
        if ( KeyType != null ) {
            this.KeyType = KeyType;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.Int32? KeyId
        // GraphQL -> keyId: Int! (scalar)
        if (this.KeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyId\n" ;
            } else {
                s += ind + "keyId\n" ;
            }
        }
        //      C# -> System.String? KeyType
        // GraphQL -> keyType: String! (scalar)
        if (this.KeyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyType\n" ;
            } else {
                s += ind + "keyType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.Int32? KeyId
        // GraphQL -> keyId: Int! (scalar)
        if (ec.Includes("keyId",true))
        {
            if(this.KeyId == null) {

                this.KeyId = Int32.MinValue;

            } else {


            }
        }
        else if (this.KeyId != null && ec.Excludes("keyId",true))
        {
            this.KeyId = null;
        }
        //      C# -> System.String? KeyType
        // GraphQL -> keyType: String! (scalar)
        if (ec.Includes("keyType",true))
        {
            if(this.KeyType == null) {

                this.KeyType = "FETCH";

            } else {


            }
        }
        else if (this.KeyType != null && ec.Excludes("keyType",true))
        {
            this.KeyType = null;
        }
    }


    #endregion

    } // class NtpSymmKeyConfiguration
    
    #endregion

    public static class ListNtpSymmKeyConfigurationExtensions
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
            this List<NtpSymmKeyConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NtpSymmKeyConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NtpSymmKeyConfiguration> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NtpSymmKeyConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NtpSymmKeyConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types