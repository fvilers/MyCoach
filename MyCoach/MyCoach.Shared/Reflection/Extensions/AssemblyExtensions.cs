using MyCoach.Shared.IO.Extensions;
using System;
using System.Reflection;

namespace MyCoach.Shared.Reflection.Extensions
{
    public static class AssemblyExtensions
    {
        public static byte[] GetManifestResource(this Assembly assembly, string name)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");

            using (var stream = assembly.GetManifestResourceStream(name))
            {
                return stream == null ? null : stream.ToBytes();
            }
        }
    }
}
