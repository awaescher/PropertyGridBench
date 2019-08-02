using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraVerticalGrid.Data;
using DevExpress.XtraVerticalGrid.Events;

namespace PropertyGridBench
{
	public class PropertyGridControlEx : DevExpress.XtraVerticalGrid.PropertyGridControl
	{
		public PropertyGridControlEx()
			: base()
		{
		}

		protected override void RaiseCustomPropertyDescriptors(CustomPropertyDescriptorsEventArgs e)
		{
			e.Properties = GetAllProperties(e.Source, e.Attributes);
		}

		public static PropertyDescriptorCollection GetAllProperties(object component, Attribute[] attributes)
		{
			if (component == null || component.GetType().IsPrimitive || component is string)
				return GetProperties(new ArrayList());

			Type type = component.GetType();
			Hashtable hashtable = new Hashtable();
			int num = 1;

			while (true)
			{
				PropertyInfo[] properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod);
				AddPropertyDescriptors(properties, hashtable, component, type, false);
				PropertyInfo[] properties2 = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod);
				AddPropertyDescriptors(properties2, hashtable, component, type, true);

				if (type == typeof(object))
					break;

				type = type.BaseType;
				num++;
			}

			return GetProperties(hashtable.Values);
		}

		public static PropertyDescriptorCollection GetProperties(ICollection properties)
		{
			ArrayList arrayList = new ArrayList(properties);
			return new PropertyDescriptorCollection((PropertyDescriptor[])arrayList.ToArray(typeof(PropertyDescriptor)));
		}

		private static void AddPropertyDescriptors(PropertyInfo[] propInfos, Hashtable list, object component, Type type, bool areStatic)
		{
			for (int i = 0; i < propInfos.Length; i++)
			{
				try
				{
					PropertyInfo propertyInfo = propInfos[i];
					if (!list.ContainsKey(propertyInfo.Name))
						list.Add(propertyInfo.Name, new CustomPropertyDescriptor(propertyInfo, type));
				}
				catch (Exception ex)
				{
				}
			}
		}
	}

	public class CustomPropertyDescriptor : PropertyDescriptor
	{
		private PropertyInfo _propertyInfo;
		private Type _type;

		public CustomPropertyDescriptor(PropertyInfo propertyInfo, Type type)
			: base(propertyInfo.Name, null)
		{
			_propertyInfo = propertyInfo;
			_type = type;
		}

		public override Type ComponentType => _propertyInfo.PropertyType;

		public override bool IsReadOnly => !_propertyInfo.CanWrite;

		public override Type PropertyType => _propertyInfo.PropertyType;

		public override bool CanResetValue(object component) => false;

		public override object GetValue(object component)
		{
			Thread.Sleep(5);
			return _propertyInfo.GetValue(component, null);
		}

		public override void ResetValue(object component) { }

		public override void SetValue(object component, object value) => _propertyInfo.SetValue(component, value, null);

		public override bool ShouldSerializeValue(object component) => false;
	}
}
