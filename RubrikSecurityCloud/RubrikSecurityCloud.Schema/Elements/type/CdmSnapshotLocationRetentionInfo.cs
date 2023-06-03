// CdmSnapshotLocationRetentionInfo.cs
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
    #region CdmSnapshotLocationRetentionInfo
    public class CdmSnapshotLocationRetentionInfo: BaseType
    {
        #region members

        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        [JsonProperty("snapshotFrequency")]
        public SnapshotFrequency? SnapshotFrequency { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        [JsonProperty("isExpirationDateCalculated")]
        public System.Boolean? IsExpirationDateCalculated { get; set; }

        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        [JsonProperty("isExpirationInformationUnavailable")]
        public System.Boolean? IsExpirationInformationUnavailable { get; set; }

        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        [JsonProperty("isSnapshotPresent")]
        public System.Boolean? IsSnapshotPresent { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public CdmSnapshotLocationRetentionInfo Set(
        SnapshotFrequency? SnapshotFrequency = null,
        DateTime? ExpirationTime = null,
        System.Boolean? IsExpirationDateCalculated = null,
        System.Boolean? IsExpirationInformationUnavailable = null,
        System.Boolean? IsSnapshotPresent = null,
        System.String? LocationId = null,
        System.String? Name = null
    ) 
    {
        if ( SnapshotFrequency != null ) {
            this.SnapshotFrequency = SnapshotFrequency;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsExpirationDateCalculated != null ) {
            this.IsExpirationDateCalculated = IsExpirationDateCalculated;
        }
        if ( IsExpirationInformationUnavailable != null ) {
            this.IsExpirationInformationUnavailable = IsExpirationInformationUnavailable;
        }
        if ( IsSnapshotPresent != null ) {
            this.IsSnapshotPresent = IsSnapshotPresent;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        if (this.SnapshotFrequency != null) {
            s += ind + "snapshotFrequency\n" ;
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (this.IsExpirationDateCalculated != null) {
            s += ind + "isExpirationDateCalculated\n" ;
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        if (this.IsExpirationInformationUnavailable != null) {
            s += ind + "isExpirationInformationUnavailable\n" ;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent != null) {
            s += ind + "isSnapshotPresent\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        if (this.SnapshotFrequency == null && Exploration.Includes(parent + ".snapshotFrequency", true))
        {
            this.SnapshotFrequency = new SnapshotFrequency();
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime", true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (this.IsExpirationDateCalculated == null && Exploration.Includes(parent + ".isExpirationDateCalculated", true))
        {
            this.IsExpirationDateCalculated = true;
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
        if (this.IsExpirationInformationUnavailable == null && Exploration.Includes(parent + ".isExpirationInformationUnavailable", true))
        {
            this.IsExpirationInformationUnavailable = true;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent == null && Exploration.Includes(parent + ".isSnapshotPresent", true))
        {
            this.IsSnapshotPresent = true;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
    }


    #endregion

    } // class CdmSnapshotLocationRetentionInfo
    
    #endregion

    public static class ListCdmSnapshotLocationRetentionInfoExtensions
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
            this List<CdmSnapshotLocationRetentionInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotLocationRetentionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotLocationRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types