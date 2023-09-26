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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (this.IsBlobImmutabilityEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBlobImmutabilityEnabled\n" ;
            } else {
                s += ind + "isBlobImmutabilityEnabled\n" ;
            }
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockDurationDays\n" ;
            } else {
                s += ind + "lockDurationDays\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (ec.Includes("isBlobImmutabilityEnabled",true))
        {
            if(this.IsBlobImmutabilityEnabled == null) {

                this.IsBlobImmutabilityEnabled = true;

            } else {


            }
        }
        else if (this.IsBlobImmutabilityEnabled != null && ec.Excludes("isBlobImmutabilityEnabled",true))
        {
            this.IsBlobImmutabilityEnabled = null;
        }
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (ec.Includes("lockDurationDays",true))
        {
            if(this.LockDurationDays == null) {

                this.LockDurationDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.LockDurationDays != null && ec.Excludes("lockDurationDays",true))
        {
            this.LockDurationDays = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<AzureImmutabilitySettingsType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types