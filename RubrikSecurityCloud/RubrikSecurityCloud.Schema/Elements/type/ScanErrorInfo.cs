// ScanErrorInfo.cs
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
    #region ScanErrorInfo
    public class ScanErrorInfo: BaseType
    {
        #region members

        //      C# -> FlowErrorCode? FlowErrorCode
        // GraphQL -> flowErrorCode: FlowErrorCode! (enum)
        [JsonProperty("flowErrorCode")]
        public FlowErrorCode? FlowErrorCode { get; set; }

        //      C# -> List<KeyValuePair>? ErrorVariables
        // GraphQL -> errorVariables: [KeyValuePair!]! (type)
        [JsonProperty("errorVariables")]
        public List<KeyValuePair>? ErrorVariables { get; set; }

        //      C# -> ScanResultDetails? ScanResultDetails
        // GraphQL -> scanResultDetails: ScanResultDetails (type)
        [JsonProperty("scanResultDetails")]
        public ScanResultDetails? ScanResultDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScanErrorInfo";
    }

    public ScanErrorInfo Set(
        FlowErrorCode? FlowErrorCode = null,
        List<KeyValuePair>? ErrorVariables = null,
        ScanResultDetails? ScanResultDetails = null
    ) 
    {
        if ( FlowErrorCode != null ) {
            this.FlowErrorCode = FlowErrorCode;
        }
        if ( ErrorVariables != null ) {
            this.ErrorVariables = ErrorVariables;
        }
        if ( ScanResultDetails != null ) {
            this.ScanResultDetails = ScanResultDetails;
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
        //      C# -> FlowErrorCode? FlowErrorCode
        // GraphQL -> flowErrorCode: FlowErrorCode! (enum)
        if (this.FlowErrorCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "flowErrorCode\n" ;
            } else {
                s += ind + "flowErrorCode\n" ;
            }
        }
        //      C# -> List<KeyValuePair>? ErrorVariables
        // GraphQL -> errorVariables: [KeyValuePair!]! (type)
        if (this.ErrorVariables != null) {
            var fspec = this.ErrorVariables.AsFieldSpec(conf.Child("errorVariables"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errorVariables" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ScanResultDetails? ScanResultDetails
        // GraphQL -> scanResultDetails: ScanResultDetails (type)
        if (this.ScanResultDetails != null) {
            var fspec = this.ScanResultDetails.AsFieldSpec(conf.Child("scanResultDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scanResultDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FlowErrorCode? FlowErrorCode
        // GraphQL -> flowErrorCode: FlowErrorCode! (enum)
        if (ec.Includes("flowErrorCode",true))
        {
            if(this.FlowErrorCode == null) {

                this.FlowErrorCode = new FlowErrorCode();

            } else {


            }
        }
        else if (this.FlowErrorCode != null && ec.Excludes("flowErrorCode",true))
        {
            this.FlowErrorCode = null;
        }
        //      C# -> List<KeyValuePair>? ErrorVariables
        // GraphQL -> errorVariables: [KeyValuePair!]! (type)
        if (ec.Includes("errorVariables",false))
        {
            if(this.ErrorVariables == null) {

                this.ErrorVariables = new List<KeyValuePair>();
                this.ErrorVariables.ApplyExploratoryFieldSpec(ec.NewChild("errorVariables"));

            } else {

                this.ErrorVariables.ApplyExploratoryFieldSpec(ec.NewChild("errorVariables"));

            }
        }
        else if (this.ErrorVariables != null && ec.Excludes("errorVariables",false))
        {
            this.ErrorVariables = null;
        }
        //      C# -> ScanResultDetails? ScanResultDetails
        // GraphQL -> scanResultDetails: ScanResultDetails (type)
        if (ec.Includes("scanResultDetails",false))
        {
            if(this.ScanResultDetails == null) {

                this.ScanResultDetails = new ScanResultDetails();
                this.ScanResultDetails.ApplyExploratoryFieldSpec(ec.NewChild("scanResultDetails"));

            } else {

                this.ScanResultDetails.ApplyExploratoryFieldSpec(ec.NewChild("scanResultDetails"));

            }
        }
        else if (this.ScanResultDetails != null && ec.Excludes("scanResultDetails",false))
        {
            this.ScanResultDetails = null;
        }
    }


    #endregion

    } // class ScanErrorInfo
    
    #endregion

    public static class ListScanErrorInfoExtensions
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
            this List<ScanErrorInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScanErrorInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScanErrorInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScanErrorInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScanErrorInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types