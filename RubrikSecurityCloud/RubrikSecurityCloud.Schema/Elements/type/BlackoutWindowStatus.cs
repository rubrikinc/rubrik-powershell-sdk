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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            this List<BlackoutWindowStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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