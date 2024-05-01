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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureImmutabilitySettingsType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureImmutabilitySettingsType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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