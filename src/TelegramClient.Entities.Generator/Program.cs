using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TelegramClient.Entities.Generator
{
    using System.Runtime.InteropServices;
    using System.Text;

    internal class Program
    {
        private static readonly List<string> InterfacesList = new List<string>();
        private static readonly List<string> ClassesList = new List<string>();

        private static void Main(string[] args)
        {
            var absStyle = File.ReadAllText("ConstructorAbs.tmp");
            var normalStyle = File.ReadAllText("Constructor.tmp");
            var methodStyle = File.ReadAllText("Method.tmp");
            //string method = File.ReadAllText("constructor.tt");
            string json;
            var url = !args.Any()
                             ? "Tl-schema.json"
                             : args[0];

            json = File.ReadAllText(url);
            var schema = JsonConvert.DeserializeObject<Schema>(json);
            foreach (var c in schema.Constructors)
            {
                InterfacesList.Add(c.Type);
                ClassesList.Add(c.Predicate);
            }
            foreach (var c in schema.Constructors)
            {
                var list = schema.Constructors.Where(x => x.Type == c.Type);
                if (list.Count() > 1)
                {
                    var path = (GetNameSpace(c.Type).Replace("TelegramClient.Entities", "Tl\\").Replace(".", "") + "\\" +
                                GetNameofClass(c.Type, true) + ".cs").Replace("\\\\", "\\");
                    var classFile = MakeFile(path);
                    using (var writer = new StreamWriter(classFile))
                    {
                        var temp = absStyle.Replace("/* NAMESPACE */", GetNameSpace(c.Type));
                        temp = temp.Replace("/* NAME */", GetNameofClass(c.Type, true));
                        writer.Write(temp);
                    }
                }
                else
                {
                    InterfacesList.Remove(list.First().Type);
                    list.First().Type = "himself";
                }
            }
            foreach (var c in schema.Constructors)
            {
                var path = (GetNameSpace(c.Predicate).Replace("TelegramClient.Entities", "Tl\\").Replace(".", "") + "\\" + GetNameofClass(c.Predicate) + ".cs").Replace("\\\\", "\\");
                var classFile = MakeFile(path);
                using (var writer = new StreamWriter(classFile))
                {
                    #region About Class

                    var nspace = GetNameSpace(c.Predicate)
                        .Replace("TelegramClient.Entities", "Tl\\")
                        .Replace(".", "")
                        .Replace("\\\\", "\\")
                        .Replace("\\", ".");
                    if (nspace.EndsWith("."))
                        nspace = nspace.Remove(nspace.Length - 1, 1);

                    var classBulder = new StringBuilder(normalStyle.Replace("/* NAMESPACE */", "TelegramClient.Entities." + nspace));

                    var iHaveFlags = ContainsFlags(c)
                                         ? ", IHaveFlags"
                                         : string.Empty;

                    classBulder = c.Type == "himself"
                        ? classBulder.Replace("/* PARENT */", "TlObject")
                        : classBulder.Replace("/* PARENT */", GetNameofClass(c.Type, true) + iHaveFlags);
                    classBulder = classBulder.Replace("/*Constructor*/", c.Id.ToString());
                    classBulder = classBulder.Replace("/* NAME */", GetNameofClass(c.Predicate));

                    #endregion

                    classBulder = classBulder.Replace("/* PARAMS */", GetProps(c));

                   writer.Write(classBulder);
                }
            }
            foreach (var c in schema.Methods)
            {
                var path = (GetNameSpace(c.method).Replace("TelegramClient.Entities", "Tl\\").Replace(".", "") + "\\" +
                            GetNameofClass(c.method, false, true) + ".cs").Replace("\\\\", "\\");
                var classFile = MakeFile(path);
                using (var writer = new StreamWriter(classFile))
                {
                    #region About Class

                    var nspace = GetNameSpace(c.method)
                        .Replace("TelegramClient.Entities", "Tl\\")
                        .Replace(".", "")
                        .Replace("\\\\", "\\")
                        .Replace("\\", ".");
                    if (nspace.EndsWith("."))
                        nspace = nspace.Remove(nspace.Length - 1, 1);
                    var temp = methodStyle.Replace("/* NAMESPACE */", "TelegramClient.Entities." + nspace);

                    var iHaveFlags = ContainsFlags(c)
                                     ? ", IHaveFlags"
                                     : string.Empty;
                    temp = temp.Replace("/* PARENT */", $"TlMethod<{CheckForFlagBase(c.Type, GetTypeName(c.Type))}>{iHaveFlags}");

                    temp = temp.Replace("/*Constructor*/", c.Id.ToString());
                    temp = temp.Replace("/* NAME */", GetNameofClass(c.method, false, true));

                    #endregion

                    temp = temp.Replace("/* PARAMS */", GetProps(c));
                    
                    writer.Write(temp);
                }
            }
        }

        private static string GetProps(IHaveParams c)
        {
            var builder = new StringBuilder();

            var containsFlag = ContainsFlags(c);

            for (var index = 0; index < c.Params.Count; index++)
            {
                var prop = c.Params[index];

                var flagBase = IsFlagBase(prop.Type);

                if (containsFlag && prop.Name == "flags" && !c.Params.Any(p => IsFlagBase(p.Type)))
                {
                    continue;
                }

                if (containsFlag && prop.Name == "flags")
                {
                    builder.AppendLine($"        private {CheckForFlagBase(prop.Type, GetTypeName(prop.Type))} _fields;");
                }

                if (!flagBase)
                {
                    builder.AppendLine($"        [SerializationOrder({index})]");
                }

                builder.Append($"        public {CheckForFlagBase(prop.Type, GetTypeName(prop.Type))} {FormatPropertyName(prop.Name)} ");

                if (containsFlag && prop.Name == "flags")
                {
                    builder.AppendLine();
                    builder.AppendLine("        {");


                    builder.AppendLine("            get");
                    builder.AppendLine("            {");
                    builder.AppendLine("                var flags = 0; ");
                    builder.AppendLine();
                    foreach (var param in c.Params.Where(x => IsFlagBase(x.Type)))
                    {
                        var bitMask = GetBitMask(param.Type);
                        var name = FormatPropertyName(param.Name);

                        builder.AppendLine(
                            IsTrueFlag(param.Type)
                                ? $"                flags = {name} ? (flags | {bitMask}) : (flags & ~{bitMask});"
                                : $"                flags = {name} != null ? (flags | {bitMask}) : (flags & ~{bitMask});");
                    }
                    builder.AppendLine();
                    builder.AppendLine("                return flags; ");
                    builder.AppendLine("            }");

                    builder.AppendLine("            set");
                    builder.AppendLine("            {");
                    builder.AppendLine("                _fields = value;");
                    builder.AppendLine("            }");

                    builder.AppendLine("        }");

                }
                else
                {
                    builder.AppendLine("{ get; set; }");
                }
                    builder.AppendLine();
            }

            ///if (IsTrueFlag(p.Type))
            //{
            //    return $"{CheckForKeyword(p.Name)} = (flags & {GetBitMask(p.Type)}) != 0;";
            //}
            //var p2 = new Param { Name = p.Name, Type = p.Type.Split('?')[1] };
            //return $"if ((flags & {GetBitMask(p.Type)}) != 0)" + Environment.NewLine +
            //       WriteReadCode(p2) + Environment.NewLine +
            //       "else" + Environment.NewLine +
            //       $"{CheckForKeyword(p.Name)} = null;" + Environment.NewLine;
            return builder.ToString();
        }

        private static bool ContainsFlags(IHaveParams c)
        {
            return c.Params.Any(x => x.Name == "flags");
        }

        public static string FormatPropertyName(string input)
        {
            return string.Join("", input.Split('_').Select(s => s[0].ToString().ToUpper() + s.Substring(1)));
        }


        public static string FormatName(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            if (input.IndexOf('.') != -1)
            {
                input = input.Replace(".", " ");
                var temp = "";
                foreach (var s in input.Split(' '))
                {
                    temp += FormatName(s) + " ";
                }
                input = temp.Trim();
            }
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public static string GetNameofClass(string type, bool isinterface = false, bool ismethod = false)
        {
            if (!ismethod)
                if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
                    return isinterface
                        ? "TlAbs" + FormatName(type.Split('.')[1])
                        : "Tl" + FormatName(type.Split('.')[1]);
                else if (type.IndexOf('.') != -1 && type.IndexOf('?') != -1)
                    return isinterface
                        ? "TlAbs" + FormatName(type.Split('?')[1])
                        : "Tl" + FormatName(type.Split('?')[1]);
                else
                    return isinterface ? "TlAbs" + FormatName(type) : "Tl" + FormatName(type);
            if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
                return "TlRequest" + FormatName(type.Split('.')[1]);
            if (type.IndexOf('.') != -1 && type.IndexOf('?') != -1)
                return "TlRequest" + FormatName(type.Split('?')[1]);
            return "TlRequest" + FormatName(type);
        }

        private static bool IsFlagBase(string type)
        {
            return type.IndexOf("?", StringComparison.Ordinal) != -1;
        }

        private static int GetBitMask(string type)
        {
            return (int) Math.Pow(2, int.Parse(type.Split('?')[0].Split('.')[1]));
        }

        private static bool IsTrueFlag(string type)
        {
            return type.Split('?')[1] == "true";
        }

        public static string GetNameSpace(string type)
        {
            if (type.IndexOf('.') != -1)
                return "TelegramClient.Entities" + FormatName(type.Split('.')[0]);
            return "TelegramClient.Entities";
        }

        public static string CheckForFlagBase(string type, string result)
        {
            if (type.IndexOf('?') == -1)
                return result;
            var innerType = type.Split('?')[1];
            if (innerType == "true") return result;
            if (new[] {"bool", "int", "uint", "long", "double"}.Contains(result)) return result + "?";
            return result;
        }

        public static string GetTypeName(string type)
        {
            switch (type.ToLower())
            {
                case "#":
                case "int":
                    return "int";
                case "uint":
                    return "uint";
                case "long":
                    return "long";
                case "double":
                    return "double";
                case "string":
                    return "string";
                case "bytes":
                    return "byte[]";
                case "true":
                case "bool":
                    return "bool";
                case "!x":
                    return "TlObject";
                case "x":
                    return "TlObject";
            }

            if (type.StartsWith("Vector"))
                return "TlVector<" + GetTypeName(type.Replace("Vector<", "").Replace(">", "")) + ">";

            if (type.ToLower().Contains("inputcontact"))
                return "TlInputPhoneContact";


            if (type.IndexOf('.') != -1 && type.IndexOf('?') == -1)
                if (InterfacesList.Any(x => x.ToLower() == type.ToLower()))
                    return FormatName(type.Split('.')[0]) + "." + "TlAbs" + type.Split('.')[1];
                else if (ClassesList.Any(x => x.ToLower() == type.ToLower()))
                    return FormatName(type.Split('.')[0]) + "." + "Tl" + type.Split('.')[1];
                else
                    return FormatName(type.Split('.')[1]);
            if (type.IndexOf('?') == -1)
                if (InterfacesList.Any(x => x.ToLower() == type.ToLower()))
                    return "TlAbs" + type;
                else if (ClassesList.Any(x => x.ToLower() == type.ToLower()))
                    return "Tl" + type;
                else
                    return type;
            return GetTypeName(type.Split('?')[1]);
        }

        public static string LookTypeInLists(string src)
        {
            if (InterfacesList.Any(x => x.ToLower() == src.ToLower()))
                return "TlAbs" + FormatName(src);
            if (ClassesList.Any(x => x.ToLower() == src.ToLower()))
                return "Tl" + FormatName(src);
            return src;
        }

        public static FileStream MakeFile(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));

            if (File.Exists(path))
                return File.Open(path, FileMode.Truncate);
            return File.Open(path, FileMode.Create);
        }
    }
}