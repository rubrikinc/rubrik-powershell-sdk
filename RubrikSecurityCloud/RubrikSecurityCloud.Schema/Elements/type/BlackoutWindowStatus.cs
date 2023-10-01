// BlackoutWindowStatus.cs
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
    #region BlackoutWindowStatus
    public class BlackoutWindowStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        [JsonProperty("isGlobalBlackoutActive")]
        public System.Boolean? IsGlobalBlackoutActive { get; set; }

        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        [JsonProperty("isSnappableBlackoutActive")]
        public System.Boolean? IsSnappableBlackoutActive { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlackoutWindowStatus";
    }

    public BlackoutWindowStatus Set(
        System.Boolean? IsGlobalBlackoutActive = null,
        System.Boolean? IsSnappableBlackoutActive = null
    ) 
    {
        if ( IsGlobalBlackoutActive != null ) {
            this.IsGlobalBlackoutActive = IsGlobalBlackoutActive;
        }
        if ( IsSnappableBlackoutActive != null ) {
            this.IsSnappableBlackoutActive = IsSnappableBlackoutActive;
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
        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        if (this.IsGlobalBlackoutActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isGlobalBlackoutActive\n" ;
            } else {
                s += ind + "isGlobalBlackoutActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        if (this.IsSnappableBlackoutActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnappableBlackoutActive\n" ;
            } else {
                s += ind + "isSnappableBlackoutActive\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        if (ec.Includes("isGlobalBlackoutActive",true))
        {
            if(this.IsGlobalBlackoutActive == null) {

                this.IsGlobalBlackoutActive = true;

            } else {


            }
        }
        else if (this.IsGlobalBlackoutActive != null && ec.Excludes("isGlobalBlackoutActive",true))
        {
            this.IsGlobalBlackoutActive = null;
        }
        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        if (ec.Includes("isSnappableBlackoutActive",true))
        {
            if(this.IsSnappableBlackoutActive == null) {

                this.IsSnappableBlackoutActive = true;

            } else {


            }
        }
        else if (this.IsSnappableBlackoutActive != null && ec.Excludes("isSnappableBlackoutActive",true))
        {
            this.IsSnappableBlackoutActive = null;
        }
    }


    #endregion

    } // class BlackoutWindowStatus
    
    #endregion

    public static class ListBlackoutWindowStatusExtensions
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
            this List<BlackoutWindowStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BlackoutWindowStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindowStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindowStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlackoutWindowStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types