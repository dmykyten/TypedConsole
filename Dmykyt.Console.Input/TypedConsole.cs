using System;

namespace Dmykyt.Console.Input
{
    public class TypedConsole
    {
        static public T read<T>(Func<String, T> Convert, string message = null)
        {
            if (message == null) {

                System.Console.Write("Please enter " + typeof(T).Name + ":");

            }
            else
            {
                System.Console.Write(message + ":");
            }
            var userInput = System.Console.ReadLine();
            try
            {
                return Convert(userInput);
            }
            catch
            {
                System.Console.WriteLine("Error.");
                return read<T>(Convert, message);
            }
        }

        static public T read<T>(string message = null)
        {
            switch (typeof(T).Name)
            {
                case "Boolean":
                    return (T)(object)read(Boolean.Parse, message);
                case "Byte":
                    return (T)(object)read(Byte.Parse, message);
                case "Char":
                    return (T)(object)read(Char.Parse, message);
                case "DateTime":
                    return (T)(object)read(DateTime.Parse, message);
                case "Decimal":
                    return (T)(object)read(Decimal.Parse, message);
                case "Double":
                    return (T)(object)read(Double.Parse, message);
                case "Int16":
                    return (T)(object)read(Int16.Parse, message);
                case "Int32":
                    return (T)(object)read(Int32.Parse, message);
                case "Int64":
                    return (T)(object)read(Int64.Parse, message);
                case "SByte":
                    return (T)(object)read(SByte.Parse, message);
                case "UInt16":
                    return (T)(object)read(UInt16.Parse, message);
                case "UInt32":
                    return (T)(object)read(UInt32.Parse, message);
                case "UInt64":
                    return (T)(object)read(UInt64.Parse, message);
                default:
                    throw new NotSupportedException("This " + typeof(T).Name + " is not supported");
            }
        }
    }
}
