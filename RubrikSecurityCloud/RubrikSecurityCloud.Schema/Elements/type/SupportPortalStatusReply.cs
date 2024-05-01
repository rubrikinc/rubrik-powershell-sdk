// SupportPortalStatusReply.cs
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
    #region SupportPortalStatusReply
    public class SupportPortalStatusReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        [JsonProperty("isLoggedIn")]
        public System.Boolean? IsLoggedIn { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        [JsonProperty("status")]
        public StatusResponse? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportPortalStatusReply";
    }

    public SupportPortalStatusReply Set(
        System.Boolean? IsLoggedIn = null,
        System.String? Username = null,
        StatusResponse? Status = null
    ) 
    {
        if ( IsLoggedIn != null ) {
            this.IsLoggedIn = IsLoggedIn;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        if (this.IsLoggedIn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLoggedIn\n" ;
            } else {
                s += ind + "isLoggedIn\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        if (ec.Includes("isLoggedIn",true))
        {
            if(this.IsLoggedIn == null) {

                this.IsLoggedIn = true;

            } else {


            }
        }
        else if (this.IsLoggedIn != null && ec.Excludes("isLoggedIn",true))
        {
            this.IsLoggedIn = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new StatusResponse();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class SupportPortalStatusReply
    
    #endregion

    public static class ListSupportPortalStatusReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SupportPortalStatusReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SupportPortalStatusReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportPortalStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportPortalStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportPortalStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types