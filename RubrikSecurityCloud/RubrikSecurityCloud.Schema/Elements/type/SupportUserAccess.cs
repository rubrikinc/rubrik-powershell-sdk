// SupportUserAccess.cs
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
    #region SupportUserAccess
    public class SupportUserAccess: BaseType
    {
        #region members

        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        [JsonProperty("accessStatus")]
        public SupportUserAccessStatus? AccessStatus { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportUserAccess";
    }

    public SupportUserAccess Set(
        SupportUserAccessStatus? AccessStatus = null,
        System.Int32? DurationInHours = null,
        DateTime? EndTime = null,
        System.Int32? Id = null,
        DateTime? StartTime = null,
        System.String? TicketNumber = null,
        User? AccessProviderUser = null,
        User? ImpersonatedUser = null
    ) 
    {
        if ( AccessStatus != null ) {
            this.AccessStatus = AccessStatus;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        if (this.AccessStatus != null) {
            s += ind + "accessStatus\n" ;
        }
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours != null) {
            s += ind + "durationInHours\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? TicketNumber
        // GraphQL -> ticketNumber: String! (scalar)
        if (this.TicketNumber != null) {
            s += ind + "ticketNumber\n" ;
        }
        //      C# -> User? AccessProviderUser
        // GraphQL -> accessProviderUser: User (type)
        if (this.AccessProviderUser != null) {
            var fspec = this.AccessProviderUser.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "accessProviderUser {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> User? ImpersonatedUser
        // GraphQL -> impersonatedUser: User (type)
        if (this.ImpersonatedUser != null) {
            var fspec = this.ImpersonatedUser.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "impersonatedUser {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        if (this.AccessStatus == null && Exploration.Includes(parent + ".accessStatus", true))
        {
            this.AccessStatus = new SupportUserAccessStatus();
        }
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours == null && Exploration.Includes(parent + ".durationInHours", true))
        {
            this.DurationInHours = Int32.MinValue;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = Int32.MinValue;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> System.String? TicketNumber
        // GraphQL -> ticketNumber: String! (scalar)
        if (this.TicketNumber == null && Exploration.Includes(parent + ".ticketNumber", true))
        {
            this.TicketNumber = "FETCH";
        }
        //      C# -> User? AccessProviderUser
        // GraphQL -> accessProviderUser: User (type)
        if (this.AccessProviderUser == null && Exploration.Includes(parent + ".accessProviderUser"))
        {
            this.AccessProviderUser = new User();
            this.AccessProviderUser.ApplyExploratoryFieldSpec(parent + ".accessProviderUser");
        }
        //      C# -> User? ImpersonatedUser
        // GraphQL -> impersonatedUser: User (type)
        if (this.ImpersonatedUser == null && Exploration.Includes(parent + ".impersonatedUser"))
        {
            this.ImpersonatedUser = new User();
            this.ImpersonatedUser.ApplyExploratoryFieldSpec(parent + ".impersonatedUser");
        }
    }


    #endregion

    } // class SupportUserAccess
    
    #endregion

    public static class ListSupportUserAccessExtensions
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
            this List<SupportUserAccess> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SupportUserAccess> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportUserAccess());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types