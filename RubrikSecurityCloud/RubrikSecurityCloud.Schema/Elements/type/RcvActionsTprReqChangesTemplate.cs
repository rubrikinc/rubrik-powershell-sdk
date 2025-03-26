// RcvActionsTprReqChangesTemplate.cs
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
    #region RcvActionsTprReqChangesTemplate
 
    public class RcvActionsTprReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        [JsonProperty("requestedAction")]
        public System.String? RequestedAction { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> System.String? VaultName
        // GraphQL -> vaultName: String! (scalar)
        [JsonProperty("vaultName")]
        public System.String? VaultName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvActionsTprReqChangesTemplate";
    }

    public RcvActionsTprReqChangesTemplate Set(
        System.String? RequestedAction = null,
        System.String? TemplateName = null,
        System.String? VaultName = null
    ) 
    {
        if ( RequestedAction != null ) {
            this.RequestedAction = RequestedAction;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( VaultName != null ) {
            this.VaultName = VaultName;
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
        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        if (this.RequestedAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedAction\n" ;
            } else {
                s += ind + "requestedAction\n" ;
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
        //      C# -> System.String? VaultName
        // GraphQL -> vaultName: String! (scalar)
        if (this.VaultName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vaultName\n" ;
            } else {
                s += ind + "vaultName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? RequestedAction
        // GraphQL -> requestedAction: String! (scalar)
        if (ec.Includes("requestedAction",true))
        {
            if(this.RequestedAction == null) {

                this.RequestedAction = "FETCH";

            } else {


            }
        }
        else if (this.RequestedAction != null && ec.Excludes("requestedAction",true))
        {
            this.RequestedAction = null;
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
        //      C# -> System.String? VaultName
        // GraphQL -> vaultName: String! (scalar)
        if (ec.Includes("vaultName",true))
        {
            if(this.VaultName == null) {

                this.VaultName = "FETCH";

            } else {


            }
        }
        else if (this.VaultName != null && ec.Excludes("vaultName",true))
        {
            this.VaultName = null;
        }
    }


    #endregion

    } // class RcvActionsTprReqChangesTemplate
    
    #endregion

    public static class ListRcvActionsTprReqChangesTemplateExtensions
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
            this List<RcvActionsTprReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvActionsTprReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvActionsTprReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvActionsTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvActionsTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types