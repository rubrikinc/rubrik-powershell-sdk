// SnapshotLocationRetentionInfo.cs
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
    #region SnapshotLocationRetentionInfo
    public class SnapshotLocationRetentionInfo: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean (scalar)
        [JsonProperty("isExpirationDateCalculated")]
        public System.Boolean? IsExpirationDateCalculated { get; set; }

        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean (scalar)
        [JsonProperty("isExpirationInformationUnavailable")]
        public System.Boolean? IsExpirationInformationUnavailable { get; set; }

        //      C# -> System.Boolean? IsRetainedForSecurity
        // GraphQL -> isRetainedForSecurity: Boolean (scalar)
        [JsonProperty("isRetainedForSecurity")]
        public System.Boolean? IsRetainedForSecurity { get; set; }

        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean (scalar)
        [JsonProperty("isSnapshotOnLegalHold")]
        public System.Boolean? IsSnapshotOnLegalHold { get; set; }

        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        [JsonProperty("isSnapshotPresent")]
        public System.Boolean? IsSnapshotPresent { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SnapshotFrequency
        // GraphQL -> snapshotFrequency: String (scalar)
        [JsonProperty("snapshotFrequency")]
        public System.String? SnapshotFrequency { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotLocationRetentionInfo";
    }

    public SnapshotLocationRetentionInfo Set(
        DateTime? ExpirationTime = null,
        System.String? Id = null,
        System.Boolean? IsExpirationDateCalculated = null,
        System.Boolean? IsExpirationInformationUnavailable = null,
        System.Boolean? IsRetainedForSecurity = null,
        System.Boolean? IsSnapshotOnLegalHold = null,
        System.Boolean? IsSnapshotPresent = null,
        System.String? Name = null,
        System.String? SnapshotFrequency = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsExpirationDateCalculated != null ) {
            this.IsExpirationDateCalculated = IsExpirationDateCalculated;
        }
        if ( IsExpirationInformationUnavailable != null ) {
            this.IsExpirationInformationUnavailable = IsExpirationInformationUnavailable;
        }
        if ( IsRetainedForSecurity != null ) {
            this.IsRetainedForSecurity = IsRetainedForSecurity;
        }
        if ( IsSnapshotOnLegalHold != null ) {
            this.IsSnapshotOnLegalHold = IsSnapshotOnLegalHold;
        }
        if ( IsSnapshotPresent != null ) {
            this.IsSnapshotPresent = IsSnapshotPresent;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SnapshotFrequency != null ) {
            this.SnapshotFrequency = SnapshotFrequency;
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
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean (scalar)
        if (this.IsExpirationDateCalculated != null) {
            s += ind + "isExpirationDateCalculated\n" ;
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean (scalar)
        if (this.IsExpirationInformationUnavailable != null) {
            s += ind + "isExpirationInformationUnavailable\n" ;
        }
        //      C# -> System.Boolean? IsRetainedForSecurity
        // GraphQL -> isRetainedForSecurity: Boolean (scalar)
        if (this.IsRetainedForSecurity != null) {
            s += ind + "isRetainedForSecurity\n" ;
        }
        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean (scalar)
        if (this.IsSnapshotOnLegalHold != null) {
            s += ind + "isSnapshotOnLegalHold\n" ;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent != null) {
            s += ind + "isSnapshotPresent\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SnapshotFrequency
        // GraphQL -> snapshotFrequency: String (scalar)
        if (this.SnapshotFrequency != null) {
            s += ind + "snapshotFrequency\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime", true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean (scalar)
        if (this.IsExpirationDateCalculated == null && Exploration.Includes(parent + ".isExpirationDateCalculated", true))
        {
            this.IsExpirationDateCalculated = true;
        }
        //      C# -> System.Boolean? IsExpirationInformationUnavailable
        // GraphQL -> isExpirationInformationUnavailable: Boolean (scalar)
        if (this.IsExpirationInformationUnavailable == null && Exploration.Includes(parent + ".isExpirationInformationUnavailable", true))
        {
            this.IsExpirationInformationUnavailable = true;
        }
        //      C# -> System.Boolean? IsRetainedForSecurity
        // GraphQL -> isRetainedForSecurity: Boolean (scalar)
        if (this.IsRetainedForSecurity == null && Exploration.Includes(parent + ".isRetainedForSecurity", true))
        {
            this.IsRetainedForSecurity = true;
        }
        //      C# -> System.Boolean? IsSnapshotOnLegalHold
        // GraphQL -> isSnapshotOnLegalHold: Boolean (scalar)
        if (this.IsSnapshotOnLegalHold == null && Exploration.Includes(parent + ".isSnapshotOnLegalHold", true))
        {
            this.IsSnapshotOnLegalHold = true;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent == null && Exploration.Includes(parent + ".isSnapshotPresent", true))
        {
            this.IsSnapshotPresent = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SnapshotFrequency
        // GraphQL -> snapshotFrequency: String (scalar)
        if (this.SnapshotFrequency == null && Exploration.Includes(parent + ".snapshotFrequency", true))
        {
            this.SnapshotFrequency = "FETCH";
        }
    }


    #endregion

    } // class SnapshotLocationRetentionInfo
    
    #endregion

    public static class ListSnapshotLocationRetentionInfoExtensions
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
            this List<SnapshotLocationRetentionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotLocationRetentionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotLocationRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types