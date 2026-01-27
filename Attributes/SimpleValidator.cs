using System.Reflection;

namespace Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class MyRequiredAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Property)]
public class MyStringLengthAttribute : Attribute
{
    public int MaxLength { get; }

    public MyStringLengthAttribute(int MaxLength)
    {
        this.MaxLength = MaxLength;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class MyRangeAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public MyRangeAttribute(int Min, int Max)
    {
        this.Min = Min;
        this.Max = Max;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class MyPhoneAttribute : Attribute { }

public static class SimpleValidator
{
    public static bool Validate(object obj)
    {
        Type type = obj.GetType();
        bool isValid = true;

        foreach (PropertyInfo prop in type.GetProperties())
        {
            var value = prop.GetValue(obj);

            // ПЕРЕВІРКА 1: MyRequired
            if (Attribute.IsDefined(prop, typeof(MyRequiredAttribute)))
            {
                if (value is string str && string.IsNullOrWhiteSpace(str))
                {
                    Console.WriteLine($"[Error] Поле '{prop.Name}' є обов'язковим.");
                    isValid = false;
                }
            }

            // MyStringLength
            if (Attribute.IsDefined(prop, typeof(MyStringLengthAttribute)))
            {
                var stringLengthAttr = (MyStringLengthAttribute)Attribute.GetCustomAttribute(prop, typeof(MyStringLengthAttribute));

                if (value is string str && str.Length > stringLengthAttr.MaxLength)
                {
                    Console.WriteLine($"[Error] Поле '{prop.Name}' не може бути довшим за {stringLengthAttr.MaxLength} символів.");
                    isValid = false;
                }
            }

            // MyRange
            if (Attribute.IsDefined(prop, typeof(MyRangeAttribute)))
            {
                var rangeAttr = (MyRangeAttribute)Attribute.GetCustomAttribute(prop, typeof(MyRangeAttribute));

                if (value is int num && (num < rangeAttr.Min || num > rangeAttr.Max))
                {
                    Console.WriteLine($"[Error] Поле '{prop.Name}' має бути в діапазоні від {rangeAttr.Min} до {rangeAttr.Max}.");
                    isValid = false;
                }
            }

            // MyPhone
            if (Attribute.IsDefined(prop, typeof(MyPhoneAttribute)))
            {
                if (value is string str)
                {
                    if (str.Length != 10 || str.FirstOrDefault() != '0')
                    {
                        Console.WriteLine($"[Error] Поле '{prop.Name}' має починатися з 0 та містити рівно 10 цифр.");
                        isValid = false;
                    }
                }
            }
        }
        return isValid;
    }
}
