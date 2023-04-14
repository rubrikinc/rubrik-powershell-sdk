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

namespace Rubrik.SecurityCloud.Types
{
    #region CdmSnapshotLocationRetentionInfo
    public class CdmSnapshotLocationRetentionInfo: IFragment
    {
        #region members
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

        //      C# -> SnapshotFrequency? SnapshotFrequency
        // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
        [JsonProperty("snapshotFrequency")]
        public SnapshotFrequency? SnapshotFrequency { get; set; }

        #endregion

    #region methods

    public CdmSnapshotLocationRetentionInfo Set(
        DateTime? ExpirationTime = null,
        System.Boolean? IsExpirationDateCalculated = null,
        System.Boolean? IsExpirationInformationUnavailable = null,
        System.Boolean? IsSnapshotPresent = null,
        System.String? LocationId = null,
        System.String? Name = null,
        SnapshotFrequency? SnapshotFrequency = null
    ) 
    {
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
        if ( SnapshotFrequency != null ) {
            this.SnapshotFrequency = SnapshotFrequency;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime != null)
            {
                 s += ind + "expirationTime\n";

            }
            //      C# -> System.Boolean? IsExpirationDateCalculated
            // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
            if (this.IsExpirationDateCalculated != null)
            {
                 s += ind + "isExpirationDateCalculated\n";

            }
            //      C# -> System.Boolean? IsExpirationInformationUnavailable
            // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
            if (this.IsExpirationInformationUnavailable != null)
            {
                 s += ind + "isExpirationInformationUnavailable\n";

            }
            //      C# -> System.Boolean? IsSnapshotPresent
            // GraphQL -> isSnapshotPresent: Boolean! (scalar)
            if (this.IsSnapshotPresent != null)
            {
                 s += ind + "isSnapshotPresent\n";

            }
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId != null)
            {
                 s += ind + "locationId\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> SnapshotFrequency? SnapshotFrequency
            // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
            if (this.SnapshotFrequency != null)
            {
                 s += ind + "snapshotFrequency\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime$"))
            {
                this.ExpirationTime = new DateTime();
            }
            //      C# -> System.Boolean? IsExpirationDateCalculated
            // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
            if (this.IsExpirationDateCalculated == null && Exploration.Includes(parent + ".isExpirationDateCalculated$"))
            {
                this.IsExpirationDateCalculated = new System.Boolean();
            }
            //      C# -> System.Boolean? IsExpirationInformationUnavailable
            // GraphQL -> isExpirationInformationUnavailable: Boolean! (scalar)
            if (this.IsExpirationInformationUnavailable == null && Exploration.Includes(parent + ".isExpirationInformationUnavailable$"))
            {
                this.IsExpirationInformationUnavailable = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSnapshotPresent
            // GraphQL -> isSnapshotPresent: Boolean! (scalar)
            if (this.IsSnapshotPresent == null && Exploration.Includes(parent + ".isSnapshotPresent$"))
            {
                this.IsSnapshotPresent = new System.Boolean();
            }
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId == null && Exploration.Includes(parent + ".locationId$"))
            {
                this.LocationId = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> SnapshotFrequency? SnapshotFrequency
            // GraphQL -> snapshotFrequency: SnapshotFrequency! (enum)
            if (this.SnapshotFrequency == null && Exploration.Includes(parent + ".snapshotFrequency$"))
            {
                this.SnapshotFrequency = new SnapshotFrequency();
            }
        }


    #endregion

    } // class CdmSnapshotLocationRetentionInfo
    #endregion

    public static class ListCdmSnapshotLocationRetentionInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CdmSnapshotLocationRetentionInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmSnapshotLocationRetentionInfo> list, 
            String parent = "")
        {
            var item = new CdmSnapshotLocationRetentionInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types