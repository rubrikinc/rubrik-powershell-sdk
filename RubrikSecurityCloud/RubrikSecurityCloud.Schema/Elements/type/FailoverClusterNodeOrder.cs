// FailoverClusterNodeOrder.cs
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
    #region FailoverClusterNodeOrder
    public class FailoverClusterNodeOrder: BaseType
    {
        #region members

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        [JsonProperty("order")]
        public System.Int32? Order { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterNodeOrder";
    }

    public FailoverClusterNodeOrder Set(
        System.String? NodeId = null,
        System.String? NodeName = null,
        System.Int32? Order = null
    ) 
    {
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( Order != null ) {
            this.Order = Order;
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
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        if (this.Order != null) {
            if (conf.Flat) {
                s += conf.Prefix + "order\n" ;
            } else {
                s += ind + "order\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        if (ec.Includes("order",true))
        {
            if(this.Order == null) {

                this.Order = Int32.MinValue;

            } else {


            }
        }
        else if (this.Order != null && ec.Excludes("order",true))
        {
            this.Order = null;
        }
    }


    #endregion

    } // class FailoverClusterNodeOrder
    
    #endregion

    public static class ListFailoverClusterNodeOrderExtensions
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
            this List<FailoverClusterNodeOrder> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterNodeOrder> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterNodeOrder> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterNodeOrder());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterNodeOrder> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types