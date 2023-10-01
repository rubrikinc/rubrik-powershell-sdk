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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<NtpSymmKeyConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NtpSymmKeyConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NtpSymmKeyConfiguration> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NtpSymmKeyConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NtpSymmKeyConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types