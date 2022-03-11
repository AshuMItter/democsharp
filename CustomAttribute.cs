using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace DemoOne.Demos
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true,Inherited =true)]
    class PermissionAttribute : System.Attribute
    {
        public PermissionAttribute(string permison)
        {
            Permision = permison;
        }

        public string Permision { get; set; }
    }

    
   

    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true,Inherited =false)]
    class CustomAttribute : System.Attribute
    { 
        public CustomAttribute(string permission)
        {
            Permission = permission;
        }
        public string Permission { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    class CustomPropertyAttribute : System.Attribute
    {
        public CustomPropertyAttribute(string value)
        {
            Param = value;
        }
        public string Param { get; set; }
    }

    [Custom("User")]
    class MyClass
    {
        [CustomProperty("SOmething Else")]
        public int MyProperty { get; set; }

        [CustomProperty("Not Admin")]
        public int YourPropert { get; set; }
        public void DemoMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
    class Demo
    {
        public void GettingTheAttibuteOnClass()
        {

            var attr = typeof(MyClass).GetCustomAttribute(typeof(CustomAttribute), true);

          CustomAttribute attr1  =(CustomAttribute)typeof(MyClass).GetCustomAttribute(typeof(CustomAttribute), true);

            Console.WriteLine(attr1.Permission);
           
            var customAttributes = (CustomAttribute[])typeof(MyClass).GetCustomAttributes(typeof(CustomAttribute), true);
            if (customAttributes.Length > 0)
            {
                var myAttribute = customAttributes[0];
                string value = myAttribute.Permission;
                // TODO: Do something with the value
                Console.WriteLine(value);
            }



        }  
        public void GettingTheAttributeOnProperty()
        {
            PropertyInfo propertyInfo = typeof(MyClass).GetProperty("MyProperty");
            object[] attribute = propertyInfo.GetCustomAttributes(typeof(CustomPropertyAttribute), true);
            if (attribute.Length > 0)
            {
                

                CustomPropertyAttribute myAttribute = (CustomPropertyAttribute) attribute[0];
                string propertyValue = myAttribute.Param;
                Console.WriteLine(propertyValue);
            }
        }


        }
    }

