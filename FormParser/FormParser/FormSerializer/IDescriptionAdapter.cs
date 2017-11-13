using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormParser
{
    public delegate void PropertyDecoder(object description, object target, string propertyName);

    public interface IDescriptionAdapter
    {
        string GetObjectClassName(object description);
        string GetObjectValue(object description);
        object GetObjectProperty(object description, string propertyName, params object[] tags);
        int? GetIntProperty(object description, string propertyName, params object[] tags);
        long? GetLongProperty(object description, string propertyName, params object[] tags);
        double? GetDoubleProperty(object description, string propertyName);
        string GetStringProperty(object description, string propertyName, params object[] tags);
        T GetEnumProperty<T>(object description, string propertyName, params object[] tags);
        bool? GetBoolProperty(object description, string propertyName, params object[] tags);
        IEnumerable GetArrayProperty(object description, string propertyName, params object[] tags);
        void ReadProperties(object description, object target, Dictionary<string, PropertyDecoder> propDecoders);
    }
}
