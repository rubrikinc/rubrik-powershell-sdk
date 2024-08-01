// StartSaasAppAuthConsentReply.cs
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
    #region StartSaasAppAuthConsentReply
    public class StartSaasAppAuthConsentReply: BaseType
    {
        #region members

        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        [JsonProperty("authorizationUrl")]
        public System.String? AuthorizationUrl { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartSaasAppAuthConsentReply";
    }

    public StartSaasAppAuthConsentReply Set(
        System.String? AuthorizationUrl = null,
        System.String? SessionId = null
    ) 
    {
        if ( AuthorizationUrl != null ) {
            this.AuthorizationUrl = AuthorizationUrl;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
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
        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        if (this.AuthorizationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizationUrl\n" ;
            } else {
                s += ind + "authorizationUrl\n" ;
            }
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionId\n" ;
            } else {
                s += ind + "sessionId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AuthorizationUrl
        // GraphQL -> authorizationUrl: URL! (scalar)
        if (ec.Includes("authorizationUrl",true))
        {
            if(this.AuthorizationUrl == null) {

                this.AuthorizationUrl = "FETCH";

            } else {


            }
        }
        else if (this.AuthorizationUrl != null && ec.Excludes("authorizationUrl",true))
        {
            this.AuthorizationUrl = null;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (ec.Includes("sessionId",true))
        {
            if(this.SessionId == null) {

                this.SessionId = "FETCH";

            } else {


            }
        }
        else if (this.SessionId != null && ec.Excludes("sessionId",true))
        {
            this.SessionId = null;
        }
    }


    #endregion

    } // class StartSaasAppAuthConsentReply
    
    #endregion

    public static class ListStartSaasAppAuthConsentReplyExtensions
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
            this List<StartSaasAppAuthConsentReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartSaasAppAuthConsentReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartSaasAppAuthConsentReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartSaasAppAuthConsentReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartSaasAppAuthConsentReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types