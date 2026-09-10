// HypervStandaloneTarget.cs
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
    #region HypervStandaloneTarget
    public class HypervStandaloneTarget: BaseType
    {
        #region members

        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        [JsonProperty("exportPath")]
        public System.String? ExportPath { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> List<HypervStandaloneNicSpec>? Nics
        // GraphQL -> nics: [HypervStandaloneNicSpec!]! (type)
        [JsonProperty("nics")]
        public List<HypervStandaloneNicSpec>? Nics { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervStandaloneTarget";
    }

    public HypervStandaloneTarget Set(
        System.String? ExportPath = null,
        System.String? HostId = null,
        System.String? HostName = null,
        List<HypervStandaloneNicSpec>? Nics = null
    ) 
    {
        if ( ExportPath != null ) {
            this.ExportPath = ExportPath;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Nics != null ) {
            this.Nics = Nics;
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
        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        if (this.ExportPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportPath\n" ;
            } else {
                s += ind + "exportPath\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> List<HypervStandaloneNicSpec>? Nics
        // GraphQL -> nics: [HypervStandaloneNicSpec!]! (type)
        if (this.Nics != null) {
            var fspec = this.Nics.AsFieldSpec(conf.Child("nics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        if (ec.Includes("exportPath",true))
        {
            if(this.ExportPath == null) {

                this.ExportPath = "FETCH";

            } else {


            }
        }
        else if (this.ExportPath != null && ec.Excludes("exportPath",true))
        {
            this.ExportPath = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> List<HypervStandaloneNicSpec>? Nics
        // GraphQL -> nics: [HypervStandaloneNicSpec!]! (type)
        if (ec.Includes("nics",false))
        {
            if(this.Nics == null) {

                this.Nics = new List<HypervStandaloneNicSpec>();
                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            } else {

                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            }
        }
        else if (this.Nics != null && ec.Excludes("nics",false))
        {
            this.Nics = null;
        }
    }


    #endregion

    } // class HypervStandaloneTarget
    
    #endregion

    public static class ListHypervStandaloneTargetExtensions
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
            this List<HypervStandaloneTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervStandaloneTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervStandaloneTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervStandaloneTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervStandaloneTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types