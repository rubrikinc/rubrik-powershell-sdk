// CoordinatorLabelEntry.cs
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
    #region CoordinatorLabelEntry
    public class CoordinatorLabelEntry: BaseType
    {
        #region members

        //      C# -> List<CoordinatorLabel>? Labels
        // GraphQL -> labels: [CoordinatorLabel!]! (enum)
        [JsonProperty("labels")]
        public List<CoordinatorLabel>? Labels { get; set; }

        //      C# -> System.String? HardwareId
        // GraphQL -> hardwareId: String! (scalar)
        [JsonProperty("hardwareId")]
        public System.String? HardwareId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CoordinatorLabelEntry";
    }

    public CoordinatorLabelEntry Set(
        List<CoordinatorLabel>? Labels = null,
        System.String? HardwareId = null
    ) 
    {
        if ( Labels != null ) {
            this.Labels = Labels;
        }
        if ( HardwareId != null ) {
            this.HardwareId = HardwareId;
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
        //      C# -> List<CoordinatorLabel>? Labels
        // GraphQL -> labels: [CoordinatorLabel!]! (enum)
        if (this.Labels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labels\n" ;
            } else {
                s += ind + "labels\n" ;
            }
        }
        //      C# -> System.String? HardwareId
        // GraphQL -> hardwareId: String! (scalar)
        if (this.HardwareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hardwareId\n" ;
            } else {
                s += ind + "hardwareId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<CoordinatorLabel>? Labels
        // GraphQL -> labels: [CoordinatorLabel!]! (enum)
        if (ec.Includes("labels",true))
        {
            if(this.Labels == null) {

                this.Labels = new List<CoordinatorLabel>();

            } else {


            }
        }
        else if (this.Labels != null && ec.Excludes("labels",true))
        {
            this.Labels = null;
        }
        //      C# -> System.String? HardwareId
        // GraphQL -> hardwareId: String! (scalar)
        if (ec.Includes("hardwareId",true))
        {
            if(this.HardwareId == null) {

                this.HardwareId = "FETCH";

            } else {


            }
        }
        else if (this.HardwareId != null && ec.Excludes("hardwareId",true))
        {
            this.HardwareId = null;
        }
    }


    #endregion

    } // class CoordinatorLabelEntry
    
    #endregion

    public static class ListCoordinatorLabelEntryExtensions
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
            this List<CoordinatorLabelEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CoordinatorLabelEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CoordinatorLabelEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CoordinatorLabelEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CoordinatorLabelEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types