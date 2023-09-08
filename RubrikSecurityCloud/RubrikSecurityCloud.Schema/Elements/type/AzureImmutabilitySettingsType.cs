// AzureImmutabilitySettingsType.cs
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
    #region AzureImmutabilitySettingsType
    public class AzureImmutabilitySettingsType: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        [JsonProperty("isBlobImmutabilityEnabled")]
        public System.Boolean? IsBlobImmutabilityEnabled { get; set; }

        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        [JsonProperty("lockDurationDays")]
        public System.Int32? LockDurationDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureImmutabilitySettingsType";
    }

    public AzureImmutabilitySettingsType Set(
        System.Boolean? IsBlobImmutabilityEnabled = null,
        System.Int32? LockDurationDays = null
    ) 
    {
        if ( IsBlobImmutabilityEnabled != null ) {
            this.IsBlobImmutabilityEnabled = IsBlobImmutabilityEnabled;
        }
        if ( LockDurationDays != null ) {
            this.LockDurationDays = LockDurationDays;
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
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (this.IsBlobImmutabilityEnabled != null) {
            s += ind + "isBlobImmutabilityEnabled\n" ;
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays != null) {
            s += ind + "lockDurationDays\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (this.IsBlobImmutabilityEnabled == null && ec.Includes("isBlobImmutabilityEnabled",true))
        {
            this.IsBlobImmutabilityEnabled = true;
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays == null && ec.Includes("lockDurationDays",true))
        {
            this.LockDurationDays = Int32.MinValue;
        }
    }


    #endregion

    } // class AzureImmutabilitySettingsType
    
    #endregion

    public static class ListAzureImmutabilitySettingsTypeExtensions
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
            this List<AzureImmutabilitySettingsType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureImmutabilitySettingsType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureImmutabilitySettingsType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureImmutabilitySettingsType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types