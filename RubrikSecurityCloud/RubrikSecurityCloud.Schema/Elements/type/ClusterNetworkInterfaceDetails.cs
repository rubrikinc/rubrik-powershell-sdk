// ClusterNetworkInterfaceDetails.cs
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
    #region ClusterNetworkInterfaceDetails
    public class ClusterNetworkInterfaceDetails: BaseType
    {
        #region members

        //      C# -> System.String? InterfaceDisplayName
        // GraphQL -> interfaceDisplayName: String! (scalar)
        [JsonProperty("interfaceDisplayName")]
        public System.String? InterfaceDisplayName { get; set; }

        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        [JsonProperty("interfaceName")]
        public System.String? InterfaceName { get; set; }

        //      C# -> System.String? InterfaceType
        // GraphQL -> interfaceType: String! (scalar)
        [JsonProperty("interfaceType")]
        public System.String? InterfaceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNetworkInterfaceDetails";
    }

    public ClusterNetworkInterfaceDetails Set(
        System.String? InterfaceDisplayName = null,
        System.String? InterfaceName = null,
        System.String? InterfaceType = null
    ) 
    {
        if ( InterfaceDisplayName != null ) {
            this.InterfaceDisplayName = InterfaceDisplayName;
        }
        if ( InterfaceName != null ) {
            this.InterfaceName = InterfaceName;
        }
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
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
        //      C# -> System.String? InterfaceDisplayName
        // GraphQL -> interfaceDisplayName: String! (scalar)
        if (this.InterfaceDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceDisplayName\n" ;
            } else {
                s += ind + "interfaceDisplayName\n" ;
            }
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceName\n" ;
            } else {
                s += ind + "interfaceName\n" ;
            }
        }
        //      C# -> System.String? InterfaceType
        // GraphQL -> interfaceType: String! (scalar)
        if (this.InterfaceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceType\n" ;
            } else {
                s += ind + "interfaceType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? InterfaceDisplayName
        // GraphQL -> interfaceDisplayName: String! (scalar)
        if (ec.Includes("interfaceDisplayName",true))
        {
            if(this.InterfaceDisplayName == null) {

                this.InterfaceDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.InterfaceDisplayName != null && ec.Excludes("interfaceDisplayName",true))
        {
            this.InterfaceDisplayName = null;
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (ec.Includes("interfaceName",true))
        {
            if(this.InterfaceName == null) {

                this.InterfaceName = "FETCH";

            } else {


            }
        }
        else if (this.InterfaceName != null && ec.Excludes("interfaceName",true))
        {
            this.InterfaceName = null;
        }
        //      C# -> System.String? InterfaceType
        // GraphQL -> interfaceType: String! (scalar)
        if (ec.Includes("interfaceType",true))
        {
            if(this.InterfaceType == null) {

                this.InterfaceType = "FETCH";

            } else {


            }
        }
        else if (this.InterfaceType != null && ec.Excludes("interfaceType",true))
        {
            this.InterfaceType = null;
        }
    }


    #endregion

    } // class ClusterNetworkInterfaceDetails
    
    #endregion

    public static class ListClusterNetworkInterfaceDetailsExtensions
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
            this List<ClusterNetworkInterfaceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterNetworkInterfaceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNetworkInterfaceDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNetworkInterfaceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNetworkInterfaceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types