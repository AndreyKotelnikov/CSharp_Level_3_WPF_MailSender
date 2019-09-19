using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestMailSender
{
    [TestFixture]
    public class ShapeTest
    {
        [Test]
        public void AllIntersectsMustBeRealized()
        {
            var shapeTypes = typeof(Shape).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(Shape)));

            var errorMessages = new List<string>();

            foreach (var firstType in shapeTypes)
                foreach (var secondType in shapeTypes)
                {
                    if (MethodFinder.Find(firstType, "FindIntersection", secondType) == null)
                    {
                        errorMessages.Add(string.Format("Не удалось найти метод для поиска пересечения фигур: {0} и {1}", firstType.Name, secondType.Name));
                    }
                }

            if (errorMessages.Any())
                throw new Exception(string.Join("\r\n", errorMessages));
        }
    }

    public static class MethodFinder
    {
        public static MethodInfo Find(Type classType, string functionName, Type parameterType)
        {
            return
                classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .FirstOrDefault(
                    x => x.Name == functionName
                    && x.GetParameters().Count() == 1
                    && x.GetParameters().First().ParameterType == parameterType);
        }
    }

    public class Shape
    {
        public Shape FindIntersection(Shape shape)
        {
            var method = MethodFinder.Find(this.GetType(), "FindIntersection", shape.GetType());

            if (method != null)
            {
                return (Shape)method.Invoke(this, new[] { shape });
            }

            return shape.FindIntersection(this);
        }
    }
}
