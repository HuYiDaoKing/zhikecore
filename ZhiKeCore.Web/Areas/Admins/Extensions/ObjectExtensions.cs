using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhiKeCore.Web.Areas.Admins.Extensions
{
    public static class ObjectExtensions
    {
        public static Object AsJson(this Object model)
        {
            Hashtable json = new Hashtable();

            var properties = model.GetType().GetProperties();
            
            foreach (var property in properties)
            {
                var key = property.Name;
                var value = property.GetValue(model);

                json.Add(key, value == null ? string.Empty : value.ToString());
                //if (value != null)
                //{
                //    json.Add(key,value);
                //}
            }

            return json;
        }
    }
}
