// V1BulkUpdateExchangeDagResponse.cs
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
    #region V1BulkUpdateExchangeDagResponse
    public class V1BulkUpdateExchangeDagResponse: BaseType
    {
        #region members

        //      C# -> List<ExchangeDagSummary>? Items
        // GraphQL -> items: [ExchangeDagSummary!]! (type)
        [JsonProperty("items")]
        public List<ExchangeDagSummary>? Items { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "V1BulkUpdateExchangeDagResponse";
    }

    public V1BulkUpdateExchangeDagResponse Set(
        List<ExchangeDagSummary>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<ExchangeDagSummary>? Items
        // GraphQL -> items: [ExchangeDagSummary!]! (type)
        if (this.Items != null) {
            var fspec = this.Items.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "items {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ExchangeDagSummary>? Items
        // GraphQL -> items: [ExchangeDagSummary!]! (type)
        if (this.Items == null && ec.Includes("items",false))
        {
            this.Items = new List<ExchangeDagSummary>();
            this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));
        }
    }


    #endregion

    } // class V1BulkUpdateExchangeDagResponse
    
    #endregion

    public static class ListV1BulkUpdateExchangeDagResponseExtensions
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
            this List<V1BulkUpdateExchangeDagResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<V1BulkUpdateExchangeDagResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new V1BulkUpdateExchangeDagResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<V1BulkUpdateExchangeDagResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types