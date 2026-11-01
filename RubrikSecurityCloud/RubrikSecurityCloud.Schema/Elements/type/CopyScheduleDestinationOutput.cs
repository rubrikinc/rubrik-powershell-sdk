// CopyScheduleDestinationOutput.cs
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
    #region CopyScheduleDestinationOutput
    public class CopyScheduleDestinationOutput: BaseType
    {
        #region members

        //      C# -> System.String? DestinationShareId
        // GraphQL -> destinationShareId: UUID (scalar)
        [JsonProperty("destinationShareId")]
        public System.String? DestinationShareId { get; set; }

        //      C# -> CopyScheduleCloudTarget? CloudTarget
        // GraphQL -> cloudTarget: CopyScheduleCloudTarget (type)
        [JsonProperty("cloudTarget")]
        public CopyScheduleCloudTarget? CloudTarget { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CopyScheduleDestinationOutput";
    }

    public CopyScheduleDestinationOutput Set(
        System.String? DestinationShareId = null,
        CopyScheduleCloudTarget? CloudTarget = null
    ) 
    {
        if ( DestinationShareId != null ) {
            this.DestinationShareId = DestinationShareId;
        }
        if ( CloudTarget != null ) {
            this.CloudTarget = CloudTarget;
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
        //      C# -> System.String? DestinationShareId
        // GraphQL -> destinationShareId: UUID (scalar)
        if (this.DestinationShareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationShareId\n" ;
            } else {
                s += ind + "destinationShareId\n" ;
            }
        }
        //      C# -> CopyScheduleCloudTarget? CloudTarget
        // GraphQL -> cloudTarget: CopyScheduleCloudTarget (type)
        if (this.CloudTarget != null) {
            var fspec = this.CloudTarget.AsFieldSpec(conf.Child("cloudTarget"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudTarget" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DestinationShareId
        // GraphQL -> destinationShareId: UUID (scalar)
        if (ec.Includes("destinationShareId",true))
        {
            if(this.DestinationShareId == null) {

                this.DestinationShareId = "FETCH";

            } else {


            }
        }
        else if (this.DestinationShareId != null && ec.Excludes("destinationShareId",true))
        {
            this.DestinationShareId = null;
        }
        //      C# -> CopyScheduleCloudTarget? CloudTarget
        // GraphQL -> cloudTarget: CopyScheduleCloudTarget (type)
        if (ec.Includes("cloudTarget",false))
        {
            if(this.CloudTarget == null) {

                this.CloudTarget = new CopyScheduleCloudTarget();
                this.CloudTarget.ApplyExploratoryFieldSpec(ec.NewChild("cloudTarget"));

            } else {

                this.CloudTarget.ApplyExploratoryFieldSpec(ec.NewChild("cloudTarget"));

            }
        }
        else if (this.CloudTarget != null && ec.Excludes("cloudTarget",false))
        {
            this.CloudTarget = null;
        }
    }


    #endregion

    } // class CopyScheduleDestinationOutput
    
    #endregion

    public static class ListCopyScheduleDestinationOutputExtensions
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
            this List<CopyScheduleDestinationOutput> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CopyScheduleDestinationOutput> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CopyScheduleDestinationOutput> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CopyScheduleDestinationOutput());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CopyScheduleDestinationOutput> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types