global using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace assignment2._2__Unit_tests
{
	[TestClass]
	public static class SkydaTestBase
	{

		public static bool HasProperty(this Type obj, string propertyName)
		{
			return obj.GetProperty(propertyName) != null;
		}

		public static Type TypeOfProperty(this Type obj, string propertyName)
		{
			var property = obj.GetProperty(propertyName);
			return property.PropertyType;
		}

		public static bool HasMethod(this Type obj, string methodName)
		{
			return obj.GetMethod(methodName) != null;
		}
	}
}