// ClusterNodeDetail.cs
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
    #region ClusterNodeDetail
    public class ClusterNodeDetail: BaseType
    {
        #region members

        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        [JsonProperty("chassisId")]
        public System.String? ChassisId { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Platform
        // GraphQL -> platform: String! (scalar)
        [JsonProperty("platform")]
        public System.String? Platform { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.Boolean? UseQuickDrain
        // GraphQL -> useQuickDrain: Boolean! (scalar)
        [JsonProperty("useQuickDrain")]
        public System.Boolean? UseQuickDrain { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNodeDetail";
    }

    public ClusterNodeDetail Set(
        System.String? ChassisId = null,
        System.String? NodeId = null,
        System.String? Platform = null,
        System.String? Status = null,
        System.Boolean? UseQuickDrain = null
    ) 
    {
        if ( ChassisId != null ) {
            this.ChassisId = ChassisId;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( UseQuickDrain != null ) {
            this.UseQuickDrain = UseQuickDrain;
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
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        if (this.ChassisId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chassisId\n" ;
            } else {
                s += ind + "chassisId\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? Platform
        // GraphQL -> platform: String! (scalar)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Boolean? UseQuickDrain
        // GraphQL -> useQuickDrain: Boolean! (scalar)
        if (this.UseQuickDrain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useQuickDrain\n" ;
            } else {
                s += ind + "useQuickDrain\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        if (ec.Includes("chassisId",true))
        {
            if(this.ChassisId == null) {

                this.ChassisId = "FETCH";

            } else {


            }
        }
        else if (this.ChassisId != null && ec.Excludes("chassisId",true))
        {
            this.ChassisId = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? Platform
        // GraphQL -> platform: String! (scalar)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = "FETCH";

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Boolean? UseQuickDrain
        // GraphQL -> useQuickDrain: Boolean! (scalar)
        if (ec.Includes("useQuickDrain",true))
        {
            if(this.UseQuickDrain == null) {

                this.UseQuickDrain = true;

            } else {


            }
        }
        else if (this.UseQuickDrain != null && ec.Excludes("useQuickDrain",true))
        {
            this.UseQuickDrain = null;
        }
    }


    #endregion

    } // class ClusterNodeDetail
    
    #endregion

    public static class ListClusterNodeDetailExtensions
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
            this List<ClusterNodeDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterNodeDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNodeDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNodeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types