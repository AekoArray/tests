/*using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TestTumblr
{
    [TestFixture]
    public class PostCreationTest : TestBase
    {
        //Метод который вам нужен чтобы распарсить Xml


        public static IEnumerable<PostData> PostDataFromXmlFile()
        {
            return (List<PostData>)new XmlSerializer(typeof(List<PostData>))
                .Deserialize(new StreamReader(@"C:\Домашки\Тесты\FinalTest\TestTumblr\Generator\bin\Release\netcoreapp3.1\posts.xml"));
        }


        [Test, TestCaseSource("PostDataFromXmlFile")]
        public static void TestMethod(PostData post)
        //теперь в параметр теста приходят тестовые данные, которые будут использоваться.
        {
            *//*new PostData().Title =  PostDataFromXmlFile().*/
            /*PostDataFromXmlFile()*//*
            IEnumerable<PostData> postDatas = PostCreationTest.PostDataFromXmlFile();
            foreach(PostData data in postDatas)
            {
                new PostData(data.Title, data.Description);
            }
*/
            /*            IEnumerable<PostData> postDatas = PostCreationTest.PostDataFromXmlFile();
                        foreach (PostData data in postDatas)
                        {
                            *//*new PostData(data.Title, data.Description);*/
            /*PostCreationTest.TestMethod(new PostData(data.Title, data.Description));*//*
            app.Post.CreatePost(new PostData(data.Title, data.Description));
        }*/
            /*            IEnumerable<PostData> postDatas = PostCreationTest.PostDataFromXmlFile();
                        foreach (PostData data in postDatas)
                        {
                            *//*new PostData(data.Title, data.Description);*/
            /*PostCreationTest.TestMethod(new PostData(data.Title, data.Description));*//*
            app.Navigation.OpenMenuOfEditPosts();
            app.Post.CreatePost(new PostData(data.Title, data.Description));
        }
        app.Navigation.OpenPosts();*//*
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("shakirova139@gmail.com", "shakirova-love");
            app.Auth.Login(user);
            app.Navigation.OpenMenuOfEditPosts();
            app.Post.CreatePost(new PostData(post.Title, post.Description));
            app.Navigation.OpenPosts();
        }
    }
}
*/