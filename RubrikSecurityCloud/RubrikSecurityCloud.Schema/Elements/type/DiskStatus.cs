// DiskStatus.cs
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
    #region DiskStatus
    public class DiskStatus: BaseType
    {
        #region members

        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        [JsonProperty("diskType")]
        public System.String? DiskType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        [JsonProperty("isDegraded")]
        public System.Boolean? IsDegraded { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DiskStatus";
    }

    public DiskStatus Set(
        System.String? DiskType = null,
        System.String? Id = null,
        System.Boolean? IsDegraded = null,
        System.Boolean? IsEncrypted = null,
        System.String? NodeId = null,
        System.String? Status = null
    ) 
    {
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDegraded != null ) {
            this.IsDegraded = IsDegraded;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (this.DiskType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskType\n" ;
            } else {
                s += ind + "diskType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        if (this.IsDegraded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDegraded\n" ;
            } else {
                s += ind + "isDegraded\n" ;
            }
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncrypted\n" ;
            } else {
                s += ind + "isEncrypted\n" ;
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
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (ec.Includes("diskType",true))
        {
            if(this.DiskType == null) {

                this.DiskType = "FETCH";

            } else {


            }
        }
        else if (this.DiskType != null && ec.Excludes("diskType",true))
        {
            this.DiskType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        if (ec.Includes("isDegraded",true))
        {
            if(this.IsDegraded == null) {

                this.IsDegraded = true;

            } else {


            }
        }
        else if (this.IsDegraded != null && ec.Excludes("isDegraded",true))
        {
            this.IsDegraded = null;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (ec.Includes("isEncrypted",true))
        {
            if(this.IsEncrypted == null) {

                this.IsEncrypted = true;

            } else {


            }
        }
        else if (this.IsEncrypted != null && ec.Excludes("isEncrypted",true))
        {
            this.IsEncrypted = null;
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
    }


    #endregion

    } // class DiskStatus
    
    #endregion

    public static class ListDiskStatusExtensions
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
            this List<DiskStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DiskStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DiskStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DiskStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DiskStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types