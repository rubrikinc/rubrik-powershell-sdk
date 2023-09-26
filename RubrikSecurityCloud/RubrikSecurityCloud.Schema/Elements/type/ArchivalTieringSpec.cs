// ArchivalTieringSpec.cs
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
    #region ArchivalTieringSpec
    public class ArchivalTieringSpec: BaseType
    {
        #region members

        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        [JsonProperty("coldStorageClass")]
        public ColdStorageClass? ColdStorageClass { get; set; }

        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        [JsonProperty("isInstantTieringEnabled")]
        public System.Boolean? IsInstantTieringEnabled { get; set; }

        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        [JsonProperty("minAccessibleDurationInSeconds")]
        public System.Int64? MinAccessibleDurationInSeconds { get; set; }

        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        [JsonProperty("shouldTierExistingSnapshots")]
        public System.Boolean? ShouldTierExistingSnapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalTieringSpec";
    }

    public ArchivalTieringSpec Set(
        ColdStorageClass? ColdStorageClass = null,
        System.Boolean? IsInstantTieringEnabled = null,
        System.Int64? MinAccessibleDurationInSeconds = null,
        System.Boolean? ShouldTierExistingSnapshots = null
    ) 
    {
        if ( ColdStorageClass != null ) {
            this.ColdStorageClass = ColdStorageClass;
        }
        if ( IsInstantTieringEnabled != null ) {
            this.IsInstantTieringEnabled = IsInstantTieringEnabled;
        }
        if ( MinAccessibleDurationInSeconds != null ) {
            this.MinAccessibleDurationInSeconds = MinAccessibleDurationInSeconds;
        }
        if ( ShouldTierExistingSnapshots != null ) {
            this.ShouldTierExistingSnapshots = ShouldTierExistingSnapshots;
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
        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        if (this.ColdStorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "coldStorageClass\n" ;
            } else {
                s += ind + "coldStorageClass\n" ;
            }
        }
        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        if (this.IsInstantTieringEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInstantTieringEnabled\n" ;
            } else {
                s += ind + "isInstantTieringEnabled\n" ;
            }
        }
        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        if (this.MinAccessibleDurationInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minAccessibleDurationInSeconds\n" ;
            } else {
                s += ind + "minAccessibleDurationInSeconds\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        if (this.ShouldTierExistingSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldTierExistingSnapshots\n" ;
            } else {
                s += ind + "shouldTierExistingSnapshots\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        if (ec.Includes("coldStorageClass",true))
        {
            if(this.ColdStorageClass == null) {

                this.ColdStorageClass = new ColdStorageClass();

            } else {


            }
        }
        else if (this.ColdStorageClass != null && ec.Excludes("coldStorageClass",true))
        {
            this.ColdStorageClass = null;
        }
        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        if (ec.Includes("isInstantTieringEnabled",true))
        {
            if(this.IsInstantTieringEnabled == null) {

                this.IsInstantTieringEnabled = true;

            } else {


            }
        }
        else if (this.IsInstantTieringEnabled != null && ec.Excludes("isInstantTieringEnabled",true))
        {
            this.IsInstantTieringEnabled = null;
        }
        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        if (ec.Includes("minAccessibleDurationInSeconds",true))
        {
            if(this.MinAccessibleDurationInSeconds == null) {

                this.MinAccessibleDurationInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.MinAccessibleDurationInSeconds != null && ec.Excludes("minAccessibleDurationInSeconds",true))
        {
            this.MinAccessibleDurationInSeconds = null;
        }
        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        if (ec.Includes("shouldTierExistingSnapshots",true))
        {
            if(this.ShouldTierExistingSnapshots == null) {

                this.ShouldTierExistingSnapshots = true;

            } else {


            }
        }
        else if (this.ShouldTierExistingSnapshots != null && ec.Excludes("shouldTierExistingSnapshots",true))
        {
            this.ShouldTierExistingSnapshots = null;
        }
    }


    #endregion

    } // class ArchivalTieringSpec
    
    #endregion

    public static class ListArchivalTieringSpecExtensions
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
            this List<ArchivalTieringSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalTieringSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalTieringSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalTieringSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types