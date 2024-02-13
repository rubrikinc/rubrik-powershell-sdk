// CreateCrossAccountRegOauthPayloadReply.cs
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
    #region CreateCrossAccountRegOauthPayloadReply
    public class CreateCrossAccountRegOauthPayloadReply: BaseType
    {
        #region members

        //      C# -> OauthRequestPayload? OauthPayload
        // GraphQL -> oauthPayload: OauthRequestPayload (type)
        [JsonProperty("oauthPayload")]
        public OauthRequestPayload? OauthPayload { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateCrossAccountRegOauthPayloadReply";
    }

    public CreateCrossAccountRegOauthPayloadReply Set(
        OauthRequestPayload? OauthPayload = null
    ) 
    {
        if ( OauthPayload != null ) {
            this.OauthPayload = OauthPayload;
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
        //      C# -> OauthRequestPayload? OauthPayload
        // GraphQL -> oauthPayload: OauthRequestPayload (type)
        if (this.OauthPayload != null) {
            var fspec = this.OauthPayload.AsFieldSpec(conf.Child("oauthPayload"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oauthPayload {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> OauthRequestPayload? OauthPayload
        // GraphQL -> oauthPayload: OauthRequestPayload (type)
        if (ec.Includes("oauthPayload",false))
        {
            if(this.OauthPayload == null) {

                this.OauthPayload = new OauthRequestPayload();
                this.OauthPayload.ApplyExploratoryFieldSpec(ec.NewChild("oauthPayload"));

            } else {

                this.OauthPayload.ApplyExploratoryFieldSpec(ec.NewChild("oauthPayload"));

            }
        }
        else if (this.OauthPayload != null && ec.Excludes("oauthPayload",false))
        {
            this.OauthPayload = null;
        }
    }


    #endregion

    } // class CreateCrossAccountRegOauthPayloadReply
    
    #endregion

    public static class ListCreateCrossAccountRegOauthPayloadReplyExtensions
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
            this List<CreateCrossAccountRegOauthPayloadReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateCrossAccountRegOauthPayloadReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateCrossAccountRegOauthPayloadReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateCrossAccountRegOauthPayloadReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateCrossAccountRegOauthPayloadReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types