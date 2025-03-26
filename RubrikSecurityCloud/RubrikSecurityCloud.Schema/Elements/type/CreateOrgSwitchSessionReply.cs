// CreateOrgSwitchSessionReply.cs
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
    #region CreateOrgSwitchSessionReply
    public class CreateOrgSwitchSessionReply: BaseType
    {
        #region members

        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        [JsonProperty("accessToken")]
        public System.String? AccessToken { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateOrgSwitchSessionReply";
    }

    public CreateOrgSwitchSessionReply Set(
        System.String? AccessToken = null
    ) 
    {
        if ( AccessToken != null ) {
            this.AccessToken = AccessToken;
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
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (this.AccessToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessToken\n" ;
            } else {
                s += ind + "accessToken\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AccessToken
        // GraphQL -> accessToken: String! (scalar)
        if (ec.Includes("accessToken",true))
        {
            if(this.AccessToken == null) {

                this.AccessToken = "FETCH";

            } else {


            }
        }
        else if (this.AccessToken != null && ec.Excludes("accessToken",true))
        {
            this.AccessToken = null;
        }
    }


    #endregion

    } // class CreateOrgSwitchSessionReply
    
    #endregion

    public static class ListCreateOrgSwitchSessionReplyExtensions
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
            this List<CreateOrgSwitchSessionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateOrgSwitchSessionReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateOrgSwitchSessionReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateOrgSwitchSessionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateOrgSwitchSessionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types