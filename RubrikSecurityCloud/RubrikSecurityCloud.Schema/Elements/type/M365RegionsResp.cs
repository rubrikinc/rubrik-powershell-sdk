// M365RegionsResp.cs
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
    #region M365RegionsResp
    public class M365RegionsResp: BaseType
    {
        #region members

        //      C# -> List<M365Region>? Regions
        // GraphQL -> regions: [M365Region!]! (type)
        [JsonProperty("regions")]
        public List<M365Region>? Regions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365RegionsResp";
    }

    public M365RegionsResp Set(
        List<M365Region>? Regions = null
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<M365Region>? Regions
        // GraphQL -> regions: [M365Region!]! (type)
        if (this.Regions != null) {
            var fspec = this.Regions.AsFieldSpec(conf.Child("regions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<M365Region>? Regions
        // GraphQL -> regions: [M365Region!]! (type)
        if (ec.Includes("regions",false))
        {
            if(this.Regions == null) {

                this.Regions = new List<M365Region>();
                this.Regions.ApplyExploratoryFieldSpec(ec.NewChild("regions"));

            } else {

                this.Regions.ApplyExploratoryFieldSpec(ec.NewChild("regions"));

            }
        }
        else if (this.Regions != null && ec.Excludes("regions",false))
        {
            this.Regions = null;
        }
    }


    #endregion

    } // class M365RegionsResp
    
    #endregion

    public static class ListM365RegionsRespExtensions
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
            this List<M365RegionsResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<M365RegionsResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365RegionsResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365RegionsResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types