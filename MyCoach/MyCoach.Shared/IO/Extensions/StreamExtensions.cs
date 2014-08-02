using System;
using System.IO;

namespace MyCoach.Shared.IO.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToBytes(this Stream stream)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);

                return ms.ToArray();
            }
        }
    }
}
