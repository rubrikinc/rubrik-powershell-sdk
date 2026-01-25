// StartAzureAdAppUpdateReply.cs
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
    #region StartAzureAdAppUpdateReply
    public class StartAzureAdAppUpdateReply: BaseType
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> List<System.String>? ExcessivePermissions
        // GraphQL -> excessivePermissions: [String!]! (scalar)
        [JsonProperty("excessivePermissions")]
        public List<System.String>? ExcessivePermissions { get; set; }

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartAzureAdAppUpdateReply";
    }

    public StartAzureAdAppUpdateReply Set(
        System.String? AppId = null,
        System.String? CsrfToken = null,
        List<System.String>? ExcessivePermissions = null,
        List<System.String>? MissingPermissions = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( ExcessivePermissions != null ) {
            this.ExcessivePermissions = ExcessivePermissions;
        }
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
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
        //      C# -> List<System.String>? ExcessivePermissions
        // GraphQL -> excessivePermissions: [String!]! (scalar)
        if (this.ExcessivePermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excessivePermissions\n" ;
            } else {
                s += ind + "excessivePermissions\n" ;
            }
        }
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPermissions\n" ;
            } else {
                s += ind + "missingPermissions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
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
        //      C# -> List<System.String>? ExcessivePermissions
        // GraphQL -> excessivePermissions: [String!]! (scalar)
        if (ec.Includes("excessivePermissions",true))
        {
            if(this.ExcessivePermissions == null) {

                this.ExcessivePermissions = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcessivePermissions != null && ec.Excludes("excessivePermissions",true))
        {
            this.ExcessivePermissions = null;
        }
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (ec.Includes("missingPermissions",true))
        {
            if(this.MissingPermissions == null) {

                this.MissingPermissions = new List<System.String>();

            } else {


            }
        }
        else if (this.MissingPermissions != null && ec.Excludes("missingPermissions",true))
        {
            this.MissingPermissions = null;
        }
    }


    #endregion

    } // class StartAzureAdAppUpdateReply
    
    #endregion

    public static class ListStartAzureAdAppUpdateReplyExtensions
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
            this List<StartAzureAdAppUpdateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartAzureAdAppUpdateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartAzureAdAppUpdateReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartAzureAdAppUpdateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartAzureAdAppUpdateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types