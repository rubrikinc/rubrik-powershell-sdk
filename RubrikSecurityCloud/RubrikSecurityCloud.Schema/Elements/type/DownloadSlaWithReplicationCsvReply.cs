// DownloadSlaWithReplicationCsvReply.cs
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
    #region DownloadSlaWithReplicationCsvReply
    public class DownloadSlaWithReplicationCsvReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        [JsonProperty("doesSlaExists")]
        public System.Boolean? DoesSlaExists { get; set; }

        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        [JsonProperty("isDownloadSuccessful")]
        public System.Boolean? IsDownloadSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadSlaWithReplicationCsvReply";
    }

    public DownloadSlaWithReplicationCsvReply Set(
        System.Boolean? DoesSlaExists = null,
        System.Boolean? IsDownloadSuccessful = null
    ) 
    {
        if ( DoesSlaExists != null ) {
            this.DoesSlaExists = DoesSlaExists;
        }
        if ( IsDownloadSuccessful != null ) {
            this.IsDownloadSuccessful = IsDownloadSuccessful;
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
        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        if (this.DoesSlaExists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "doesSlaExists\n" ;
            } else {
                s += ind + "doesSlaExists\n" ;
            }
        }
        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        if (this.IsDownloadSuccessful != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDownloadSuccessful\n" ;
            } else {
                s += ind + "isDownloadSuccessful\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? DoesSlaExists
        // GraphQL -> doesSlaExists: Boolean! (scalar)
        if (ec.Includes("doesSlaExists",true))
        {
            if(this.DoesSlaExists == null) {

                this.DoesSlaExists = true;

            } else {


            }
        }
        else if (this.DoesSlaExists != null && ec.Excludes("doesSlaExists",true))
        {
            this.DoesSlaExists = null;
        }
        //      C# -> System.Boolean? IsDownloadSuccessful
        // GraphQL -> isDownloadSuccessful: Boolean! (scalar)
        if (ec.Includes("isDownloadSuccessful",true))
        {
            if(this.IsDownloadSuccessful == null) {

                this.IsDownloadSuccessful = true;

            } else {


            }
        }
        else if (this.IsDownloadSuccessful != null && ec.Excludes("isDownloadSuccessful",true))
        {
            this.IsDownloadSuccessful = null;
        }
    }


    #endregion

    } // class DownloadSlaWithReplicationCsvReply
    
    #endregion

    public static class ListDownloadSlaWithReplicationCsvReplyExtensions
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
            this List<DownloadSlaWithReplicationCsvReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadSlaWithReplicationCsvReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadSlaWithReplicationCsvReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadSlaWithReplicationCsvReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadSlaWithReplicationCsvReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types