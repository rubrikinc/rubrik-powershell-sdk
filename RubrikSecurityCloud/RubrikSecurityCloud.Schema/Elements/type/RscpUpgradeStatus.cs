// RscpUpgradeStatus.cs
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
    #region RscpUpgradeStatus
    public class RscpUpgradeStatus: BaseType
    {
        #region members

        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        [JsonProperty("rscClusterUpgradeStatus")]
        public RscUpgradeStatusType? RscClusterUpgradeStatus { get; set; }

        //      C# -> DateTime? StatusGenTimestamp
        // GraphQL -> statusGenTimestamp: DateTime (scalar)
        [JsonProperty("statusGenTimestamp")]
        public DateTime? StatusGenTimestamp { get; set; }

        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        [JsonProperty("uiStatus")]
        public System.String? UiStatus { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes (type)
        [JsonProperty("uiStatusAttributes")]
        public UiStatusAttributes? UiStatusAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscpUpgradeStatus";
    }

    public RscpUpgradeStatus Set(
        RscUpgradeStatusType? RscClusterUpgradeStatus = null,
        DateTime? StatusGenTimestamp = null,
        System.String? UiStatus = null,
        System.String? Version = null,
        UiStatusAttributes? UiStatusAttributes = null
    ) 
    {
        if ( RscClusterUpgradeStatus != null ) {
            this.RscClusterUpgradeStatus = RscClusterUpgradeStatus;
        }
        if ( StatusGenTimestamp != null ) {
            this.StatusGenTimestamp = StatusGenTimestamp;
        }
        if ( UiStatus != null ) {
            this.UiStatus = UiStatus;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( UiStatusAttributes != null ) {
            this.UiStatusAttributes = UiStatusAttributes;
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
        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        if (this.RscClusterUpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscClusterUpgradeStatus\n" ;
            } else {
                s += ind + "rscClusterUpgradeStatus\n" ;
            }
        }
        //      C# -> DateTime? StatusGenTimestamp
        // GraphQL -> statusGenTimestamp: DateTime (scalar)
        if (this.StatusGenTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusGenTimestamp\n" ;
            } else {
                s += ind + "statusGenTimestamp\n" ;
            }
        }
        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        if (this.UiStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uiStatus\n" ;
            } else {
                s += ind + "uiStatus\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes (type)
        if (this.UiStatusAttributes != null) {
            var fspec = this.UiStatusAttributes.AsFieldSpec(conf.Child("uiStatusAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "uiStatusAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        if (ec.Includes("rscClusterUpgradeStatus",true))
        {
            if(this.RscClusterUpgradeStatus == null) {

                this.RscClusterUpgradeStatus = new RscUpgradeStatusType();

            } else {


            }
        }
        else if (this.RscClusterUpgradeStatus != null && ec.Excludes("rscClusterUpgradeStatus",true))
        {
            this.RscClusterUpgradeStatus = null;
        }
        //      C# -> DateTime? StatusGenTimestamp
        // GraphQL -> statusGenTimestamp: DateTime (scalar)
        if (ec.Includes("statusGenTimestamp",true))
        {
            if(this.StatusGenTimestamp == null) {

                this.StatusGenTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.StatusGenTimestamp != null && ec.Excludes("statusGenTimestamp",true))
        {
            this.StatusGenTimestamp = null;
        }
        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        if (ec.Includes("uiStatus",true))
        {
            if(this.UiStatus == null) {

                this.UiStatus = "FETCH";

            } else {


            }
        }
        else if (this.UiStatus != null && ec.Excludes("uiStatus",true))
        {
            this.UiStatus = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes (type)
        if (ec.Includes("uiStatusAttributes",false))
        {
            if(this.UiStatusAttributes == null) {

                this.UiStatusAttributes = new UiStatusAttributes();
                this.UiStatusAttributes.ApplyExploratoryFieldSpec(ec.NewChild("uiStatusAttributes"));

            } else {

                this.UiStatusAttributes.ApplyExploratoryFieldSpec(ec.NewChild("uiStatusAttributes"));

            }
        }
        else if (this.UiStatusAttributes != null && ec.Excludes("uiStatusAttributes",false))
        {
            this.UiStatusAttributes = null;
        }
    }


    #endregion

    } // class RscpUpgradeStatus
    
    #endregion

    public static class ListRscpUpgradeStatusExtensions
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
            this List<RscpUpgradeStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscpUpgradeStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscpUpgradeStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscpUpgradeStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscpUpgradeStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types