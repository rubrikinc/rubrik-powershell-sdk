// AzureNativeStorageAccount.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeStorageAccount
    public class AzureNativeStorageAccount: BaseType
    {
        #region members

        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        [JsonProperty("region")]
        public AzureNativeRegion? Region { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureTag>? Tags { get; set; }


        #endregion

    #region methods

    public AzureNativeStorageAccount Set(
        AzureNativeRegion? Region = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? ResourceGroupName = null,
        List<AzureTag>? Tags = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ResourceGroupName != null ) {
            this.ResourceGroupName = ResourceGroupName;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName != null) {
            s += ind + "resourceGroupName\n" ;
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags != null) {
            s += ind + "tags {\n" + this.Tags.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureNativeRegion();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        if (this.ResourceGroupName == null && Exploration.Includes(parent + ".resourceGroupName", true))
        {
            this.ResourceGroupName = "FETCH";
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<AzureTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
    }


    #endregion

    } // class AzureNativeStorageAccount
    
    #endregion

    public static class ListAzureNativeStorageAccountExtensions
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
            this List<AzureNativeStorageAccount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeStorageAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeStorageAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types