// Db2CrossHostRecoveryMetadata.cs
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
    #region Db2CrossHostRecoveryMetadata
    public class Db2CrossHostRecoveryMetadata: BaseType
    {
        #region members

        //      C# -> List<Db2CrossHostRecoveryInfo>? HostInfoList
        // GraphQL -> hostInfoList: [Db2CrossHostRecoveryInfo!]! (type)
        [JsonProperty("hostInfoList")]
        public List<Db2CrossHostRecoveryInfo>? HostInfoList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2CrossHostRecoveryMetadata";
    }

    public Db2CrossHostRecoveryMetadata Set(
        List<Db2CrossHostRecoveryInfo>? HostInfoList = null
    ) 
    {
        if ( HostInfoList != null ) {
            this.HostInfoList = HostInfoList;
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
        //      C# -> List<Db2CrossHostRecoveryInfo>? HostInfoList
        // GraphQL -> hostInfoList: [Db2CrossHostRecoveryInfo!]! (type)
        if (this.HostInfoList != null) {
            var fspec = this.HostInfoList.AsFieldSpec(conf.Child("hostInfoList"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostInfoList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Db2CrossHostRecoveryInfo>? HostInfoList
        // GraphQL -> hostInfoList: [Db2CrossHostRecoveryInfo!]! (type)
        if (ec.Includes("hostInfoList",false))
        {
            if(this.HostInfoList == null) {

                this.HostInfoList = new List<Db2CrossHostRecoveryInfo>();
                this.HostInfoList.ApplyExploratoryFieldSpec(ec.NewChild("hostInfoList"));

            } else {

                this.HostInfoList.ApplyExploratoryFieldSpec(ec.NewChild("hostInfoList"));

            }
        }
        else if (this.HostInfoList != null && ec.Excludes("hostInfoList",false))
        {
            this.HostInfoList = null;
        }
    }


    #endregion

    } // class Db2CrossHostRecoveryMetadata
    
    #endregion

    public static class ListDb2CrossHostRecoveryMetadataExtensions
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
            this List<Db2CrossHostRecoveryMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Db2CrossHostRecoveryMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Db2CrossHostRecoveryMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2CrossHostRecoveryMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Db2CrossHostRecoveryMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types