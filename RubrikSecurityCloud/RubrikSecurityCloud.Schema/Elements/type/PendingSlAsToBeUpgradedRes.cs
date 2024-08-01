// PendingSlAsToBeUpgradedRes.cs
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
    #region PendingSlAsToBeUpgradedRes
    public class PendingSlAsToBeUpgradedRes: BaseType
    {
        #region members

        //      C# -> System.Int32? ClustersWithPendingCount
        // GraphQL -> clustersWithPendingCount: Int! (scalar)
        [JsonProperty("clustersWithPendingCount")]
        public System.Int32? ClustersWithPendingCount { get; set; }

        //      C# -> System.Int32? TotalPendingUpgradableCount
        // GraphQL -> totalPendingUpgradableCount: Int! (scalar)
        [JsonProperty("totalPendingUpgradableCount")]
        public System.Int32? TotalPendingUpgradableCount { get; set; }

        //      C# -> System.Int32? UserPendingUpgradableCount
        // GraphQL -> userPendingUpgradableCount: Int! (scalar)
        [JsonProperty("userPendingUpgradableCount")]
        public System.Int32? UserPendingUpgradableCount { get; set; }

        //      C# -> List<SlaUpgradeIneligibility>? Slas
        // GraphQL -> slas: [SLAUpgradeIneligibility!]! (type)
        [JsonProperty("slas")]
        public List<SlaUpgradeIneligibility>? Slas { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PendingSLAsToBeUpgradedRes";
    }

    public PendingSlAsToBeUpgradedRes Set(
        System.Int32? ClustersWithPendingCount = null,
        System.Int32? TotalPendingUpgradableCount = null,
        System.Int32? UserPendingUpgradableCount = null,
        List<SlaUpgradeIneligibility>? Slas = null
    ) 
    {
        if ( ClustersWithPendingCount != null ) {
            this.ClustersWithPendingCount = ClustersWithPendingCount;
        }
        if ( TotalPendingUpgradableCount != null ) {
            this.TotalPendingUpgradableCount = TotalPendingUpgradableCount;
        }
        if ( UserPendingUpgradableCount != null ) {
            this.UserPendingUpgradableCount = UserPendingUpgradableCount;
        }
        if ( Slas != null ) {
            this.Slas = Slas;
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
        //      C# -> System.Int32? ClustersWithPendingCount
        // GraphQL -> clustersWithPendingCount: Int! (scalar)
        if (this.ClustersWithPendingCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clustersWithPendingCount\n" ;
            } else {
                s += ind + "clustersWithPendingCount\n" ;
            }
        }
        //      C# -> System.Int32? TotalPendingUpgradableCount
        // GraphQL -> totalPendingUpgradableCount: Int! (scalar)
        if (this.TotalPendingUpgradableCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalPendingUpgradableCount\n" ;
            } else {
                s += ind + "totalPendingUpgradableCount\n" ;
            }
        }
        //      C# -> System.Int32? UserPendingUpgradableCount
        // GraphQL -> userPendingUpgradableCount: Int! (scalar)
        if (this.UserPendingUpgradableCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userPendingUpgradableCount\n" ;
            } else {
                s += ind + "userPendingUpgradableCount\n" ;
            }
        }
        //      C# -> List<SlaUpgradeIneligibility>? Slas
        // GraphQL -> slas: [SLAUpgradeIneligibility!]! (type)
        if (this.Slas != null) {
            var fspec = this.Slas.AsFieldSpec(conf.Child("slas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slas" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ClustersWithPendingCount
        // GraphQL -> clustersWithPendingCount: Int! (scalar)
        if (ec.Includes("clustersWithPendingCount",true))
        {
            if(this.ClustersWithPendingCount == null) {

                this.ClustersWithPendingCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ClustersWithPendingCount != null && ec.Excludes("clustersWithPendingCount",true))
        {
            this.ClustersWithPendingCount = null;
        }
        //      C# -> System.Int32? TotalPendingUpgradableCount
        // GraphQL -> totalPendingUpgradableCount: Int! (scalar)
        if (ec.Includes("totalPendingUpgradableCount",true))
        {
            if(this.TotalPendingUpgradableCount == null) {

                this.TotalPendingUpgradableCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalPendingUpgradableCount != null && ec.Excludes("totalPendingUpgradableCount",true))
        {
            this.TotalPendingUpgradableCount = null;
        }
        //      C# -> System.Int32? UserPendingUpgradableCount
        // GraphQL -> userPendingUpgradableCount: Int! (scalar)
        if (ec.Includes("userPendingUpgradableCount",true))
        {
            if(this.UserPendingUpgradableCount == null) {

                this.UserPendingUpgradableCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UserPendingUpgradableCount != null && ec.Excludes("userPendingUpgradableCount",true))
        {
            this.UserPendingUpgradableCount = null;
        }
        //      C# -> List<SlaUpgradeIneligibility>? Slas
        // GraphQL -> slas: [SLAUpgradeIneligibility!]! (type)
        if (ec.Includes("slas",false))
        {
            if(this.Slas == null) {

                this.Slas = new List<SlaUpgradeIneligibility>();
                this.Slas.ApplyExploratoryFieldSpec(ec.NewChild("slas"));

            } else {

                this.Slas.ApplyExploratoryFieldSpec(ec.NewChild("slas"));

            }
        }
        else if (this.Slas != null && ec.Excludes("slas",false))
        {
            this.Slas = null;
        }
    }


    #endregion

    } // class PendingSlAsToBeUpgradedRes
    
    #endregion

    public static class ListPendingSlAsToBeUpgradedResExtensions
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
            this List<PendingSlAsToBeUpgradedRes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PendingSlAsToBeUpgradedRes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PendingSlAsToBeUpgradedRes> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingSlAsToBeUpgradedRes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PendingSlAsToBeUpgradedRes> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types