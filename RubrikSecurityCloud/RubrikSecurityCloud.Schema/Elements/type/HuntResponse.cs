// HuntResponse.cs
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
    #region HuntResponse
    public class HuntResponse: BaseType
    {
        #region members

        //      C# -> HuntTriggerStatus? Status
        // GraphQL -> status: HuntTriggerStatus! (enum)
        [JsonProperty("status")]
        public HuntTriggerStatus? Status { get; set; }

        //      C# -> System.String? HuntId
        // GraphQL -> huntId: UUID (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        [JsonProperty("huntName")]
        public System.String? HuntName { get; set; }

        //      C# -> HuntConfig? Config
        // GraphQL -> config: HuntConfig (type)
        [JsonProperty("config")]
        public HuntConfig? Config { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HuntResponse";
    }

    public HuntResponse Set(
        HuntTriggerStatus? Status = null,
        System.String? HuntId = null,
        System.String? HuntName = null,
        HuntConfig? Config = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( HuntName != null ) {
            this.HuntName = HuntName;
        }
        if ( Config != null ) {
            this.Config = Config;
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
        //      C# -> HuntTriggerStatus? Status
        // GraphQL -> status: HuntTriggerStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: UUID (scalar)
        if (this.HuntId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntId\n" ;
            } else {
                s += ind + "huntId\n" ;
            }
        }
        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        if (this.HuntName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntName\n" ;
            } else {
                s += ind + "huntName\n" ;
            }
        }
        //      C# -> HuntConfig? Config
        // GraphQL -> config: HuntConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HuntTriggerStatus? Status
        // GraphQL -> status: HuntTriggerStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HuntTriggerStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: UUID (scalar)
        if (ec.Includes("huntId",true))
        {
            if(this.HuntId == null) {

                this.HuntId = "FETCH";

            } else {


            }
        }
        else if (this.HuntId != null && ec.Excludes("huntId",true))
        {
            this.HuntId = null;
        }
        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        if (ec.Includes("huntName",true))
        {
            if(this.HuntName == null) {

                this.HuntName = "FETCH";

            } else {


            }
        }
        else if (this.HuntName != null && ec.Excludes("huntName",true))
        {
            this.HuntName = null;
        }
        //      C# -> HuntConfig? Config
        // GraphQL -> config: HuntConfig (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new HuntConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
    }


    #endregion

    } // class HuntResponse
    
    #endregion

    public static class ListHuntResponseExtensions
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
            this List<HuntResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HuntResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HuntResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HuntResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HuntResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types