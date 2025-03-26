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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        if (this.AccessStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessStatus\n" ;
            } else {
                s += ind + "accessStatus\n" ;
            }
        }
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "durationInHours\n" ;
            } else {
                s += ind + "durationInHours\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TicketNumber
        // GraphQL -> ticketNumber: String! (scalar)
        if (this.TicketNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ticketNumber\n" ;
            } else {
                s += ind + "ticketNumber\n" ;
            }
        }
        //      C# -> User? AccessProviderUser
        // GraphQL -> accessProviderUser: User (type)
        if (this.AccessProviderUser != null) {
            var fspec = this.AccessProviderUser.AsFieldSpec(conf.Child("accessProviderUser"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "accessProviderUser" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? ImpersonatedUser
        // GraphQL -> impersonatedUser: User (type)
        if (this.ImpersonatedUser != null) {
            var fspec = this.ImpersonatedUser.AsFieldSpec(conf.Child("impersonatedUser"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "impersonatedUser" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SupportUserAccessStatus? AccessStatus
        // GraphQL -> accessStatus: SupportUserAccessStatus! (enum)
        if (ec.Includes("accessStatus",true))
        {
            if(this.AccessStatus == null) {

                this.AccessStatus = new SupportUserAccessStatus();

            } else {


            }
        }
        else if (this.AccessStatus != null && ec.Excludes("accessStatus",true))
        {
            this.AccessStatus = null;
        }
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (ec.Includes("durationInHours",true))
        {
            if(this.DurationInHours == null) {

                this.DurationInHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.DurationInHours != null && ec.Excludes("durationInHours",true))
        {
            this.DurationInHours = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = Int32.MinValue;

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TicketNumber
        // GraphQL -> ticketNumber: String! (scalar)
        if (ec.Includes("ticketNumber",true))
        {
            if(this.TicketNumber == null) {

                this.TicketNumber = "FETCH";

            } else {


            }
        }
        else if (this.TicketNumber != null && ec.Excludes("ticketNumber",true))
        {
            this.TicketNumber = null;
        }
        //      C# -> User? AccessProviderUser
        // GraphQL -> accessProviderUser: User (type)
        if (ec.Includes("accessProviderUser",false))
        {
            if(this.AccessProviderUser == null) {

                this.AccessProviderUser = new User();
                this.AccessProviderUser.ApplyExploratoryFieldSpec(ec.NewChild("accessProviderUser"));

            } else {

                this.AccessProviderUser.ApplyExploratoryFieldSpec(ec.NewChild("accessProviderUser"));

            }
        }
        else if (this.AccessProviderUser != null && ec.Excludes("accessProviderUser",false))
        {
            this.AccessProviderUser = null;
        }
        //      C# -> User? ImpersonatedUser
        // GraphQL -> impersonatedUser: User (type)
        if (ec.Includes("impersonatedUser",false))
        {
            if(this.ImpersonatedUser == null) {

                this.ImpersonatedUser = new User();
                this.ImpersonatedUser.ApplyExploratoryFieldSpec(ec.NewChild("impersonatedUser"));

            } else {

                this.ImpersonatedUser.ApplyExploratoryFieldSpec(ec.NewChild("impersonatedUser"));

            }
        }
        else if (this.ImpersonatedUser != null && ec.Excludes("impersonatedUser",false))
        {
            this.ImpersonatedUser = null;
        }
    }


    #endregion

    } // class SupportUserAccess
    
    #endregion

    public static class ListSupportUserAccessExtensions
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
            this List<SupportUserAccess> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SupportUserAccess> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportUserAccess> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportUserAccess());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportUserAccess> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types