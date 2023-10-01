// AzureCmk.cs
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
    #region AzureCmk
    public class AzureCmk: BaseType
    {
        #region members

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        [JsonProperty("keyVaultName")]
        public System.String? KeyVaultName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCmk";
    }

    public AzureCmk Set(
        AzureRegion? Region = null,
        System.String? KeyName = null,
        System.String? KeyVaultName = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( KeyName != null ) {
            this.KeyName = KeyName;
        }
        if ( KeyVaultName != null ) {
            this.KeyVaultName = KeyVaultName;
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
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyName\n" ;
            } else {
                s += ind + "keyName\n" ;
            }
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (this.KeyVaultName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVaultName\n" ;
            } else {
                s += ind + "keyVaultName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (ec.Includes("keyName",true))
        {
            if(this.KeyName == null) {

                this.KeyName = "FETCH";

            } else {


            }
        }
        else if (this.KeyName != null && ec.Excludes("keyName",true))
        {
            this.KeyName = null;
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (ec.Includes("keyVaultName",true))
        {
            if(this.KeyVaultName == null) {

                this.KeyVaultName = "FETCH";

            } else {


            }
        }
        else if (this.KeyVaultName != null && ec.Excludes("keyVaultName",true))
        {
            this.KeyVaultName = null;
        }
    }


    #endregion

    } // class AzureCmk
    
    #endregion

    public static class ListAzureCmkExtensions
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
            this List<AzureCmk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureCmk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCmk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCmk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCmk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types