// O365SetupKickoffResp.cs
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
    #region O365SetupKickoffResp
    public class O365SetupKickoffResp: BaseType
    {
        #region members

        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        [JsonProperty("appClientId")]
        public System.String? AppClientId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        [JsonProperty("appClientIdsPerType")]
        public List<AppIdForType>? AppClientIdsPerType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365SetupKickoffResp";
    }

    public O365SetupKickoffResp Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        List<AppIdForType>? AppClientIdsPerType = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( AppClientIdsPerType != null ) {
            this.AppClientIdsPerType = AppClientIdsPerType;
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
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (this.AppClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appClientId\n" ;
            } else {
                s += ind + "appClientId\n" ;
            }
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csrfToken\n" ;
            } else {
                s += ind + "csrfToken\n" ;
            }
        }
        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        if (this.AppClientIdsPerType != null) {
            var fspec = this.AppClientIdsPerType.AsFieldSpec(conf.Child("appClientIdsPerType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "appClientIdsPerType {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (ec.Includes("appClientId",true))
        {
            if(this.AppClientId == null) {

                this.AppClientId = "FETCH";

            } else {


            }
        }
        else if (this.AppClientId != null && ec.Excludes("appClientId",true))
        {
            this.AppClientId = null;
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (ec.Includes("csrfToken",true))
        {
            if(this.CsrfToken == null) {

                this.CsrfToken = "FETCH";

            } else {


            }
        }
        else if (this.CsrfToken != null && ec.Excludes("csrfToken",true))
        {
            this.CsrfToken = null;
        }
        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        if (ec.Includes("appClientIdsPerType",false))
        {
            if(this.AppClientIdsPerType == null) {

                this.AppClientIdsPerType = new List<AppIdForType>();
                this.AppClientIdsPerType.ApplyExploratoryFieldSpec(ec.NewChild("appClientIdsPerType"));

            } else {

                this.AppClientIdsPerType.ApplyExploratoryFieldSpec(ec.NewChild("appClientIdsPerType"));

            }
        }
        else if (this.AppClientIdsPerType != null && ec.Excludes("appClientIdsPerType",false))
        {
            this.AppClientIdsPerType = null;
        }
    }


    #endregion

    } // class O365SetupKickoffResp
    
    #endregion

    public static class ListO365SetupKickoffRespExtensions
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
            this List<O365SetupKickoffResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<O365SetupKickoffResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365SetupKickoffResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SetupKickoffResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365SetupKickoffResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types