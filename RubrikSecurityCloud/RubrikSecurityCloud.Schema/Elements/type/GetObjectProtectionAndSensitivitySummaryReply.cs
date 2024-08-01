// GetObjectProtectionAndSensitivitySummaryReply.cs
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
    #region GetObjectProtectionAndSensitivitySummaryReply
    public class GetObjectProtectionAndSensitivitySummaryReply: BaseType
    {
        #region members

        //      C# -> List<ObjectProtectionSummaryPerSnappableType>? ObjectProtectionSummaryPerSnappableType
        // GraphQL -> objectProtectionSummaryPerSnappableType: [ObjectProtectionSummaryPerSnappableType!]! (type)
        [JsonProperty("objectProtectionSummaryPerSnappableType")]
        public List<ObjectProtectionSummaryPerSnappableType>? ObjectProtectionSummaryPerSnappableType { get; set; }

        //      C# -> List<RelicObjectSummaryPerSnappableType>? RelicObjectSummaryPerSnappableType
        // GraphQL -> relicObjectSummaryPerSnappableType: [RelicObjectSummaryPerSnappableType!]! (type)
        [JsonProperty("relicObjectSummaryPerSnappableType")]
        public List<RelicObjectSummaryPerSnappableType>? RelicObjectSummaryPerSnappableType { get; set; }

        //      C# -> List<UnaccessedSummaryPerSnappableType>? UnaccessedSummaryPerSnappableType
        // GraphQL -> unaccessedSummaryPerSnappableType: [UnaccessedSummaryPerSnappableType!]! (type)
        [JsonProperty("unaccessedSummaryPerSnappableType")]
        public List<UnaccessedSummaryPerSnappableType>? UnaccessedSummaryPerSnappableType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetObjectProtectionAndSensitivitySummaryReply";
    }

    public GetObjectProtectionAndSensitivitySummaryReply Set(
        List<ObjectProtectionSummaryPerSnappableType>? ObjectProtectionSummaryPerSnappableType = null,
        List<RelicObjectSummaryPerSnappableType>? RelicObjectSummaryPerSnappableType = null,
        List<UnaccessedSummaryPerSnappableType>? UnaccessedSummaryPerSnappableType = null
    ) 
    {
        if ( ObjectProtectionSummaryPerSnappableType != null ) {
            this.ObjectProtectionSummaryPerSnappableType = ObjectProtectionSummaryPerSnappableType;
        }
        if ( RelicObjectSummaryPerSnappableType != null ) {
            this.RelicObjectSummaryPerSnappableType = RelicObjectSummaryPerSnappableType;
        }
        if ( UnaccessedSummaryPerSnappableType != null ) {
            this.UnaccessedSummaryPerSnappableType = UnaccessedSummaryPerSnappableType;
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
        //      C# -> List<ObjectProtectionSummaryPerSnappableType>? ObjectProtectionSummaryPerSnappableType
        // GraphQL -> objectProtectionSummaryPerSnappableType: [ObjectProtectionSummaryPerSnappableType!]! (type)
        if (this.ObjectProtectionSummaryPerSnappableType != null) {
            var fspec = this.ObjectProtectionSummaryPerSnappableType.AsFieldSpec(conf.Child("objectProtectionSummaryPerSnappableType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectProtectionSummaryPerSnappableType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RelicObjectSummaryPerSnappableType>? RelicObjectSummaryPerSnappableType
        // GraphQL -> relicObjectSummaryPerSnappableType: [RelicObjectSummaryPerSnappableType!]! (type)
        if (this.RelicObjectSummaryPerSnappableType != null) {
            var fspec = this.RelicObjectSummaryPerSnappableType.AsFieldSpec(conf.Child("relicObjectSummaryPerSnappableType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relicObjectSummaryPerSnappableType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UnaccessedSummaryPerSnappableType>? UnaccessedSummaryPerSnappableType
        // GraphQL -> unaccessedSummaryPerSnappableType: [UnaccessedSummaryPerSnappableType!]! (type)
        if (this.UnaccessedSummaryPerSnappableType != null) {
            var fspec = this.UnaccessedSummaryPerSnappableType.AsFieldSpec(conf.Child("unaccessedSummaryPerSnappableType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unaccessedSummaryPerSnappableType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ObjectProtectionSummaryPerSnappableType>? ObjectProtectionSummaryPerSnappableType
        // GraphQL -> objectProtectionSummaryPerSnappableType: [ObjectProtectionSummaryPerSnappableType!]! (type)
        if (ec.Includes("objectProtectionSummaryPerSnappableType",false))
        {
            if(this.ObjectProtectionSummaryPerSnappableType == null) {

                this.ObjectProtectionSummaryPerSnappableType = new List<ObjectProtectionSummaryPerSnappableType>();
                this.ObjectProtectionSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("objectProtectionSummaryPerSnappableType"));

            } else {

                this.ObjectProtectionSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("objectProtectionSummaryPerSnappableType"));

            }
        }
        else if (this.ObjectProtectionSummaryPerSnappableType != null && ec.Excludes("objectProtectionSummaryPerSnappableType",false))
        {
            this.ObjectProtectionSummaryPerSnappableType = null;
        }
        //      C# -> List<RelicObjectSummaryPerSnappableType>? RelicObjectSummaryPerSnappableType
        // GraphQL -> relicObjectSummaryPerSnappableType: [RelicObjectSummaryPerSnappableType!]! (type)
        if (ec.Includes("relicObjectSummaryPerSnappableType",false))
        {
            if(this.RelicObjectSummaryPerSnappableType == null) {

                this.RelicObjectSummaryPerSnappableType = new List<RelicObjectSummaryPerSnappableType>();
                this.RelicObjectSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("relicObjectSummaryPerSnappableType"));

            } else {

                this.RelicObjectSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("relicObjectSummaryPerSnappableType"));

            }
        }
        else if (this.RelicObjectSummaryPerSnappableType != null && ec.Excludes("relicObjectSummaryPerSnappableType",false))
        {
            this.RelicObjectSummaryPerSnappableType = null;
        }
        //      C# -> List<UnaccessedSummaryPerSnappableType>? UnaccessedSummaryPerSnappableType
        // GraphQL -> unaccessedSummaryPerSnappableType: [UnaccessedSummaryPerSnappableType!]! (type)
        if (ec.Includes("unaccessedSummaryPerSnappableType",false))
        {
            if(this.UnaccessedSummaryPerSnappableType == null) {

                this.UnaccessedSummaryPerSnappableType = new List<UnaccessedSummaryPerSnappableType>();
                this.UnaccessedSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("unaccessedSummaryPerSnappableType"));

            } else {

                this.UnaccessedSummaryPerSnappableType.ApplyExploratoryFieldSpec(ec.NewChild("unaccessedSummaryPerSnappableType"));

            }
        }
        else if (this.UnaccessedSummaryPerSnappableType != null && ec.Excludes("unaccessedSummaryPerSnappableType",false))
        {
            this.UnaccessedSummaryPerSnappableType = null;
        }
    }


    #endregion

    } // class GetObjectProtectionAndSensitivitySummaryReply
    
    #endregion

    public static class ListGetObjectProtectionAndSensitivitySummaryReplyExtensions
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
            this List<GetObjectProtectionAndSensitivitySummaryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetObjectProtectionAndSensitivitySummaryReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetObjectProtectionAndSensitivitySummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetObjectProtectionAndSensitivitySummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetObjectProtectionAndSensitivitySummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types