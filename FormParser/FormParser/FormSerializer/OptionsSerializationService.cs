using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using FormParser.Attributes;

namespace FormParser
{
    public class OptionsSerializationService
    {
        public bool SerializeDefaultValues { get; set; }

        public IDescriptionBuilder Builder { get; set; }

        public static readonly Dictionary<string, PropertyEncoder> ExtentionsSerializers =
            new Dictionary<string, PropertyEncoder>();

        public OptionsSerializationService(IDescriptionBuilder builder)
        {
            Builder = builder;
        }

        public void EncodeObject(object handle, object objToEncode)
        {
            Builder.WriteProperty(handle, "ClassName", objToEncode.GetType().Name);

            var properties = objToEncode
                .GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                        .Where(p => p.GetCustomAttributes(typeof(IgnoreSerializationAttribute), false).Length == 0);
            
            foreach (var propertyInfo in properties)
            {
                var propertyValue = propertyInfo.GetValue(objToEncode, null);

                PropertyEncoder objToStrFunc;
                if ((ExtentionsSerializers.TryGetValue(propertyInfo.PropertyType.Name, out objToStrFunc) || // special serialization string for object
                    propertyInfo.PropertyType.IsValueType || 
                    propertyInfo.PropertyType.IsEnum || 
                    propertyInfo.PropertyType == typeof(string))) 
                {
                    if (objToStrFunc != null)
                    {
                        objToStrFunc(handle, propertyValue, propertyInfo.Name);
                    }
                    else
                    {
                        var objHandle =
                            Builder.BeginObjectProperty(handle, propertyInfo.Name, propertyValue.ToString());

                        Builder.EndObjectProperty(objHandle);
                    }
                }
                else if (propertyInfo.PropertyType.IsArray)
                {
                    var array = (Array)propertyValue;
                    foreach (var item in array)
                    {
                        var arrayHandle = Builder.BeginObjectProperty(handle, propertyInfo.Name);
                        {
                            EncodeObject(arrayHandle, item);
                        }
                        Builder.EndObjectProperty(arrayHandle);
                    }
                }
                else if (propertyInfo.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
                {
                    var array = (IEnumerable)propertyValue;
                    foreach (var item in array)
                    {
                        var arrayHandle = Builder.BeginObjectProperty(handle, propertyInfo.Name);
                        {
                            EncodeObject(arrayHandle, item);
                        }
                        Builder.EndObjectProperty(arrayHandle);
                    }
                }
                else 
                {
                    var innerObj = propertyValue;
                    var innerObjHandle = Builder.BeginObjectProperty(handle, propertyInfo.Name);
                    {
                        EncodeObject(innerObjHandle, innerObj);
                    }
                    Builder.EndObjectProperty(innerObjHandle);
                }
            }
        }
    }
}
