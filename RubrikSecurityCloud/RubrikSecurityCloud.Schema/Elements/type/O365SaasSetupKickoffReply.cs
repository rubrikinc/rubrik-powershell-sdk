// O365SaasSetupKickoffReply.cs
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
    #region O365SaasSetupKickoffReply
    public class O365SaasSetupKickoffReply: BaseType
    {
        #region members

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
        return "O365SaasSetupKickoffReply";
    }

    public O365SaasSetupKickoffReply Set(
        System.String? CsrfToken = null,
        List<AppIdForType>? AppClientIdsPerType = null
    ) 
    {
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
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
                    s += ind + "appClientIdsPerType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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

    } // class O365SaasSetupKickoffReply
    
    #endregion

    public static class ListO365SaasSetupKickoffReplyExtensions
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
            this List<O365SaasSetupKickoffReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365SaasSetupKickoffReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365SaasSetupKickoffReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SaasSetupKickoffReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365SaasSetupKickoffReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types