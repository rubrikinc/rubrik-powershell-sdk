// DataDiscoveryObjectsCount.cs
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
    #region DataDiscoveryObjectsCount
    public class DataDiscoveryObjectsCount: BaseType
    {
        #region members

        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryAssignedCount")]
        public System.Int64? DataDiscoveryAssignedCount { get; set; }

        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryNotAssignedCount")]
        public System.Int64? DataDiscoveryNotAssignedCount { get; set; }

        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        [JsonProperty("dataDiscoveryNotSupportedCount")]
        public System.Int64? DataDiscoveryNotSupportedCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataDiscoveryObjectsCount";
    }

    public DataDiscoveryObjectsCount Set(
        System.Int64? DataDiscoveryAssignedCount = null,
        System.Int64? DataDiscoveryNotAssignedCount = null,
        System.Int64? DataDiscoveryNotSupportedCount = null
    ) 
    {
        if ( DataDiscoveryAssignedCount != null ) {
            this.DataDiscoveryAssignedCount = DataDiscoveryAssignedCount;
        }
        if ( DataDiscoveryNotAssignedCount != null ) {
            this.DataDiscoveryNotAssignedCount = DataDiscoveryNotAssignedCount;
        }
        if ( DataDiscoveryNotSupportedCount != null ) {
            this.DataDiscoveryNotSupportedCount = DataDiscoveryNotSupportedCount;
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
        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        if (this.DataDiscoveryAssignedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataDiscoveryAssignedCount\n" ;
            } else {
                s += ind + "dataDiscoveryAssignedCount\n" ;
            }
        }
        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        if (this.DataDiscoveryNotAssignedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataDiscoveryNotAssignedCount\n" ;
            } else {
                s += ind + "dataDiscoveryNotAssignedCount\n" ;
            }
        }
        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        if (this.DataDiscoveryNotSupportedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataDiscoveryNotSupportedCount\n" ;
            } else {
                s += ind + "dataDiscoveryNotSupportedCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? DataDiscoveryAssignedCount
        // GraphQL -> dataDiscoveryAssignedCount: Long! (scalar)
        if (ec.Includes("dataDiscoveryAssignedCount",true))
        {
            if(this.DataDiscoveryAssignedCount == null) {

                this.DataDiscoveryAssignedCount = new System.Int64();

            } else {


            }
        }
        else if (this.DataDiscoveryAssignedCount != null && ec.Excludes("dataDiscoveryAssignedCount",true))
        {
            this.DataDiscoveryAssignedCount = null;
        }
        //      C# -> System.Int64? DataDiscoveryNotAssignedCount
        // GraphQL -> dataDiscoveryNotAssignedCount: Long! (scalar)
        if (ec.Includes("dataDiscoveryNotAssignedCount",true))
        {
            if(this.DataDiscoveryNotAssignedCount == null) {

                this.DataDiscoveryNotAssignedCount = new System.Int64();

            } else {


            }
        }
        else if (this.DataDiscoveryNotAssignedCount != null && ec.Excludes("dataDiscoveryNotAssignedCount",true))
        {
            this.DataDiscoveryNotAssignedCount = null;
        }
        //      C# -> System.Int64? DataDiscoveryNotSupportedCount
        // GraphQL -> dataDiscoveryNotSupportedCount: Long! (scalar)
        if (ec.Includes("dataDiscoveryNotSupportedCount",true))
        {
            if(this.DataDiscoveryNotSupportedCount == null) {

                this.DataDiscoveryNotSupportedCount = new System.Int64();

            } else {


            }
        }
        else if (this.DataDiscoveryNotSupportedCount != null && ec.Excludes("dataDiscoveryNotSupportedCount",true))
        {
            this.DataDiscoveryNotSupportedCount = null;
        }
    }


    #endregion

    } // class DataDiscoveryObjectsCount
    
    #endregion

    public static class ListDataDiscoveryObjectsCountExtensions
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
            this List<DataDiscoveryObjectsCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataDiscoveryObjectsCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataDiscoveryObjectsCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataDiscoveryObjectsCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataDiscoveryObjectsCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types