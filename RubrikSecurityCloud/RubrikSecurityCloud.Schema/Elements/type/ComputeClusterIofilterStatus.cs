// ComputeClusterIofilterStatus.cs
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
    #region ComputeClusterIofilterStatus
    public class ComputeClusterIofilterStatus: BaseType
    {
        #region members

        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        [JsonProperty("computeClusterFid")]
        public System.String? ComputeClusterFid { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        [JsonProperty("iofilterStatus")]
        public System.String? IofilterStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComputeClusterIofilterStatus";
    }

    public ComputeClusterIofilterStatus Set(
        System.String? ComputeClusterFid = null,
        System.String? ComputeClusterName = null,
        System.String? IofilterStatus = null
    ) 
    {
        if ( ComputeClusterFid != null ) {
            this.ComputeClusterFid = ComputeClusterFid;
        }
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( IofilterStatus != null ) {
            this.IofilterStatus = IofilterStatus;
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
        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        if (this.ComputeClusterFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterFid\n" ;
            } else {
                s += ind + "computeClusterFid\n" ;
            }
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterName\n" ;
            } else {
                s += ind + "computeClusterName\n" ;
            }
        }
        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        if (this.IofilterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iofilterStatus\n" ;
            } else {
                s += ind + "iofilterStatus\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        if (ec.Includes("computeClusterFid",true))
        {
            if(this.ComputeClusterFid == null) {

                this.ComputeClusterFid = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterFid != null && ec.Excludes("computeClusterFid",true))
        {
            this.ComputeClusterFid = null;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (ec.Includes("computeClusterName",true))
        {
            if(this.ComputeClusterName == null) {

                this.ComputeClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterName != null && ec.Excludes("computeClusterName",true))
        {
            this.ComputeClusterName = null;
        }
        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        if (ec.Includes("iofilterStatus",true))
        {
            if(this.IofilterStatus == null) {

                this.IofilterStatus = "FETCH";

            } else {


            }
        }
        else if (this.IofilterStatus != null && ec.Excludes("iofilterStatus",true))
        {
            this.IofilterStatus = null;
        }
    }


    #endregion

    } // class ComputeClusterIofilterStatus
    
    #endregion

    public static class ListComputeClusterIofilterStatusExtensions
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
            this List<ComputeClusterIofilterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ComputeClusterIofilterStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterIofilterStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterIofilterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComputeClusterIofilterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types