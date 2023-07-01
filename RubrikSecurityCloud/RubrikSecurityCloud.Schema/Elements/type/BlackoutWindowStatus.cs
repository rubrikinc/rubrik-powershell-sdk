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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        if (this.IsGlobalBlackoutActive != null) {
            s += ind + "isGlobalBlackoutActive\n" ;
        }
        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        if (this.IsSnappableBlackoutActive != null) {
            s += ind + "isSnappableBlackoutActive\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        if (this.IsGlobalBlackoutActive == null && Exploration.Includes(parent + ".isGlobalBlackoutActive", true))
        {
            this.IsGlobalBlackoutActive = true;
        }
        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        if (this.IsSnappableBlackoutActive == null && Exploration.Includes(parent + ".isSnappableBlackoutActive", true))
        {
            this.IsSnappableBlackoutActive = true;
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindowStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindowStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types