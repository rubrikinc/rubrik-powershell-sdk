// GcpOauthUserInfo.cs
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
    #region GcpOauthUserInfo
    public class GcpOauthUserInfo: BaseType
    {
        #region members

        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        [JsonProperty("emailId")]
        public System.String? EmailId { get; set; }

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpOauthUserInfo";
    }

    public GcpOauthUserInfo Set(
        System.String? Domain = null,
        System.String? EmailId = null,
        System.String? FirstName = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( EmailId != null ) {
            this.EmailId = EmailId;
        }
        if ( FirstName != null ) {
            this.FirstName = FirstName;
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
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (this.Domain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domain\n" ;
            } else {
                s += ind + "domain\n" ;
            }
        }
        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        if (this.EmailId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "emailId\n" ;
            } else {
                s += ind + "emailId\n" ;
            }
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        if (this.FirstName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstName\n" ;
            } else {
                s += ind + "firstName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        if (ec.Includes("domain",true))
        {
            if(this.Domain == null) {

                this.Domain = "FETCH";

            } else {


            }
        }
        else if (this.Domain != null && ec.Excludes("domain",true))
        {
            this.Domain = null;
        }
        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        if (ec.Includes("emailId",true))
        {
            if(this.EmailId == null) {

                this.EmailId = "FETCH";

            } else {


            }
        }
        else if (this.EmailId != null && ec.Excludes("emailId",true))
        {
            this.EmailId = null;
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        if (ec.Includes("firstName",true))
        {
            if(this.FirstName == null) {

                this.FirstName = "FETCH";

            } else {


            }
        }
        else if (this.FirstName != null && ec.Excludes("firstName",true))
        {
            this.FirstName = null;
        }
    }


    #endregion

    } // class GcpOauthUserInfo
    
    #endregion

    public static class ListGcpOauthUserInfoExtensions
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
            this List<GcpOauthUserInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpOauthUserInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpOauthUserInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpOauthUserInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpOauthUserInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types