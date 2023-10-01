// CountOfObjectsProtectedBySlAsResult.cs
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
    #region CountOfObjectsProtectedBySlAsResult
    public class CountOfObjectsProtectedBySlAsResult: BaseType
    {
        #region members

        //      C# -> List<SlaIdToObjectCount>? SlaObjectCounts
        // GraphQL -> slaObjectCounts: [SLAIdToObjectCount!]! (type)
        [JsonProperty("slaObjectCounts")]
        public List<SlaIdToObjectCount>? SlaObjectCounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CountOfObjectsProtectedBySLAsResult";
    }

    public CountOfObjectsProtectedBySlAsResult Set(
        List<SlaIdToObjectCount>? SlaObjectCounts = null
    ) 
    {
        if ( SlaObjectCounts != null ) {
            this.SlaObjectCounts = SlaObjectCounts;
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
        //      C# -> List<SlaIdToObjectCount>? SlaObjectCounts
        // GraphQL -> slaObjectCounts: [SLAIdToObjectCount!]! (type)
        if (this.SlaObjectCounts != null) {
            var fspec = this.SlaObjectCounts.AsFieldSpec(conf.Child("slaObjectCounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaObjectCounts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaIdToObjectCount>? SlaObjectCounts
        // GraphQL -> slaObjectCounts: [SLAIdToObjectCount!]! (type)
        if (ec.Includes("slaObjectCounts",false))
        {
            if(this.SlaObjectCounts == null) {

                this.SlaObjectCounts = new List<SlaIdToObjectCount>();
                this.SlaObjectCounts.ApplyExploratoryFieldSpec(ec.NewChild("slaObjectCounts"));

            } else {

                this.SlaObjectCounts.ApplyExploratoryFieldSpec(ec.NewChild("slaObjectCounts"));

            }
        }
        else if (this.SlaObjectCounts != null && ec.Excludes("slaObjectCounts",false))
        {
            this.SlaObjectCounts = null;
        }
    }


    #endregion

    } // class CountOfObjectsProtectedBySlAsResult
    
    #endregion

    public static class ListCountOfObjectsProtectedBySlAsResultExtensions
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
            this List<CountOfObjectsProtectedBySlAsResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CountOfObjectsProtectedBySlAsResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CountOfObjectsProtectedBySlAsResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CountOfObjectsProtectedBySlAsResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CountOfObjectsProtectedBySlAsResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types