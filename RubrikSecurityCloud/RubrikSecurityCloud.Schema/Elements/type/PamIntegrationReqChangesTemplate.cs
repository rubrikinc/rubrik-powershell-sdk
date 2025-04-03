// PamIntegrationReqChangesTemplate.cs
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
    #region PamIntegrationReqChangesTemplate
 
    public class PamIntegrationReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.Boolean? NewEnabled
        // GraphQL -> newEnabled: Boolean! (scalar)
        [JsonProperty("newEnabled")]
        public System.Boolean? NewEnabled { get; set; }

        //      C# -> List<System.String>? NewPamServerIps
        // GraphQL -> newPamServerIps: [String!]! (scalar)
        [JsonProperty("newPamServerIps")]
        public List<System.String>? NewPamServerIps { get; set; }

        //      C# -> System.Boolean? PrevEnabled
        // GraphQL -> prevEnabled: Boolean! (scalar)
        [JsonProperty("prevEnabled")]
        public System.Boolean? PrevEnabled { get; set; }

        //      C# -> List<System.String>? PrevPamServerIps
        // GraphQL -> prevPamServerIps: [String!]! (scalar)
        [JsonProperty("prevPamServerIps")]
        public List<System.String>? PrevPamServerIps { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PamIntegrationReqChangesTemplate";
    }

    public PamIntegrationReqChangesTemplate Set(
        System.Boolean? NewEnabled = null,
        List<System.String>? NewPamServerIps = null,
        System.Boolean? PrevEnabled = null,
        List<System.String>? PrevPamServerIps = null,
        System.String? TemplateName = null
    ) 
    {
        if ( NewEnabled != null ) {
            this.NewEnabled = NewEnabled;
        }
        if ( NewPamServerIps != null ) {
            this.NewPamServerIps = NewPamServerIps;
        }
        if ( PrevEnabled != null ) {
            this.PrevEnabled = PrevEnabled;
        }
        if ( PrevPamServerIps != null ) {
            this.PrevPamServerIps = PrevPamServerIps;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
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
        //      C# -> System.Boolean? NewEnabled
        // GraphQL -> newEnabled: Boolean! (scalar)
        if (this.NewEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newEnabled\n" ;
            } else {
                s += ind + "newEnabled\n" ;
            }
        }
        //      C# -> List<System.String>? NewPamServerIps
        // GraphQL -> newPamServerIps: [String!]! (scalar)
        if (this.NewPamServerIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newPamServerIps\n" ;
            } else {
                s += ind + "newPamServerIps\n" ;
            }
        }
        //      C# -> System.Boolean? PrevEnabled
        // GraphQL -> prevEnabled: Boolean! (scalar)
        if (this.PrevEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "prevEnabled\n" ;
            } else {
                s += ind + "prevEnabled\n" ;
            }
        }
        //      C# -> List<System.String>? PrevPamServerIps
        // GraphQL -> prevPamServerIps: [String!]! (scalar)
        if (this.PrevPamServerIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "prevPamServerIps\n" ;
            } else {
                s += ind + "prevPamServerIps\n" ;
            }
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? NewEnabled
        // GraphQL -> newEnabled: Boolean! (scalar)
        if (ec.Includes("newEnabled",true))
        {
            if(this.NewEnabled == null) {

                this.NewEnabled = true;

            } else {


            }
        }
        else if (this.NewEnabled != null && ec.Excludes("newEnabled",true))
        {
            this.NewEnabled = null;
        }
        //      C# -> List<System.String>? NewPamServerIps
        // GraphQL -> newPamServerIps: [String!]! (scalar)
        if (ec.Includes("newPamServerIps",true))
        {
            if(this.NewPamServerIps == null) {

                this.NewPamServerIps = new List<System.String>();

            } else {


            }
        }
        else if (this.NewPamServerIps != null && ec.Excludes("newPamServerIps",true))
        {
            this.NewPamServerIps = null;
        }
        //      C# -> System.Boolean? PrevEnabled
        // GraphQL -> prevEnabled: Boolean! (scalar)
        if (ec.Includes("prevEnabled",true))
        {
            if(this.PrevEnabled == null) {

                this.PrevEnabled = true;

            } else {


            }
        }
        else if (this.PrevEnabled != null && ec.Excludes("prevEnabled",true))
        {
            this.PrevEnabled = null;
        }
        //      C# -> List<System.String>? PrevPamServerIps
        // GraphQL -> prevPamServerIps: [String!]! (scalar)
        if (ec.Includes("prevPamServerIps",true))
        {
            if(this.PrevPamServerIps == null) {

                this.PrevPamServerIps = new List<System.String>();

            } else {


            }
        }
        else if (this.PrevPamServerIps != null && ec.Excludes("prevPamServerIps",true))
        {
            this.PrevPamServerIps = null;
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
    }


    #endregion

    } // class PamIntegrationReqChangesTemplate
    
    #endregion

    public static class ListPamIntegrationReqChangesTemplateExtensions
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
            this List<PamIntegrationReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PamIntegrationReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PamIntegrationReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PamIntegrationReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PamIntegrationReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types