// WebhookMessageTemplate.cs
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
    #region WebhookMessageTemplate
    public class WebhookMessageTemplate: BaseType
    {
        #region members

        //      C# -> TemplateDocFormat? DocFormat
        // GraphQL -> docFormat: TemplateDocFormat! (enum)
        [JsonProperty("docFormat")]
        public TemplateDocFormat? DocFormat { get; set; }

        //      C# -> TemplateMessageType? MsgType
        // GraphQL -> msgType: TemplateMessageType! (enum)
        [JsonProperty("msgType")]
        public TemplateMessageType? MsgType { get; set; }

        //      C# -> TemplateRecordType? RecordType
        // GraphQL -> recordType: TemplateRecordType! (enum)
        [JsonProperty("recordType")]
        public TemplateRecordType? RecordType { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String (scalar)
        [JsonProperty("createdBy")]
        public System.String? CreatedBy { get; set; }

        //      C# -> System.String? DocUrl
        // GraphQL -> docUrl: String (scalar)
        [JsonProperty("docUrl")]
        public System.String? DocUrl { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TemplateData
        // GraphQL -> templateData: String! (scalar)
        [JsonProperty("templateData")]
        public System.String? TemplateData { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String (scalar)
        [JsonProperty("updatedBy")]
        public System.String? UpdatedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WebhookMessageTemplate";
    }

    public WebhookMessageTemplate Set(
        TemplateDocFormat? DocFormat = null,
        TemplateMessageType? MsgType = null,
        TemplateRecordType? RecordType = null,
        DateTime? CreatedAt = null,
        System.String? CreatedBy = null,
        System.String? DocUrl = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.String? TemplateData = null,
        DateTime? UpdatedAt = null,
        System.String? UpdatedBy = null
    ) 
    {
        if ( DocFormat != null ) {
            this.DocFormat = DocFormat;
        }
        if ( MsgType != null ) {
            this.MsgType = MsgType;
        }
        if ( RecordType != null ) {
            this.RecordType = RecordType;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( DocUrl != null ) {
            this.DocUrl = DocUrl;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TemplateData != null ) {
            this.TemplateData = TemplateData;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( UpdatedBy != null ) {
            this.UpdatedBy = UpdatedBy;
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
        //      C# -> TemplateDocFormat? DocFormat
        // GraphQL -> docFormat: TemplateDocFormat! (enum)
        if (this.DocFormat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "docFormat\n" ;
            } else {
                s += ind + "docFormat\n" ;
            }
        }
        //      C# -> TemplateMessageType? MsgType
        // GraphQL -> msgType: TemplateMessageType! (enum)
        if (this.MsgType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "msgType\n" ;
            } else {
                s += ind + "msgType\n" ;
            }
        }
        //      C# -> TemplateRecordType? RecordType
        // GraphQL -> recordType: TemplateRecordType! (enum)
        if (this.RecordType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recordType\n" ;
            } else {
                s += ind + "recordType\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String (scalar)
        if (this.CreatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdBy\n" ;
            } else {
                s += ind + "createdBy\n" ;
            }
        }
        //      C# -> System.String? DocUrl
        // GraphQL -> docUrl: String (scalar)
        if (this.DocUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "docUrl\n" ;
            } else {
                s += ind + "docUrl\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? TemplateData
        // GraphQL -> templateData: String! (scalar)
        if (this.TemplateData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateData\n" ;
            } else {
                s += ind + "templateData\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String (scalar)
        if (this.UpdatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedBy\n" ;
            } else {
                s += ind + "updatedBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> TemplateDocFormat? DocFormat
        // GraphQL -> docFormat: TemplateDocFormat! (enum)
        if (ec.Includes("docFormat",true))
        {
            if(this.DocFormat == null) {

                this.DocFormat = new TemplateDocFormat();

            } else {


            }
        }
        else if (this.DocFormat != null && ec.Excludes("docFormat",true))
        {
            this.DocFormat = null;
        }
        //      C# -> TemplateMessageType? MsgType
        // GraphQL -> msgType: TemplateMessageType! (enum)
        if (ec.Includes("msgType",true))
        {
            if(this.MsgType == null) {

                this.MsgType = new TemplateMessageType();

            } else {


            }
        }
        else if (this.MsgType != null && ec.Excludes("msgType",true))
        {
            this.MsgType = null;
        }
        //      C# -> TemplateRecordType? RecordType
        // GraphQL -> recordType: TemplateRecordType! (enum)
        if (ec.Includes("recordType",true))
        {
            if(this.RecordType == null) {

                this.RecordType = new TemplateRecordType();

            } else {


            }
        }
        else if (this.RecordType != null && ec.Excludes("recordType",true))
        {
            this.RecordType = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String (scalar)
        if (ec.Includes("createdBy",true))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = "FETCH";

            } else {


            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",true))
        {
            this.CreatedBy = null;
        }
        //      C# -> System.String? DocUrl
        // GraphQL -> docUrl: String (scalar)
        if (ec.Includes("docUrl",true))
        {
            if(this.DocUrl == null) {

                this.DocUrl = "FETCH";

            } else {


            }
        }
        else if (this.DocUrl != null && ec.Excludes("docUrl",true))
        {
            this.DocUrl = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? TemplateData
        // GraphQL -> templateData: String! (scalar)
        if (ec.Includes("templateData",true))
        {
            if(this.TemplateData == null) {

                this.TemplateData = "FETCH";

            } else {


            }
        }
        else if (this.TemplateData != null && ec.Excludes("templateData",true))
        {
            this.TemplateData = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> System.String? UpdatedBy
        // GraphQL -> updatedBy: String (scalar)
        if (ec.Includes("updatedBy",true))
        {
            if(this.UpdatedBy == null) {

                this.UpdatedBy = "FETCH";

            } else {


            }
        }
        else if (this.UpdatedBy != null && ec.Excludes("updatedBy",true))
        {
            this.UpdatedBy = null;
        }
    }


    #endregion

    } // class WebhookMessageTemplate
    
    #endregion

    public static class ListWebhookMessageTemplateExtensions
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
            this List<WebhookMessageTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WebhookMessageTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WebhookMessageTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WebhookMessageTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WebhookMessageTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types