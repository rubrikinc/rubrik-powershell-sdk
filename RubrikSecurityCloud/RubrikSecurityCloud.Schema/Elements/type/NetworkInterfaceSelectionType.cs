// NetworkInterfaceSelectionType.cs
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
    #region NetworkInterfaceSelectionType
    public class NetworkInterfaceSelectionType: BaseType
    {
        #region members

        //      C# -> System.String? SourceInterfaceName
        // GraphQL -> sourceInterfaceName: String! (scalar)
        [JsonProperty("sourceInterfaceName")]
        public System.String? SourceInterfaceName { get; set; }

        //      C# -> System.String? TargetInterfaceName
        // GraphQL -> targetInterfaceName: String! (scalar)
        [JsonProperty("targetInterfaceName")]
        public System.String? TargetInterfaceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkInterfaceSelectionType";
    }

    public NetworkInterfaceSelectionType Set(
        System.String? SourceInterfaceName = null,
        System.String? TargetInterfaceName = null
    ) 
    {
        if ( SourceInterfaceName != null ) {
            this.SourceInterfaceName = SourceInterfaceName;
        }
        if ( TargetInterfaceName != null ) {
            this.TargetInterfaceName = TargetInterfaceName;
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
        //      C# -> System.String? SourceInterfaceName
        // GraphQL -> sourceInterfaceName: String! (scalar)
        if (this.SourceInterfaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceInterfaceName\n" ;
            } else {
                s += ind + "sourceInterfaceName\n" ;
            }
        }
        //      C# -> System.String? TargetInterfaceName
        // GraphQL -> targetInterfaceName: String! (scalar)
        if (this.TargetInterfaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetInterfaceName\n" ;
            } else {
                s += ind + "targetInterfaceName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? SourceInterfaceName
        // GraphQL -> sourceInterfaceName: String! (scalar)
        if (ec.Includes("sourceInterfaceName",true))
        {
            if(this.SourceInterfaceName == null) {

                this.SourceInterfaceName = "FETCH";

            } else {


            }
        }
        else if (this.SourceInterfaceName != null && ec.Excludes("sourceInterfaceName",true))
        {
            this.SourceInterfaceName = null;
        }
        //      C# -> System.String? TargetInterfaceName
        // GraphQL -> targetInterfaceName: String! (scalar)
        if (ec.Includes("targetInterfaceName",true))
        {
            if(this.TargetInterfaceName == null) {

                this.TargetInterfaceName = "FETCH";

            } else {


            }
        }
        else if (this.TargetInterfaceName != null && ec.Excludes("targetInterfaceName",true))
        {
            this.TargetInterfaceName = null;
        }
    }


    #endregion

    } // class NetworkInterfaceSelectionType
    
    #endregion

    public static class ListNetworkInterfaceSelectionTypeExtensions
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
            this List<NetworkInterfaceSelectionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NetworkInterfaceSelectionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkInterfaceSelectionType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkInterfaceSelectionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkInterfaceSelectionType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types