// HypervScvmmSummary.cs
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
    #region HypervScvmmSummary
    public class HypervScvmmSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        [JsonProperty("runAsAccount")]
        public System.String? RunAsAccount { get; set; }

        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        [JsonProperty("scvmmVersion")]
        public System.String? ScvmmVersion { get; set; }

        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        [JsonProperty("shouldDeployAgent")]
        public System.Boolean? ShouldDeployAgent { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervScvmmSummary";
    }

    public HypervScvmmSummary Set(
        System.String? Id = null,
        System.String? PrimaryClusterId = null,
        System.String? RunAsAccount = null,
        System.String? ScvmmVersion = null,
        System.Boolean? ShouldDeployAgent = null,
        System.String? Status = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( RunAsAccount != null ) {
            this.RunAsAccount = RunAsAccount;
        }
        if ( ScvmmVersion != null ) {
            this.ScvmmVersion = ScvmmVersion;
        }
        if ( ShouldDeployAgent != null ) {
            this.ShouldDeployAgent = ShouldDeployAgent;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        if (this.RunAsAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runAsAccount\n" ;
            } else {
                s += ind + "runAsAccount\n" ;
            }
        }
        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        if (this.ScvmmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scvmmVersion\n" ;
            } else {
                s += ind + "scvmmVersion\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        if (this.ShouldDeployAgent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldDeployAgent\n" ;
            } else {
                s += ind + "shouldDeployAgent\n" ;
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
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        if (ec.Includes("runAsAccount",true))
        {
            if(this.RunAsAccount == null) {

                this.RunAsAccount = "FETCH";

            } else {


            }
        }
        else if (this.RunAsAccount != null && ec.Excludes("runAsAccount",true))
        {
            this.RunAsAccount = null;
        }
        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        if (ec.Includes("scvmmVersion",true))
        {
            if(this.ScvmmVersion == null) {

                this.ScvmmVersion = "FETCH";

            } else {


            }
        }
        else if (this.ScvmmVersion != null && ec.Excludes("scvmmVersion",true))
        {
            this.ScvmmVersion = null;
        }
        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        if (ec.Includes("shouldDeployAgent",true))
        {
            if(this.ShouldDeployAgent == null) {

                this.ShouldDeployAgent = true;

            } else {


            }
        }
        else if (this.ShouldDeployAgent != null && ec.Excludes("shouldDeployAgent",true))
        {
            this.ShouldDeployAgent = null;
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
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class HypervScvmmSummary
    
    #endregion

    public static class ListHypervScvmmSummaryExtensions
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
            this List<HypervScvmmSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervScvmmSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervScvmmSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types