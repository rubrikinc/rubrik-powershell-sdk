// AzureRegionsResp.cs
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
    #region AzureRegionsResp
    public class AzureRegionsResp: BaseType
    {
        #region members

        //      C# -> List<Region>? Regions
        // GraphQL -> regions: [Region!]! (type)
        [JsonProperty("regions")]
        public List<Region>? Regions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureRegionsResp";
    }

    public AzureRegionsResp Set(
        List<Region>? Regions = null
    ) 
    {
        if ( Regions != null ) {
            this.Regions = Regions;
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
        //      C# -> List<Region>? Regions
        // GraphQL -> regions: [Region!]! (type)
        if (this.Regions != null) {
            var fspec = this.Regions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "regions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Region>? Regions
        // GraphQL -> regions: [Region!]! (type)
        if (this.Regions == null && ec.Includes("regions",false))
        {
            this.Regions = new List<Region>();
            this.Regions.ApplyExploratoryFieldSpec(ec.NewChild("regions"));
        }
    }


    #endregion

    } // class AzureRegionsResp
    
    #endregion

    public static class ListAzureRegionsRespExtensions
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
            this List<AzureRegionsResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureRegionsResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureRegionsResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureRegionsResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types