// SlaUpgrade.cs
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
    #region SlaUpgrade
    public class SlaUpgrade: BaseType
    {
        #region members

        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        [JsonProperty("status")]
        public SlaMigrationStatus? Status { get; set; }

        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        [JsonProperty("msg")]
        public System.String? Msg { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaUpgrade";
    }

    public SlaUpgrade Set(
        SlaMigrationStatus? Status = null,
        System.String? Msg = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Msg != null ) {
            this.Msg = Msg;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        if (this.Msg != null) {
            if (conf.Flat) {
                s += conf.Prefix + "msg\n" ;
            } else {
                s += ind + "msg\n" ;
            }
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskchainId\n" ;
            } else {
                s += ind + "taskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SlaMigrationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        if (ec.Includes("msg",true))
        {
            if(this.Msg == null) {

                this.Msg = "FETCH";

            } else {


            }
        }
        else if (this.Msg != null && ec.Excludes("msg",true))
        {
            this.Msg = null;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (ec.Includes("taskchainId",true))
        {
            if(this.TaskchainId == null) {

                this.TaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.TaskchainId != null && ec.Excludes("taskchainId",true))
        {
            this.TaskchainId = null;
        }
    }


    #endregion

    } // class SlaUpgrade
    
    #endregion

    public static class ListSlaUpgradeExtensions
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
            this List<SlaUpgrade> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaUpgrade> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgrade> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgrade());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaUpgrade> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types