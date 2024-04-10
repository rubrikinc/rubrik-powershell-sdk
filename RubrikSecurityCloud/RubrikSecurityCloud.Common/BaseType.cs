using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public abstract class BaseType : IFieldSpec
    {
        // Composite field spec support:
        // _next is the pointer to next object in chain.
        // Used for building up a chain of objects
        // to represent a "composite field spec".
        internal BaseType? _next = null;
        public BaseType? GetNext() => _next;
        public void SetNext(BaseType? next) => _next = next;
        public bool IsComposite() => _next != null;
        public int CompositeLength()
        {
            int len = 1;
            BaseType? next = _next;
            while (next != null)
            {
                len++;
                next = next._next;
            }
            return len;
        }

        /// <summary>
        /// Convert the composite object to a list of objects.
        /// If the object is not composite, return a list with a single item.
        /// Objects are not copied: modifiying the list elements
        /// will modify the original object.
        /// </summary>
        public RscList<BaseType> AsList()
        {
            RscList<BaseType> list = new RscList<BaseType>();
            BaseType? next = this;
            while (next != null)
            {
                list.Add(next);
                next = next._next;
            }
            return list;
        }

        /// <summary>
        /// Filter the composite object by type.
        /// </summary>
        public RscList<BaseType> WhereType(Type type) => this.AsList().WhereType(type);

        // IFieldSpec interface:
        public abstract string AsFieldSpec(FieldSpecConfig? conf = null);

        public virtual List<string> SelectedFields()
        {
            return StringUtils.FieldSpecStringToList(
                this.AsFieldSpec(new FieldSpecConfig { Flat = true }));
                    
        }

        public virtual List<string> AllFields(int maxDepth = 0)
        {
            var fields = StringUtils.FlattenFieldToFieldSpecList(
                ReflectionUtils.FlattenFieldFull(this.GetType().FullName));
            if (maxDepth <= 0)
            {
                return fields;
            }
            else
            {
                return fields.Select(f => 
                    f.Split('.').Take(maxDepth).Aggregate((a, b) => a + "." + b)).Distinct().ToList();
            }
        }

        public List<string> UnselectedFields()
        {
            return StringUtils.BuildUnselectedList(
                this.AllFields(), this.SelectedFields());
        }


        public abstract void ApplyExploratoryFieldSpec(ExplorationContext ec);
        public void SelectForRetrieval()
        {
            this.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
        // Returns the name of the type as it would appear in a GraphQL schema.
        // Should be overridden if the GraphQL type name is different from 
        // the C# class name.
        public virtual string GetGqlTypeName()
        {
            return this.GetType().Name;
        }
    }

    public static class ListBaseTypeExtensions
    {
        public static string AsFieldSpec(this List<BaseType> list,
                                         FieldSpecConfig? conf = null)
        {
            conf = (conf == null) ? new FieldSpecConfig() : conf;
            string ind = conf.IndentStr();
            StringBuilder sb = new StringBuilder();
            foreach (BaseType item in list)
            {
                string fs = item.AsFieldSpec(conf.Child(ignoreComposition:true));
                if (conf.Flat)
                {
                    sb.Append(fs);
                }
                else
                {
                    var fragment = " ... on " + item.GetType().Name;
                    if (fs.Length > 0)
                    {
                        sb.Append(ind + fragment + " {\n" + fs + ind + "}\n");
                    }
                    else
                    {
                        sb.Append(ind + "#" + fragment + " {}\n");
                    }
                }
            }
            return sb.ToString();
        }

        public static List<string> SelectedFields(this List<BaseType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }

        // public static List<string> AllFields(this List<BaseType> list)
        // {
        //     return list.SelectMany(item => item.AllFields()).ToList()
        //         .Distinct().OrderBy(s => s).ToList();
        // }

        // public static List<string> UnselectedFields(this List<BaseType> list)
        // {
        //     return StringUtils.BuildUnselectedList(
        //         list.AllFields(), list.SelectedFields());
        // }

        public static void ApplyExploratoryFieldSpec(
            this List<BaseType> list,
            ExplorationContext ec)
        {
            foreach (BaseType item in list)
            {
                item.ApplyExploratoryFieldSpec(ec);
            }
        }

        public static void SelectForRetrieval(this List<BaseType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }

    public class RscList<T>: List<T>
    {
        public RscList(): base() { }
        public RscList(IEnumerable<T> collection): base(collection) { }

        // This would be great but PowerShell doesn't directly support
        // calling generic methods with type parameters, so you'd have to do:
        // $lType = $list.GetType()
        // $whereTypeMethodGeneric = $lType.GetMethod("WhereType").MakeGenericMethod([RubrikSecurityCloud.Types.GlobalSlaReply])
        // $result = $whereTypeMethodGeneric.Invoke($l, @())
        // which is pretty ugly.
        // public RscList<S> WhereType<S>()
        // {
        //     var filteredItems = this.Where(item => item is S).Cast<S>();
        //     return new RscList<S>(filteredItems);
        // }

        /// <summary>
        /// Filter the list by type.
        /// </summary>
        public RscList<T> WhereType(Type type) =>
            new RscList<T>(
                this.Where(item => item != null && item.GetType() == type));

        /// <summary>
        /// Filter the list by type.
        /// </summary>
        public RscList<T> WhereType(string typeName) =>
            new RscList<T>(
                this.Where(item => item != null && item.GetType().Name.ToLower() == typeName.ToLower()));


        /// <summary>
        /// Return the set of unique types in the list.
        /// </summary>
        public HashSet<Type> DistinctTypes() =>
            new HashSet<Type>(
                this.Select(item => item?.GetType()).Where(type => type != null).Cast<Type>());
    }
}
