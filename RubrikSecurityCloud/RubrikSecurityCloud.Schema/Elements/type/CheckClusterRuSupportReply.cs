// CheckClusterRuSupportReply.cs
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
    #region CheckClusterRuSupportReply
    public class CheckClusterRuSupportReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? IsRuSupported
        // GraphQL -> isRuSupported: Boolean! (scalar)
        [JsonProperty("isRuSupported")]
        public System.Boolean? IsRuSupported { get; set; }

        //      C# -> System.String? RuUnsupportabilityReason
        // GraphQL -> ruUnsupportabilityReason: String! (scalar)
        [JsonProperty("ruUnsupportabilityReason")]
        public System.String? RuUnsupportabilityReason { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckClusterRuSupportReply";
    }

    public CheckClusterRuSupportReply Set(
        System.String? ClusterUuid = null,
        System.Boolean? IsRuSupported = null,
        System.String? RuUnsupportabilityReason = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( IsRuSupported != null ) {
            this.IsRuSupported = IsRuSupported;
        }
        if ( RuUnsupportabilityReason != null ) {
            this.RuUnsupportabilityReason = RuUnsupportabilityReason;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Boolean? IsRuSupported
        // GraphQL -> isRuSupported: Boolean! (scalar)
        if (this.IsRuSupported != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRuSupported\n" ;
            } else {
                s += ind + "isRuSupported\n" ;
            }
        }
        //      C# -> System.String? RuUnsupportabilityReason
        // GraphQL -> ruUnsupportabilityReason: String! (scalar)
        if (this.RuUnsupportabilityReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruUnsupportabilityReason\n" ;
            } else {
                s += ind + "ruUnsupportabilityReason\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Boolean? IsRuSupported
        // GraphQL -> isRuSupported: Boolean! (scalar)
        if (ec.Includes("isRuSupported",true))
        {
            if(this.IsRuSupported == null) {

                this.IsRuSupported = true;

            } else {


            }
        }
        else if (this.IsRuSupported != null && ec.Excludes("isRuSupported",true))
        {
            this.IsRuSupported = null;
        }
        //      C# -> System.String? RuUnsupportabilityReason
        // GraphQL -> ruUnsupportabilityReason: String! (scalar)
        if (ec.Includes("ruUnsupportabilityReason",true))
        {
            if(this.RuUnsupportabilityReason == null) {

                this.RuUnsupportabilityReason = "FETCH";

            } else {


            }
        }
        else if (this.RuUnsupportabilityReason != null && ec.Excludes("ruUnsupportabilityReason",true))
        {
            this.RuUnsupportabilityReason = null;
        }
    }


    #endregion

    } // class CheckClusterRuSupportReply
    
    #endregion

    public static class ListCheckClusterRuSupportReplyExtensions
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
            this List<CheckClusterRuSupportReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckClusterRuSupportReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckClusterRuSupportReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckClusterRuSupportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckClusterRuSupportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types