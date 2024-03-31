// SetUpgradeTypeReply.cs
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
    #region SetUpgradeTypeReply
    public class SetUpgradeTypeReply: BaseType
    {
        #region members

        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        [JsonProperty("excepshuns")]
        public System.String? Excepshuns { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SetUpgradeTypeReply";
    }

    public SetUpgradeTypeReply Set(
        System.String? Code = null,
        System.String? Excepshuns = null,
        System.String? Message = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( Excepshuns != null ) {
            this.Excepshuns = Excepshuns;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        if (this.Excepshuns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excepshuns\n" ;
            } else {
                s += ind + "excepshuns\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = "FETCH";

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        if (ec.Includes("excepshuns",true))
        {
            if(this.Excepshuns == null) {

                this.Excepshuns = "FETCH";

            } else {


            }
        }
        else if (this.Excepshuns != null && ec.Excludes("excepshuns",true))
        {
            this.Excepshuns = null;
        }
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
    }


    #endregion

    } // class SetUpgradeTypeReply
    
    #endregion

    public static class ListSetUpgradeTypeReplyExtensions
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
            this List<SetUpgradeTypeReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SetUpgradeTypeReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SetUpgradeTypeReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SetUpgradeTypeReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SetUpgradeTypeReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types