// BlackoutWindowResponseInfo.cs
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
    #region BlackoutWindowResponseInfo
    public class BlackoutWindowResponseInfo: BaseType
    {
        #region members

        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        [JsonProperty("blackoutWindowStatus")]
        public BlackoutWindowStatus? BlackoutWindowStatus { get; set; }

        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        [JsonProperty("blackoutWindows")]
        public BlackoutWindows? BlackoutWindows { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlackoutWindowResponseInfo";
    }

    public BlackoutWindowResponseInfo Set(
        BlackoutWindowStatus? BlackoutWindowStatus = null,
        BlackoutWindows? BlackoutWindows = null
    ) 
    {
        if ( BlackoutWindowStatus != null ) {
            this.BlackoutWindowStatus = BlackoutWindowStatus;
        }
        if ( BlackoutWindows != null ) {
            this.BlackoutWindows = BlackoutWindows;
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
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (this.BlackoutWindowStatus != null) {
            var fspec = this.BlackoutWindowStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blackoutWindowStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (this.BlackoutWindows != null) {
            var fspec = this.BlackoutWindows.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blackoutWindows {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (this.BlackoutWindowStatus == null && ec.Includes("blackoutWindowStatus",false))
        {
            this.BlackoutWindowStatus = new BlackoutWindowStatus();
            this.BlackoutWindowStatus.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowStatus"));
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (this.BlackoutWindows == null && ec.Includes("blackoutWindows",false))
        {
            this.BlackoutWindows = new BlackoutWindows();
            this.BlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindows"));
        }
    }


    #endregion

    } // class BlackoutWindowResponseInfo
    
    #endregion

    public static class ListBlackoutWindowResponseInfoExtensions
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
            this List<BlackoutWindowResponseInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlackoutWindowResponseInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlackoutWindowResponseInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlackoutWindowResponseInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types