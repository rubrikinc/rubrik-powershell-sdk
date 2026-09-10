// CloudAuditEvent.cs
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
    #region CloudAuditEvent
    public class CloudAuditEvent: BaseType
    {
        #region members

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        [JsonProperty("action")]
        public System.String? Action { get; set; }

        //      C# -> System.String? DeletedBy
        // GraphQL -> deletedBy: String! (scalar)
        [JsonProperty("deletedBy")]
        public System.String? DeletedBy { get; set; }

        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> System.String? SourceIp
        // GraphQL -> sourceIp: String! (scalar)
        [JsonProperty("sourceIp")]
        public System.String? SourceIp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAuditEvent";
    }

    public CloudAuditEvent Set(
        System.String? AccountId = null,
        System.String? AccountName = null,
        System.String? Action = null,
        System.String? DeletedBy = null,
        System.String? EventId = null,
        System.String? SourceIp = null
    ) 
    {
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( DeletedBy != null ) {
            this.DeletedBy = DeletedBy;
        }
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( SourceIp != null ) {
            this.SourceIp = SourceIp;
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
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountId\n" ;
            } else {
                s += ind + "accountId\n" ;
            }
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
            }
        }
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> System.String? DeletedBy
        // GraphQL -> deletedBy: String! (scalar)
        if (this.DeletedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletedBy\n" ;
            } else {
                s += ind + "deletedBy\n" ;
            }
        }
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventId\n" ;
            } else {
                s += ind + "eventId\n" ;
            }
        }
        //      C# -> System.String? SourceIp
        // GraphQL -> sourceIp: String! (scalar)
        if (this.SourceIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIp\n" ;
            } else {
                s += ind + "sourceIp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (ec.Includes("accountId",true))
        {
            if(this.AccountId == null) {

                this.AccountId = "FETCH";

            } else {


            }
        }
        else if (this.AccountId != null && ec.Excludes("accountId",true))
        {
            this.AccountId = null;
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
        }
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = "FETCH";

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> System.String? DeletedBy
        // GraphQL -> deletedBy: String! (scalar)
        if (ec.Includes("deletedBy",true))
        {
            if(this.DeletedBy == null) {

                this.DeletedBy = "FETCH";

            } else {


            }
        }
        else if (this.DeletedBy != null && ec.Excludes("deletedBy",true))
        {
            this.DeletedBy = null;
        }
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (ec.Includes("eventId",true))
        {
            if(this.EventId == null) {

                this.EventId = "FETCH";

            } else {


            }
        }
        else if (this.EventId != null && ec.Excludes("eventId",true))
        {
            this.EventId = null;
        }
        //      C# -> System.String? SourceIp
        // GraphQL -> sourceIp: String! (scalar)
        if (ec.Includes("sourceIp",true))
        {
            if(this.SourceIp == null) {

                this.SourceIp = "FETCH";

            } else {


            }
        }
        else if (this.SourceIp != null && ec.Excludes("sourceIp",true))
        {
            this.SourceIp = null;
        }
    }


    #endregion

    } // class CloudAuditEvent
    
    #endregion

    public static class ListCloudAuditEventExtensions
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
            this List<CloudAuditEvent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAuditEvent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAuditEvent> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAuditEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAuditEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types