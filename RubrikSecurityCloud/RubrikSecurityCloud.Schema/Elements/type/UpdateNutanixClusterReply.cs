// UpdateNutanixClusterReply.cs
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
    #region UpdateNutanixClusterReply
    public class UpdateNutanixClusterReply: BaseType
    {
        #region members

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        [JsonProperty("nutanixClusterSummary")]
        public NutanixClusterSummary? NutanixClusterSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateNutanixClusterReply";
    }

    public UpdateNutanixClusterReply Set(
        System.String? CaCerts = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        NutanixClusterSummary? NutanixClusterSummary = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( NutanixClusterSummary != null ) {
            this.NutanixClusterSummary = NutanixClusterSummary;
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
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        if (this.CaCerts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCerts\n" ;
            } else {
                s += ind + "caCerts\n" ;
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        if (this.NutanixClusterSummary != null) {
            var fspec = this.NutanixClusterSummary.AsFieldSpec(conf.Child("nutanixClusterSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixClusterSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String! (scalar)
        if (ec.Includes("caCerts",true))
        {
            if(this.CaCerts == null) {

                this.CaCerts = "FETCH";

            } else {


            }
        }
        else if (this.CaCerts != null && ec.Excludes("caCerts",true))
        {
            this.CaCerts = null;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> NutanixClusterSummary? NutanixClusterSummary
        // GraphQL -> nutanixClusterSummary: NutanixClusterSummary (type)
        if (ec.Includes("nutanixClusterSummary",false))
        {
            if(this.NutanixClusterSummary == null) {

                this.NutanixClusterSummary = new NutanixClusterSummary();
                this.NutanixClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClusterSummary"));

            } else {

                this.NutanixClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClusterSummary"));

            }
        }
        else if (this.NutanixClusterSummary != null && ec.Excludes("nutanixClusterSummary",false))
        {
            this.NutanixClusterSummary = null;
        }
    }


    #endregion

    } // class UpdateNutanixClusterReply
    
    #endregion

    public static class ListUpdateNutanixClusterReplyExtensions
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
            this List<UpdateNutanixClusterReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateNutanixClusterReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNutanixClusterReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNutanixClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateNutanixClusterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types