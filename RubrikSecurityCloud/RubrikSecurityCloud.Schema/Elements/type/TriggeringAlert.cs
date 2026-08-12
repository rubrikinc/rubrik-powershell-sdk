// TriggeringAlert.cs
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
    #region TriggeringAlert
    public class TriggeringAlert: BaseType
    {
        #region members

        //      C# -> DateTime? AlertTime
        // GraphQL -> alertTime: DateTime (scalar)
        [JsonProperty("alertTime")]
        public DateTime? AlertTime { get; set; }

        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        [JsonProperty("detectionName")]
        public System.String? DetectionName { get; set; }

        //      C# -> System.String? OriginId
        // GraphQL -> originId: String! (scalar)
        [JsonProperty("originId")]
        public System.String? OriginId { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        //      C# -> System.String? VendorDetectionId
        // GraphQL -> vendorDetectionId: String! (scalar)
        [JsonProperty("vendorDetectionId")]
        public System.String? VendorDetectionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TriggeringAlert";
    }

    public TriggeringAlert Set(
        DateTime? AlertTime = null,
        System.String? DetectionName = null,
        System.String? OriginId = null,
        System.String? Source = null,
        System.String? VendorDetectionId = null
    ) 
    {
        if ( AlertTime != null ) {
            this.AlertTime = AlertTime;
        }
        if ( DetectionName != null ) {
            this.DetectionName = DetectionName;
        }
        if ( OriginId != null ) {
            this.OriginId = OriginId;
        }
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( VendorDetectionId != null ) {
            this.VendorDetectionId = VendorDetectionId;
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
        //      C# -> DateTime? AlertTime
        // GraphQL -> alertTime: DateTime (scalar)
        if (this.AlertTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "alertTime\n" ;
            } else {
                s += ind + "alertTime\n" ;
            }
        }
        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        if (this.DetectionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionName\n" ;
            } else {
                s += ind + "detectionName\n" ;
            }
        }
        //      C# -> System.String? OriginId
        // GraphQL -> originId: String! (scalar)
        if (this.OriginId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originId\n" ;
            } else {
                s += ind + "originId\n" ;
            }
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> System.String? VendorDetectionId
        // GraphQL -> vendorDetectionId: String! (scalar)
        if (this.VendorDetectionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendorDetectionId\n" ;
            } else {
                s += ind + "vendorDetectionId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? AlertTime
        // GraphQL -> alertTime: DateTime (scalar)
        if (ec.Includes("alertTime",true))
        {
            if(this.AlertTime == null) {

                this.AlertTime = new DateTime();

            } else {


            }
        }
        else if (this.AlertTime != null && ec.Excludes("alertTime",true))
        {
            this.AlertTime = null;
        }
        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        if (ec.Includes("detectionName",true))
        {
            if(this.DetectionName == null) {

                this.DetectionName = "FETCH";

            } else {


            }
        }
        else if (this.DetectionName != null && ec.Excludes("detectionName",true))
        {
            this.DetectionName = null;
        }
        //      C# -> System.String? OriginId
        // GraphQL -> originId: String! (scalar)
        if (ec.Includes("originId",true))
        {
            if(this.OriginId == null) {

                this.OriginId = "FETCH";

            } else {


            }
        }
        else if (this.OriginId != null && ec.Excludes("originId",true))
        {
            this.OriginId = null;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String! (scalar)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = "FETCH";

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> System.String? VendorDetectionId
        // GraphQL -> vendorDetectionId: String! (scalar)
        if (ec.Includes("vendorDetectionId",true))
        {
            if(this.VendorDetectionId == null) {

                this.VendorDetectionId = "FETCH";

            } else {


            }
        }
        else if (this.VendorDetectionId != null && ec.Excludes("vendorDetectionId",true))
        {
            this.VendorDetectionId = null;
        }
    }


    #endregion

    } // class TriggeringAlert
    
    #endregion

    public static class ListTriggeringAlertExtensions
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
            this List<TriggeringAlert> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TriggeringAlert> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TriggeringAlert> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TriggeringAlert());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TriggeringAlert> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types