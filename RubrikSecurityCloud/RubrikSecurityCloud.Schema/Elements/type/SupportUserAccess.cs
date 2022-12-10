// SupportUserAccess.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
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
    #region SupportUserAccess
    public class SupportUserAccess: IFragment
    {
        #region members
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        [JsonProperty("durationInHours")]
        public System.Int32? DurationInHours { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TicketNumber
        // GraphQL -> ticketNumber: String! (scalar)
        [JsonProperty("ticketNumber")]
        public System.String? TicketNumber { get; set; }

        //      C# -> User? AccessProviderUser
        // GraphQL -> accessProviderUser: User (type)
        [JsonProperty("accessProviderUser")]
        public User? AccessProviderUser { get; set; }

        //      C# -> User? ImpersonatedUser
        // GraphQL -> impersonatedUser: User (type)
        [JsonProperty("impersonatedUser")]
        public User? ImpersonatedUser { get; set; }

        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        [JsonProperty("accessStatus")]
        public SupportUserAccessStatus? AccessStatus { get; set; }

        #endregion

    #region methods

    public SupportUserAccess Set(
        System.Int32? DurationInHours = null,
        DateTime? EndTime = null,
        System.Int32? Id = null,
        DateTime? StartTime = null,
        System.String? TicketNumber = null,
        User? AccessProviderUser = null,
        User? ImpersonatedUser = null,
        SupportUserAccessStatus? AccessStatus = null
    ) 
    {
        if ( DurationInHours != null ) {
            this.DurationInHours = DurationInHours;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TicketNumber != null ) {
            this.TicketNumber = TicketNumber;
        }
        if ( AccessProviderUser != null ) {
            this.AccessProviderUser = AccessProviderUser;
        }
        if ( ImpersonatedUser != null ) {
            this.ImpersonatedUser = ImpersonatedUser;
        }
        if ( AccessStatus != null ) {
            this.AccessStatus = AccessStatus;
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
            //      C# -> System.Int32? DurationInHours
            // GraphQL -> durationInHours: Int! (scalar)
            if (this.DurationInHours != null)
            {
                 s += ind + "durationInHours\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.String? TicketNumber
            // GraphQL -> ticketNumber: String! (scalar)
            if (this.TicketNumber != null)
            {
                 s += ind + "ticketNumber\n";

            }
            //      C# -> User? AccessProviderUser
            // GraphQL -> accessProviderUser: User (type)
            if (this.AccessProviderUser != null)
            {
                 s += ind + "accessProviderUser\n";

                 s += ind + "{\n" + 
                 this.AccessProviderUser.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? ImpersonatedUser
            // GraphQL -> impersonatedUser: User (type)
            if (this.ImpersonatedUser != null)
            {
                 s += ind + "impersonatedUser\n";

                 s += ind + "{\n" + 
                 this.ImpersonatedUser.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SupportUserAccessStatus? AccessStatus
            // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
            if (this.AccessStatus != null)
            {
                 s += ind + "accessStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? DurationInHours
            // GraphQL -> durationInHours: Int! (scalar)
            if (this.DurationInHours == null && Exploration.Includes(parent + ".durationInHours$"))
            {
                this.DurationInHours = new System.Int32();
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int32();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> System.String? TicketNumber
            // GraphQL -> ticketNumber: String! (scalar)
            if (this.TicketNumber == null && Exploration.Includes(parent + ".ticketNumber$"))
            {
                this.TicketNumber = new System.String("FETCH");
            }
            //      C# -> User? AccessProviderUser
            // GraphQL -> accessProviderUser: User (type)
            if (this.AccessProviderUser == null && Exploration.Includes(parent + ".accessProviderUser"))
            {
                this.AccessProviderUser = new User();
                this.AccessProviderUser.ApplyExploratoryFragment(parent + ".accessProviderUser");
            }
            //      C# -> User? ImpersonatedUser
            // GraphQL -> impersonatedUser: User (type)
            if (this.ImpersonatedUser == null && Exploration.Includes(parent + ".impersonatedUser"))
            {
                this.ImpersonatedUser = new User();
                this.ImpersonatedUser.ApplyExploratoryFragment(parent + ".impersonatedUser");
            }
            //      C# -> SupportUserAccessStatus? AccessStatus
            // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
            if (this.AccessStatus == null && Exploration.Includes(parent + ".accessStatus$"))
            {
                this.AccessStatus = new SupportUserAccessStatus();
            }
        }


    #endregion

    } // class SupportUserAccess
    #endregion

    public static class ListSupportUserAccessExtensions
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
            this List<SupportUserAccess> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SupportUserAccess> list, 
            String parent = "")
        {
            var item = new SupportUserAccess();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types