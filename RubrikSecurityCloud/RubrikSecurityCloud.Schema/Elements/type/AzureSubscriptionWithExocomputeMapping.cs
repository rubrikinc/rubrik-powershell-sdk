// AzureSubscriptionWithExocomputeMapping.cs
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
    #region AzureSubscriptionWithExocomputeMapping
    public class AzureSubscriptionWithExocomputeMapping: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        [JsonProperty("mappedExocomputeSubscription")]
        public AzureMappedExocomputeSubscription? MappedExocomputeSubscription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSubscriptionWithExocomputeMapping";
    }

    public AzureSubscriptionWithExocomputeMapping Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? NativeId = null,
        AzureMappedExocomputeSubscription? MappedExocomputeSubscription = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( MappedExocomputeSubscription != null ) {
            this.MappedExocomputeSubscription = MappedExocomputeSubscription;
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
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription != null) {
            var fspec = this.MappedExocomputeSubscription.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedExocomputeSubscription {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && ec.Includes("nativeId",true))
        {
            this.NativeId = "FETCH";
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription == null && ec.Includes("mappedExocomputeSubscription",false))
        {
            this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
            this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeSubscription"));
        }
    }


    #endregion

    } // class AzureSubscriptionWithExocomputeMapping
    
    #endregion

    public static class ListAzureSubscriptionWithExocomputeMappingExtensions
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
            this List<AzureSubscriptionWithExocomputeMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSubscriptionWithExocomputeMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSubscriptionWithExocomputeMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureSubscriptionWithExocomputeMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types