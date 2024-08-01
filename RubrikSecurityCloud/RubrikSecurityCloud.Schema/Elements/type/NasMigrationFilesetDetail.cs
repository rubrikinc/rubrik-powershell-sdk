// NasMigrationFilesetDetail.cs
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
    #region NasMigrationFilesetDetail
    public class NasMigrationFilesetDetail: BaseType
    {
        #region members

        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        [JsonProperty("filesetName")]
        public System.String? FilesetName { get; set; }

        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        [JsonProperty("newExceptionRule")]
        public System.String? NewExceptionRule { get; set; }

        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        [JsonProperty("newExcludeRules")]
        public System.String? NewExcludeRules { get; set; }

        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        [JsonProperty("newFilesetTemplateFid")]
        public System.String? NewFilesetTemplateFid { get; set; }

        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        [JsonProperty("newIncludeRules")]
        public System.String? NewIncludeRules { get; set; }

        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        [JsonProperty("oldFilesetTemplateCdmId")]
        public System.String? OldFilesetTemplateCdmId { get; set; }

        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        [JsonProperty("oldFilesetTemplateFid")]
        public System.String? OldFilesetTemplateFid { get; set; }

        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        [JsonProperty("protectionType")]
        public System.String? ProtectionType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasMigrationFilesetDetail";
    }

    public NasMigrationFilesetDetail Set(
        System.String? FilesetName = null,
        System.String? NewExceptionRule = null,
        System.String? NewExcludeRules = null,
        System.String? NewFilesetTemplateFid = null,
        System.String? NewIncludeRules = null,
        System.String? OldFilesetTemplateCdmId = null,
        System.String? OldFilesetTemplateFid = null,
        System.String? ProtectionType = null
    ) 
    {
        if ( FilesetName != null ) {
            this.FilesetName = FilesetName;
        }
        if ( NewExceptionRule != null ) {
            this.NewExceptionRule = NewExceptionRule;
        }
        if ( NewExcludeRules != null ) {
            this.NewExcludeRules = NewExcludeRules;
        }
        if ( NewFilesetTemplateFid != null ) {
            this.NewFilesetTemplateFid = NewFilesetTemplateFid;
        }
        if ( NewIncludeRules != null ) {
            this.NewIncludeRules = NewIncludeRules;
        }
        if ( OldFilesetTemplateCdmId != null ) {
            this.OldFilesetTemplateCdmId = OldFilesetTemplateCdmId;
        }
        if ( OldFilesetTemplateFid != null ) {
            this.OldFilesetTemplateFid = OldFilesetTemplateFid;
        }
        if ( ProtectionType != null ) {
            this.ProtectionType = ProtectionType;
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
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesetName\n" ;
            } else {
                s += ind + "filesetName\n" ;
            }
        }
        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        if (this.NewExceptionRule != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newExceptionRule\n" ;
            } else {
                s += ind + "newExceptionRule\n" ;
            }
        }
        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        if (this.NewExcludeRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newExcludeRules\n" ;
            } else {
                s += ind + "newExcludeRules\n" ;
            }
        }
        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        if (this.NewFilesetTemplateFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newFilesetTemplateFid\n" ;
            } else {
                s += ind + "newFilesetTemplateFid\n" ;
            }
        }
        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        if (this.NewIncludeRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newIncludeRules\n" ;
            } else {
                s += ind + "newIncludeRules\n" ;
            }
        }
        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        if (this.OldFilesetTemplateCdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldFilesetTemplateCdmId\n" ;
            } else {
                s += ind + "oldFilesetTemplateCdmId\n" ;
            }
        }
        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        if (this.OldFilesetTemplateFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldFilesetTemplateFid\n" ;
            } else {
                s += ind + "oldFilesetTemplateFid\n" ;
            }
        }
        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        if (this.ProtectionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionType\n" ;
            } else {
                s += ind + "protectionType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (ec.Includes("filesetName",true))
        {
            if(this.FilesetName == null) {

                this.FilesetName = "FETCH";

            } else {


            }
        }
        else if (this.FilesetName != null && ec.Excludes("filesetName",true))
        {
            this.FilesetName = null;
        }
        //      C# -> System.String? NewExceptionRule
        // GraphQL -> newExceptionRule: String! (scalar)
        if (ec.Includes("newExceptionRule",true))
        {
            if(this.NewExceptionRule == null) {

                this.NewExceptionRule = "FETCH";

            } else {


            }
        }
        else if (this.NewExceptionRule != null && ec.Excludes("newExceptionRule",true))
        {
            this.NewExceptionRule = null;
        }
        //      C# -> System.String? NewExcludeRules
        // GraphQL -> newExcludeRules: String! (scalar)
        if (ec.Includes("newExcludeRules",true))
        {
            if(this.NewExcludeRules == null) {

                this.NewExcludeRules = "FETCH";

            } else {


            }
        }
        else if (this.NewExcludeRules != null && ec.Excludes("newExcludeRules",true))
        {
            this.NewExcludeRules = null;
        }
        //      C# -> System.String? NewFilesetTemplateFid
        // GraphQL -> newFilesetTemplateFid: String! (scalar)
        if (ec.Includes("newFilesetTemplateFid",true))
        {
            if(this.NewFilesetTemplateFid == null) {

                this.NewFilesetTemplateFid = "FETCH";

            } else {


            }
        }
        else if (this.NewFilesetTemplateFid != null && ec.Excludes("newFilesetTemplateFid",true))
        {
            this.NewFilesetTemplateFid = null;
        }
        //      C# -> System.String? NewIncludeRules
        // GraphQL -> newIncludeRules: String! (scalar)
        if (ec.Includes("newIncludeRules",true))
        {
            if(this.NewIncludeRules == null) {

                this.NewIncludeRules = "FETCH";

            } else {


            }
        }
        else if (this.NewIncludeRules != null && ec.Excludes("newIncludeRules",true))
        {
            this.NewIncludeRules = null;
        }
        //      C# -> System.String? OldFilesetTemplateCdmId
        // GraphQL -> oldFilesetTemplateCdmId: String! (scalar)
        if (ec.Includes("oldFilesetTemplateCdmId",true))
        {
            if(this.OldFilesetTemplateCdmId == null) {

                this.OldFilesetTemplateCdmId = "FETCH";

            } else {


            }
        }
        else if (this.OldFilesetTemplateCdmId != null && ec.Excludes("oldFilesetTemplateCdmId",true))
        {
            this.OldFilesetTemplateCdmId = null;
        }
        //      C# -> System.String? OldFilesetTemplateFid
        // GraphQL -> oldFilesetTemplateFid: String! (scalar)
        if (ec.Includes("oldFilesetTemplateFid",true))
        {
            if(this.OldFilesetTemplateFid == null) {

                this.OldFilesetTemplateFid = "FETCH";

            } else {


            }
        }
        else if (this.OldFilesetTemplateFid != null && ec.Excludes("oldFilesetTemplateFid",true))
        {
            this.OldFilesetTemplateFid = null;
        }
        //      C# -> System.String? ProtectionType
        // GraphQL -> protectionType: String! (scalar)
        if (ec.Includes("protectionType",true))
        {
            if(this.ProtectionType == null) {

                this.ProtectionType = "FETCH";

            } else {


            }
        }
        else if (this.ProtectionType != null && ec.Excludes("protectionType",true))
        {
            this.ProtectionType = null;
        }
    }


    #endregion

    } // class NasMigrationFilesetDetail
    
    #endregion

    public static class ListNasMigrationFilesetDetailExtensions
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
            this List<NasMigrationFilesetDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasMigrationFilesetDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationFilesetDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationFilesetDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasMigrationFilesetDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types