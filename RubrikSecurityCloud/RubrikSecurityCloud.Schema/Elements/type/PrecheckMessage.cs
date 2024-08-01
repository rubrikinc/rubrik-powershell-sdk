// PrecheckMessage.cs
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
    #region PrecheckMessage
    public class PrecheckMessage: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        [JsonProperty("urlTextMap")]
        public List<UrlMap>? UrlTextMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrecheckMessage";
    }

    public PrecheckMessage Set(
        System.String? Message = null,
        List<UrlMap>? UrlTextMap = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( UrlTextMap != null ) {
            this.UrlTextMap = UrlTextMap;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        if (this.UrlTextMap != null) {
            var fspec = this.UrlTextMap.AsFieldSpec(conf.Child("urlTextMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "urlTextMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> List<UrlMap>? UrlTextMap
        // GraphQL -> urlTextMap: [UrlMap!] (type)
        if (ec.Includes("urlTextMap",false))
        {
            if(this.UrlTextMap == null) {

                this.UrlTextMap = new List<UrlMap>();
                this.UrlTextMap.ApplyExploratoryFieldSpec(ec.NewChild("urlTextMap"));

            } else {

                this.UrlTextMap.ApplyExploratoryFieldSpec(ec.NewChild("urlTextMap"));

            }
        }
        else if (this.UrlTextMap != null && ec.Excludes("urlTextMap",false))
        {
            this.UrlTextMap = null;
        }
    }


    #endregion

    } // class PrecheckMessage
    
    #endregion

    public static class ListPrecheckMessageExtensions
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
            this List<PrecheckMessage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrecheckMessage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrecheckMessage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrecheckMessage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrecheckMessage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types