// PrecheckFailure.cs
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
    #region PrecheckFailure
    public class PrecheckFailure: BaseType
    {
        #region members

        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        [JsonProperty("precheckIdentifier")]
        public PrecheckIdentifier? PrecheckIdentifier { get; set; }

        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        [JsonProperty("cause")]
        public System.String? Cause { get; set; }

        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        [JsonProperty("precheckName")]
        public System.String? PrecheckName { get; set; }

        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        [JsonProperty("remedy")]
        public System.String? Remedy { get; set; }

        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        [JsonProperty("upgradeBlocker")]
        public System.Boolean? UpgradeBlocker { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrecheckFailure";
    }

    public PrecheckFailure Set(
        PrecheckIdentifier? PrecheckIdentifier = null,
        System.String? Cause = null,
        System.String? PrecheckName = null,
        System.String? Remedy = null,
        System.Boolean? UpgradeBlocker = null
    ) 
    {
        if ( PrecheckIdentifier != null ) {
            this.PrecheckIdentifier = PrecheckIdentifier;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( PrecheckName != null ) {
            this.PrecheckName = PrecheckName;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
        }
        if ( UpgradeBlocker != null ) {
            this.UpgradeBlocker = UpgradeBlocker;
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
        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        if (this.PrecheckIdentifier != null) {
            s += ind + "precheckIdentifier\n" ;
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (this.Cause != null) {
            s += ind + "cause\n" ;
        }
        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        if (this.PrecheckName != null) {
            s += ind + "precheckName\n" ;
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (this.Remedy != null) {
            s += ind + "remedy\n" ;
        }
        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        if (this.UpgradeBlocker != null) {
            s += ind + "upgradeBlocker\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrecheckIdentifier? PrecheckIdentifier
        // GraphQL -> precheckIdentifier: PrecheckIdentifier! (enum)
        if (this.PrecheckIdentifier == null && ec.Includes("precheckIdentifier",true))
        {
            this.PrecheckIdentifier = new PrecheckIdentifier();
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (this.Cause == null && ec.Includes("cause",true))
        {
            this.Cause = "FETCH";
        }
        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        if (this.PrecheckName == null && ec.Includes("precheckName",true))
        {
            this.PrecheckName = "FETCH";
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (this.Remedy == null && ec.Includes("remedy",true))
        {
            this.Remedy = "FETCH";
        }
        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        if (this.UpgradeBlocker == null && ec.Includes("upgradeBlocker",true))
        {
            this.UpgradeBlocker = true;
        }
    }


    #endregion

    } // class PrecheckFailure
    
    #endregion

    public static class ListPrecheckFailureExtensions
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
            this List<PrecheckFailure> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrecheckFailure> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrecheckFailure());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PrecheckFailure> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types