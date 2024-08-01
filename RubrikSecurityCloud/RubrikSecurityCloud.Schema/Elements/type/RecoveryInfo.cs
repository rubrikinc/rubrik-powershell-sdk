// RecoveryInfo.cs
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
    #region RecoveryInfo
    public class RecoveryInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        [JsonProperty("recoveryCount")]
        public System.Int32? RecoveryCount { get; set; }

        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        [JsonProperty("recoveryIds")]
        public List<System.String>? RecoveryIds { get; set; }

        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        [JsonProperty("recoveryType")]
        public System.String? RecoveryType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryInfo";
    }

    public RecoveryInfo Set(
        System.Int32? RecoveryCount = null,
        List<System.String>? RecoveryIds = null,
        System.String? RecoveryType = null
    ) 
    {
        if ( RecoveryCount != null ) {
            this.RecoveryCount = RecoveryCount;
        }
        if ( RecoveryIds != null ) {
            this.RecoveryIds = RecoveryIds;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
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
        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        if (this.RecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryCount\n" ;
            } else {
                s += ind + "recoveryCount\n" ;
            }
        }
        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        if (this.RecoveryIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryIds\n" ;
            } else {
                s += ind + "recoveryIds\n" ;
            }
        }
        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        if (this.RecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryType\n" ;
            } else {
                s += ind + "recoveryType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        if (ec.Includes("recoveryCount",true))
        {
            if(this.RecoveryCount == null) {

                this.RecoveryCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.RecoveryCount != null && ec.Excludes("recoveryCount",true))
        {
            this.RecoveryCount = null;
        }
        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        if (ec.Includes("recoveryIds",true))
        {
            if(this.RecoveryIds == null) {

                this.RecoveryIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RecoveryIds != null && ec.Excludes("recoveryIds",true))
        {
            this.RecoveryIds = null;
        }
        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        if (ec.Includes("recoveryType",true))
        {
            if(this.RecoveryType == null) {

                this.RecoveryType = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryType != null && ec.Excludes("recoveryType",true))
        {
            this.RecoveryType = null;
        }
    }


    #endregion

    } // class RecoveryInfo
    
    #endregion

    public static class ListRecoveryInfoExtensions
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
            this List<RecoveryInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types