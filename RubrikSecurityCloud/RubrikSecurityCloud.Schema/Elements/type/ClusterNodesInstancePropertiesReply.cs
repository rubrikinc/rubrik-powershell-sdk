// ClusterNodesInstancePropertiesReply.cs
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
    #region ClusterNodesInstancePropertiesReply
    public class ClusterNodesInstancePropertiesReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> List<ClusterNodeInstanceProperties>? ClusterNodeInstanceProperties
        // GraphQL -> clusterNodeInstanceProperties: [ClusterNodeInstanceProperties!]! (type)
        [JsonProperty("clusterNodeInstanceProperties")]
        public List<ClusterNodeInstanceProperties>? ClusterNodeInstanceProperties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNodesInstancePropertiesReply";
    }

    public ClusterNodesInstancePropertiesReply Set(
        System.String? ClusterUuid = null,
        List<ClusterNodeInstanceProperties>? ClusterNodeInstanceProperties = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ClusterNodeInstanceProperties != null ) {
            this.ClusterNodeInstanceProperties = ClusterNodeInstanceProperties;
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
        //      C# -> List<ClusterNodeInstanceProperties>? ClusterNodeInstanceProperties
        // GraphQL -> clusterNodeInstanceProperties: [ClusterNodeInstanceProperties!]! (type)
        if (this.ClusterNodeInstanceProperties != null) {
            var fspec = this.ClusterNodeInstanceProperties.AsFieldSpec(conf.Child("clusterNodeInstanceProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterNodeInstanceProperties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> List<ClusterNodeInstanceProperties>? ClusterNodeInstanceProperties
        // GraphQL -> clusterNodeInstanceProperties: [ClusterNodeInstanceProperties!]! (type)
        if (ec.Includes("clusterNodeInstanceProperties",false))
        {
            if(this.ClusterNodeInstanceProperties == null) {

                this.ClusterNodeInstanceProperties = new List<ClusterNodeInstanceProperties>();
                this.ClusterNodeInstanceProperties.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeInstanceProperties"));

            } else {

                this.ClusterNodeInstanceProperties.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeInstanceProperties"));

            }
        }
        else if (this.ClusterNodeInstanceProperties != null && ec.Excludes("clusterNodeInstanceProperties",false))
        {
            this.ClusterNodeInstanceProperties = null;
        }
    }


    #endregion

    } // class ClusterNodesInstancePropertiesReply
    
    #endregion

    public static class ListClusterNodesInstancePropertiesReplyExtensions
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
            this List<ClusterNodesInstancePropertiesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterNodesInstancePropertiesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNodesInstancePropertiesReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodesInstancePropertiesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNodesInstancePropertiesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types