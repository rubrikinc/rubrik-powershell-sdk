// Ticket.cs
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
    #region Ticket
    public class Ticket: BaseType
    {
        #region members

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        [JsonProperty("creatorEmail")]
        public System.String? CreatorEmail { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> BaseTicket? BaseInfo
        // GraphQL -> baseInfo: BaseTicket! (type)
        [JsonProperty("baseInfo")]
        public BaseTicket? BaseInfo { get; set; }

        //      C# -> TicketStatusWithSyncInfo? StatusWithSyncInfo
        // GraphQL -> statusWithSyncInfo: TicketStatusWithSyncInfo! (type)
        [JsonProperty("statusWithSyncInfo")]
        public TicketStatusWithSyncInfo? StatusWithSyncInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ticket";
    }

    public Ticket Set(
        DateTime? CreatedAt = null,
        System.String? CreatorEmail = null,
        System.String? Name = null,
        BaseTicket? BaseInfo = null,
        TicketStatusWithSyncInfo? StatusWithSyncInfo = null
    ) 
    {
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatorEmail != null ) {
            this.CreatorEmail = CreatorEmail;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( BaseInfo != null ) {
            this.BaseInfo = BaseInfo;
        }
        if ( StatusWithSyncInfo != null ) {
            this.StatusWithSyncInfo = StatusWithSyncInfo;
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
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (this.CreatorEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creatorEmail\n" ;
            } else {
                s += ind + "creatorEmail\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> BaseTicket? BaseInfo
        // GraphQL -> baseInfo: BaseTicket! (type)
        if (this.BaseInfo != null) {
            var fspec = this.BaseInfo.AsFieldSpec(conf.Child("baseInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TicketStatusWithSyncInfo? StatusWithSyncInfo
        // GraphQL -> statusWithSyncInfo: TicketStatusWithSyncInfo! (type)
        if (this.StatusWithSyncInfo != null) {
            var fspec = this.StatusWithSyncInfo.AsFieldSpec(conf.Child("statusWithSyncInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusWithSyncInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? CreatorEmail
        // GraphQL -> creatorEmail: String! (scalar)
        if (ec.Includes("creatorEmail",true))
        {
            if(this.CreatorEmail == null) {

                this.CreatorEmail = "FETCH";

            } else {


            }
        }
        else if (this.CreatorEmail != null && ec.Excludes("creatorEmail",true))
        {
            this.CreatorEmail = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> BaseTicket? BaseInfo
        // GraphQL -> baseInfo: BaseTicket! (type)
        if (ec.Includes("baseInfo",false))
        {
            if(this.BaseInfo == null) {

                this.BaseInfo = new BaseTicket();
                this.BaseInfo.ApplyExploratoryFieldSpec(ec.NewChild("baseInfo"));

            } else {

                this.BaseInfo.ApplyExploratoryFieldSpec(ec.NewChild("baseInfo"));

            }
        }
        else if (this.BaseInfo != null && ec.Excludes("baseInfo",false))
        {
            this.BaseInfo = null;
        }
        //      C# -> TicketStatusWithSyncInfo? StatusWithSyncInfo
        // GraphQL -> statusWithSyncInfo: TicketStatusWithSyncInfo! (type)
        if (ec.Includes("statusWithSyncInfo",false))
        {
            if(this.StatusWithSyncInfo == null) {

                this.StatusWithSyncInfo = new TicketStatusWithSyncInfo();
                this.StatusWithSyncInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusWithSyncInfo"));

            } else {

                this.StatusWithSyncInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusWithSyncInfo"));

            }
        }
        else if (this.StatusWithSyncInfo != null && ec.Excludes("statusWithSyncInfo",false))
        {
            this.StatusWithSyncInfo = null;
        }
    }


    #endregion

    } // class Ticket
    
    #endregion

    public static class ListTicketExtensions
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
            this List<Ticket> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Ticket> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Ticket> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Ticket());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Ticket> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types