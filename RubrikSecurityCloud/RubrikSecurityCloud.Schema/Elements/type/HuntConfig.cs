// HuntConfig.cs
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
    #region HuntConfig
    public class HuntConfig: BaseType
    {
        #region members

        //      C# -> ThreatHuntType? HuntType
        // GraphQL -> huntType: ThreatHuntType! (enum)
        [JsonProperty("huntType")]
        public ThreatHuntType? HuntType { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!]! (scalar)
        [JsonProperty("objectFids")]
        public List<System.String>? ObjectFids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HuntConfig";
    }

    public HuntConfig Set(
        ThreatHuntType? HuntType = null,
        List<System.String>? ClusterUuids = null,
        List<System.String>? ObjectFids = null
    ) 
    {
        if ( HuntType != null ) {
            this.HuntType = HuntType;
        }
        if ( ClusterUuids != null ) {
            this.ClusterUuids = ClusterUuids;
        }
        if ( ObjectFids != null ) {
            this.ObjectFids = ObjectFids;
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
        //      C# -> ThreatHuntType? HuntType
        // GraphQL -> huntType: ThreatHuntType! (enum)
        if (this.HuntType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntType\n" ;
            } else {
                s += ind + "huntType\n" ;
            }
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuids\n" ;
            } else {
                s += ind + "clusterUuids\n" ;
            }
        }
        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!]! (scalar)
        if (this.ObjectFids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFids\n" ;
            } else {
                s += ind + "objectFids\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ThreatHuntType? HuntType
        // GraphQL -> huntType: ThreatHuntType! (enum)
        if (ec.Includes("huntType",true))
        {
            if(this.HuntType == null) {

                this.HuntType = new ThreatHuntType();

            } else {


            }
        }
        else if (this.HuntType != null && ec.Excludes("huntType",true))
        {
            this.HuntType = null;
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (ec.Includes("clusterUuids",true))
        {
            if(this.ClusterUuids == null) {

                this.ClusterUuids = new List<System.String>();

            } else {


            }
        }
        else if (this.ClusterUuids != null && ec.Excludes("clusterUuids",true))
        {
            this.ClusterUuids = null;
        }
        //      C# -> List<System.String>? ObjectFids
        // GraphQL -> objectFids: [UUID!]! (scalar)
        if (ec.Includes("objectFids",true))
        {
            if(this.ObjectFids == null) {

                this.ObjectFids = new List<System.String>();

            } else {


            }
        }
        else if (this.ObjectFids != null && ec.Excludes("objectFids",true))
        {
            this.ObjectFids = null;
        }
    }


    #endregion

    } // class HuntConfig
    
    #endregion

    public static class ListHuntConfigExtensions
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
            this List<HuntConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HuntConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HuntConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HuntConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HuntConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types