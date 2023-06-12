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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        if (this.ColdStorageClass != null) {
            s += ind + "coldStorageClass\n" ;
        }
        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        if (this.IsInstantTieringEnabled != null) {
            s += ind + "isInstantTieringEnabled\n" ;
        }
        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        if (this.MinAccessibleDurationInSeconds != null) {
            s += ind + "minAccessibleDurationInSeconds\n" ;
        }
        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        if (this.ShouldTierExistingSnapshots != null) {
            s += ind + "shouldTierExistingSnapshots\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass! (enum)
        if (this.ColdStorageClass == null && Exploration.Includes(parent + ".coldStorageClass", true))
        {
            this.ColdStorageClass = new ColdStorageClass();
        }
        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean! (scalar)
        if (this.IsInstantTieringEnabled == null && Exploration.Includes(parent + ".isInstantTieringEnabled", true))
        {
            this.IsInstantTieringEnabled = true;
        }
        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long! (scalar)
        if (this.MinAccessibleDurationInSeconds == null && Exploration.Includes(parent + ".minAccessibleDurationInSeconds", true))
        {
            this.MinAccessibleDurationInSeconds = new System.Int64();
        }
        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean! (scalar)
        if (this.ShouldTierExistingSnapshots == null && Exploration.Includes(parent + ".shouldTierExistingSnapshots", true))
        {
            this.ShouldTierExistingSnapshots = true;
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalTieringSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalTieringSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types