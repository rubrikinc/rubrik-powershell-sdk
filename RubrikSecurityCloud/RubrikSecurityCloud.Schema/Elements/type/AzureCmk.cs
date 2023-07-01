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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            s += ind + "keyName\n" ;
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (this.KeyVaultName != null) {
            s += ind + "keyVaultName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureRegion();
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName == null && Exploration.Includes(parent + ".keyName", true))
        {
            this.KeyName = "FETCH";
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (this.KeyVaultName == null && Exploration.Includes(parent + ".keyVaultName", true))
        {
            this.KeyVaultName = "FETCH";
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCmk> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCmk());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types