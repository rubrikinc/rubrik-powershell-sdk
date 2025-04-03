// GetSelfServiceInfoForUserResp.cs
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
    #region GetSelfServiceInfoForUserResp
    public class GetSelfServiceInfoForUserResp: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> MailboxForSelfService? Mailbox
        // GraphQL -> mailbox: MailboxForSelfService (type)
        [JsonProperty("mailbox")]
        public MailboxForSelfService? Mailbox { get; set; }

        //      C# -> OnedriveForSelfService? Onedrive
        // GraphQL -> onedrive: OnedriveForSelfService (type)
        [JsonProperty("onedrive")]
        public OnedriveForSelfService? Onedrive { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSelfServiceInfoForUserResp";
    }

    public GetSelfServiceInfoForUserResp Set(
        System.String? Name = null,
        System.String? OrgId = null,
        MailboxForSelfService? Mailbox = null,
        OnedriveForSelfService? Onedrive = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( Mailbox != null ) {
            this.Mailbox = Mailbox;
        }
        if ( Onedrive != null ) {
            this.Onedrive = Onedrive;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> MailboxForSelfService? Mailbox
        // GraphQL -> mailbox: MailboxForSelfService (type)
        if (this.Mailbox != null) {
            var fspec = this.Mailbox.AsFieldSpec(conf.Child("mailbox"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mailbox" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OnedriveForSelfService? Onedrive
        // GraphQL -> onedrive: OnedriveForSelfService (type)
        if (this.Onedrive != null) {
            var fspec = this.Onedrive.AsFieldSpec(conf.Child("onedrive"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onedrive" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> MailboxForSelfService? Mailbox
        // GraphQL -> mailbox: MailboxForSelfService (type)
        if (ec.Includes("mailbox",false))
        {
            if(this.Mailbox == null) {

                this.Mailbox = new MailboxForSelfService();
                this.Mailbox.ApplyExploratoryFieldSpec(ec.NewChild("mailbox"));

            } else {

                this.Mailbox.ApplyExploratoryFieldSpec(ec.NewChild("mailbox"));

            }
        }
        else if (this.Mailbox != null && ec.Excludes("mailbox",false))
        {
            this.Mailbox = null;
        }
        //      C# -> OnedriveForSelfService? Onedrive
        // GraphQL -> onedrive: OnedriveForSelfService (type)
        if (ec.Includes("onedrive",false))
        {
            if(this.Onedrive == null) {

                this.Onedrive = new OnedriveForSelfService();
                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            } else {

                this.Onedrive.ApplyExploratoryFieldSpec(ec.NewChild("onedrive"));

            }
        }
        else if (this.Onedrive != null && ec.Excludes("onedrive",false))
        {
            this.Onedrive = null;
        }
    }


    #endregion

    } // class GetSelfServiceInfoForUserResp
    
    #endregion

    public static class ListGetSelfServiceInfoForUserRespExtensions
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
            this List<GetSelfServiceInfoForUserResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSelfServiceInfoForUserResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSelfServiceInfoForUserResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSelfServiceInfoForUserResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSelfServiceInfoForUserResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types