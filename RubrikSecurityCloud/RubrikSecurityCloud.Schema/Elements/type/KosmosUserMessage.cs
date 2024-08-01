// KosmosUserMessage.cs
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
    #region KosmosUserMessage
    public class KosmosUserMessage: BaseType
    {
        #region members

        //      C# -> UserMessageSeverity? Severity
        // GraphQL -> severity: UserMessageSeverity! (enum)
        [JsonProperty("severity")]
        public UserMessageSeverity? Severity { get; set; }

        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        [JsonProperty("cause")]
        public System.String? Cause { get; set; }

        //      C# -> System.String? MessageCode
        // GraphQL -> messageCode: String! (scalar)
        [JsonProperty("messageCode")]
        public System.String? MessageCode { get; set; }

        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        [JsonProperty("remedy")]
        public System.String? Remedy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KosmosUserMessage";
    }

    public KosmosUserMessage Set(
        UserMessageSeverity? Severity = null,
        System.String? Cause = null,
        System.String? MessageCode = null,
        System.String? Remedy = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( MessageCode != null ) {
            this.MessageCode = MessageCode;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
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
        //      C# -> UserMessageSeverity? Severity
        // GraphQL -> severity: UserMessageSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (this.Cause != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cause\n" ;
            } else {
                s += ind + "cause\n" ;
            }
        }
        //      C# -> System.String? MessageCode
        // GraphQL -> messageCode: String! (scalar)
        if (this.MessageCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "messageCode\n" ;
            } else {
                s += ind + "messageCode\n" ;
            }
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (this.Remedy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remedy\n" ;
            } else {
                s += ind + "remedy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserMessageSeverity? Severity
        // GraphQL -> severity: UserMessageSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new UserMessageSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        if (ec.Includes("cause",true))
        {
            if(this.Cause == null) {

                this.Cause = "FETCH";

            } else {


            }
        }
        else if (this.Cause != null && ec.Excludes("cause",true))
        {
            this.Cause = null;
        }
        //      C# -> System.String? MessageCode
        // GraphQL -> messageCode: String! (scalar)
        if (ec.Includes("messageCode",true))
        {
            if(this.MessageCode == null) {

                this.MessageCode = "FETCH";

            } else {


            }
        }
        else if (this.MessageCode != null && ec.Excludes("messageCode",true))
        {
            this.MessageCode = null;
        }
        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        if (ec.Includes("remedy",true))
        {
            if(this.Remedy == null) {

                this.Remedy = "FETCH";

            } else {


            }
        }
        else if (this.Remedy != null && ec.Excludes("remedy",true))
        {
            this.Remedy = null;
        }
    }


    #endregion

    } // class KosmosUserMessage
    
    #endregion

    public static class ListKosmosUserMessageExtensions
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
            this List<KosmosUserMessage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KosmosUserMessage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KosmosUserMessage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KosmosUserMessage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KosmosUserMessage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types