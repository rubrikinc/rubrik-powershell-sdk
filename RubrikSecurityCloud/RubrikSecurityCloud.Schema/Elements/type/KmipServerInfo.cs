// KmipServerInfo.cs
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
    #region KmipServerInfo
 
    public class KmipServerInfo: BaseType, KeyVaultInfo
    {
        #region members

        //      C# -> KmsType? KeyVaultType
        // GraphQL -> keyVaultType: KmsType! (enum)
        [JsonProperty("keyVaultType")]
        public KmsType? KeyVaultType { get; set; }

        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KmipServerInfo";
    }

    public KmipServerInfo Set(
        KmsType? KeyVaultType = null,
        System.String? Address = null,
        System.Int32? Port = null
    ) 
    {
        if ( KeyVaultType != null ) {
            this.KeyVaultType = KeyVaultType;
        }
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            if (conf.Flat) {
                s += conf.Prefix + "address\n" ;
            } else {
                s += ind + "address\n" ;
            }
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
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
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (ec.Includes("address",true))
        {
            if(this.Address == null) {

                this.Address = "FETCH";

            } else {


            }
        }
        else if (this.Address != null && ec.Excludes("address",true))
        {
            this.Address = null;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = Int32.MinValue;

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
    }


    #endregion

    } // class KmipServerInfo
    
    #endregion

    public static class ListKmipServerInfoExtensions
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
            this List<KmipServerInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KmipServerInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KmipServerInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KmipServerInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KmipServerInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types