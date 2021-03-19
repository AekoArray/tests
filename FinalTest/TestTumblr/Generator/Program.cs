using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TestTumblr;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = args[0];
            int count = Convert.ToInt32(args[1]);
            string filename = args[2];
            string format = args[3];
            if (type == "posts")
            {
                GenerateForGroups(count, filename, format);
            }
            else
            {
                System.Console.Out.Write("Unrecognized type of data" + type);
            }
        }

        static void GenerateForGroups(int count, string filename, string format)
        {
            List<PostData> posts = new List<PostData>();
            for (int i = 0; i < count; i++)
            {
                posts.Add(new PostData(TestBase.GenerateRandomString(20),
                    TestBase.GenerateRandomString(20)
                ));
        }
        StreamWriter writer = new StreamWriter(filename);
            if (format == "xml")
            {
                WriteGroupsToXmlFile(posts, writer);

    }
            else
            {
                System.Console.Out.Write("Unrecognized format" + format);
            }
writer.Close();
        }

        static void WriteGroupsToXmlFile(List<PostData> posts, StreamWriter writer)
{
    new XmlSerializer(typeof(List<PostData>)).Serialize(writer, posts);
}
    }
}
