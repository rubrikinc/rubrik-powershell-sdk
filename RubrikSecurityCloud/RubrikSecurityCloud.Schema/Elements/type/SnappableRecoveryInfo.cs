// SnappableRecoveryInfo.cs
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
    #region SnappableRecoveryInfo
    public class SnappableRecoveryInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        [JsonProperty("isRefreshInProgressOpt")]
        public System.Boolean? IsRefreshInProgressOpt { get; set; }

        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        [JsonProperty("lastUpdatedTimeOpt")]
        public DateTime? LastUpdatedTimeOpt { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? NewSnappableId
        // GraphQL -> newSnappableId: String! (scalar)
        [JsonProperty("newSnappableId")]
        public System.String? NewSnappableId { get; set; }

        //      C# -> System.String? OldSnappableId
        // GraphQL -> oldSnappableId: String! (scalar)
        [JsonProperty("oldSnappableId")]
        public System.String? OldSnappableId { get; set; }


        #endregion

    #region methods

    public SnappableRecoveryInfo Set(
        System.Boolean? IsRefreshInProgressOpt = null,
        DateTime? LastUpdatedTimeOpt = null,
        System.String? LocationId = null,
        System.String? NewSnappableId = null,
        System.String? OldSnappableId = null
    ) 
    {
        if ( IsRefreshInProgressOpt != null ) {
            this.IsRefreshInProgressOpt = IsRefreshInProgressOpt;
        }
        if ( LastUpdatedTimeOpt != null ) {
            this.LastUpdatedTimeOpt = LastUpdatedTimeOpt;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( NewSnappableId != null ) {
            this.NewSnappableId = NewSnappableId;
        }
        if ( OldSnappableId != null ) {
            this.OldSnappableId = OldSnappableId;
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
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (this.IsRefreshInProgressOpt != null) {
            s += ind + "isRefreshInProgressOpt\n" ;
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (this.LastUpdatedTimeOpt != null) {
            s += ind + "lastUpdatedTimeOpt\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> System.String? NewSnappableId
        // GraphQL -> newSnappableId: String! (scalar)
        if (this.NewSnappableId != null) {
            s += ind + "newSnappableId\n" ;
        }
        //      C# -> System.String? OldSnappableId
        // GraphQL -> oldSnappableId: String! (scalar)
        if (this.OldSnappableId != null) {
            s += ind + "oldSnappableId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsRefreshInProgressOpt
        // GraphQL -> isRefreshInProgressOpt: Boolean (scalar)
        if (this.IsRefreshInProgressOpt == null && Exploration.Includes(parent + ".isRefreshInProgressOpt", true))
        {
            this.IsRefreshInProgressOpt = true;
        }
        //      C# -> DateTime? LastUpdatedTimeOpt
        // GraphQL -> lastUpdatedTimeOpt: DateTime (scalar)
        if (this.LastUpdatedTimeOpt == null && Exploration.Includes(parent + ".lastUpdatedTimeOpt", true))
        {
            this.LastUpdatedTimeOpt = new DateTime();
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = "FETCH";
        }
        //      C# -> System.String? NewSnappableId
        // GraphQL -> newSnappableId: String! (scalar)
        if (this.NewSnappableId == null && Exploration.Includes(parent + ".newSnappableId", true))
        {
            this.NewSnappableId = "FETCH";
        }
        //      C# -> System.String? OldSnappableId
        // GraphQL -> oldSnappableId: String! (scalar)
        if (this.OldSnappableId == null && Exploration.Includes(parent + ".oldSnappableId", true))
        {
            this.OldSnappableId = "FETCH";
        }
    }


    #endregion

    } // class SnappableRecoveryInfo
    
    #endregion

    public static class ListSnappableRecoveryInfoExtensions
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
            this List<SnappableRecoveryInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableRecoveryInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types