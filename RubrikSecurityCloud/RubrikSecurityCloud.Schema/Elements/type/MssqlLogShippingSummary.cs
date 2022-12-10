// MssqlLogShippingSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    #region MssqlLogShippingSummary
    public class MssqlLogShippingSummary: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? LagTime
        // GraphQL -> lagTime: Long (scalar)
        [JsonProperty("lagTime")]
        public System.Int64? LagTime { get; set; }

        //      C# -> DateTime? LastAppliedPoint
        // GraphQL -> lastAppliedPoint: DateTime (scalar)
        [JsonProperty("lastAppliedPoint")]
        public DateTime? LastAppliedPoint { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? PrimaryDatabaseId
        // GraphQL -> primaryDatabaseId: String! (scalar)
        [JsonProperty("primaryDatabaseId")]
        public System.String? PrimaryDatabaseId { get; set; }

        //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
        // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
        [JsonProperty("primaryDatabaseLogBackupFrequency")]
        public System.Int64? PrimaryDatabaseLogBackupFrequency { get; set; }

        //      C# -> System.String? PrimaryDatabaseName
        // GraphQL -> primaryDatabaseName: String! (scalar)
        [JsonProperty("primaryDatabaseName")]
        public System.String? PrimaryDatabaseName { get; set; }

        //      C# -> System.String? SecondaryDatabaseId
        // GraphQL -> secondaryDatabaseId: String (scalar)
        [JsonProperty("secondaryDatabaseId")]
        public System.String? SecondaryDatabaseId { get; set; }

        //      C# -> System.String? SecondaryDatabaseName
        // GraphQL -> secondaryDatabaseName: String! (scalar)
        [JsonProperty("secondaryDatabaseName")]
        public System.String? SecondaryDatabaseName { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> MssqlLogShippingStatusInfo? Status
        // GraphQL -> status: MssqlLogShippingStatusInfo (type)
        [JsonProperty("status")]
        public MssqlLogShippingStatusInfo? Status { get; set; }

        #endregion

    #region methods

    public MssqlLogShippingSummary Set(
        System.String? Id = null,
        System.Int64? LagTime = null,
        DateTime? LastAppliedPoint = null,
        System.String? Location = null,
        System.String? PrimaryDatabaseId = null,
        System.Int64? PrimaryDatabaseLogBackupFrequency = null,
        System.String? PrimaryDatabaseName = null,
        System.String? SecondaryDatabaseId = null,
        System.String? SecondaryDatabaseName = null,
        System.String? State = null,
        MssqlLogShippingStatusInfo? Status = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LagTime != null ) {
            this.LagTime = LagTime;
        }
        if ( LastAppliedPoint != null ) {
            this.LastAppliedPoint = LastAppliedPoint;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( PrimaryDatabaseId != null ) {
            this.PrimaryDatabaseId = PrimaryDatabaseId;
        }
        if ( PrimaryDatabaseLogBackupFrequency != null ) {
            this.PrimaryDatabaseLogBackupFrequency = PrimaryDatabaseLogBackupFrequency;
        }
        if ( PrimaryDatabaseName != null ) {
            this.PrimaryDatabaseName = PrimaryDatabaseName;
        }
        if ( SecondaryDatabaseId != null ) {
            this.SecondaryDatabaseId = SecondaryDatabaseId;
        }
        if ( SecondaryDatabaseName != null ) {
            this.SecondaryDatabaseName = SecondaryDatabaseName;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? LagTime
            // GraphQL -> lagTime: Long (scalar)
            if (this.LagTime != null)
            {
                 s += ind + "lagTime\n";

            }
            //      C# -> DateTime? LastAppliedPoint
            // GraphQL -> lastAppliedPoint: DateTime (scalar)
            if (this.LastAppliedPoint != null)
            {
                 s += ind + "lastAppliedPoint\n";

            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.String? PrimaryDatabaseId
            // GraphQL -> primaryDatabaseId: String! (scalar)
            if (this.PrimaryDatabaseId != null)
            {
                 s += ind + "primaryDatabaseId\n";

            }
            //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
            // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
            if (this.PrimaryDatabaseLogBackupFrequency != null)
            {
                 s += ind + "primaryDatabaseLogBackupFrequency\n";

            }
            //      C# -> System.String? PrimaryDatabaseName
            // GraphQL -> primaryDatabaseName: String! (scalar)
            if (this.PrimaryDatabaseName != null)
            {
                 s += ind + "primaryDatabaseName\n";

            }
            //      C# -> System.String? SecondaryDatabaseId
            // GraphQL -> secondaryDatabaseId: String (scalar)
            if (this.SecondaryDatabaseId != null)
            {
                 s += ind + "secondaryDatabaseId\n";

            }
            //      C# -> System.String? SecondaryDatabaseName
            // GraphQL -> secondaryDatabaseName: String! (scalar)
            if (this.SecondaryDatabaseName != null)
            {
                 s += ind + "secondaryDatabaseName\n";

            }
            //      C# -> System.String? State
            // GraphQL -> state: String (scalar)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            //      C# -> MssqlLogShippingStatusInfo? Status
            // GraphQL -> status: MssqlLogShippingStatusInfo (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? LagTime
            // GraphQL -> lagTime: Long (scalar)
            if (this.LagTime == null && Exploration.Includes(parent + ".lagTime$"))
            {
                this.LagTime = new System.Int64();
            }
            //      C# -> DateTime? LastAppliedPoint
            // GraphQL -> lastAppliedPoint: DateTime (scalar)
            if (this.LastAppliedPoint == null && Exploration.Includes(parent + ".lastAppliedPoint$"))
            {
                this.LastAppliedPoint = new DateTime();
            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.String? PrimaryDatabaseId
            // GraphQL -> primaryDatabaseId: String! (scalar)
            if (this.PrimaryDatabaseId == null && Exploration.Includes(parent + ".primaryDatabaseId$"))
            {
                this.PrimaryDatabaseId = new System.String("FETCH");
            }
            //      C# -> System.Int64? PrimaryDatabaseLogBackupFrequency
            // GraphQL -> primaryDatabaseLogBackupFrequency: Long (scalar)
            if (this.PrimaryDatabaseLogBackupFrequency == null && Exploration.Includes(parent + ".primaryDatabaseLogBackupFrequency$"))
            {
                this.PrimaryDatabaseLogBackupFrequency = new System.Int64();
            }
            //      C# -> System.String? PrimaryDatabaseName
            // GraphQL -> primaryDatabaseName: String! (scalar)
            if (this.PrimaryDatabaseName == null && Exploration.Includes(parent + ".primaryDatabaseName$"))
            {
                this.PrimaryDatabaseName = new System.String("FETCH");
            }
            //      C# -> System.String? SecondaryDatabaseId
            // GraphQL -> secondaryDatabaseId: String (scalar)
            if (this.SecondaryDatabaseId == null && Exploration.Includes(parent + ".secondaryDatabaseId$"))
            {
                this.SecondaryDatabaseId = new System.String("FETCH");
            }
            //      C# -> System.String? SecondaryDatabaseName
            // GraphQL -> secondaryDatabaseName: String! (scalar)
            if (this.SecondaryDatabaseName == null && Exploration.Includes(parent + ".secondaryDatabaseName$"))
            {
                this.SecondaryDatabaseName = new System.String("FETCH");
            }
            //      C# -> System.String? State
            // GraphQL -> state: String (scalar)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new System.String("FETCH");
            }
            //      C# -> MssqlLogShippingStatusInfo? Status
            // GraphQL -> status: MssqlLogShippingStatusInfo (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new MssqlLogShippingStatusInfo();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
        }


    #endregion

    } // class MssqlLogShippingSummary
    #endregion

    public static class ListMssqlLogShippingSummaryExtensions
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
            this List<MssqlLogShippingSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlLogShippingSummary> list, 
            String parent = "")
        {
            var item = new MssqlLogShippingSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types