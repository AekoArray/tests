using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Xml.Serialization;
using System.IO;

namespace TestTumblr
{
    [TestFixture]
    public class UntitledTest : TestBase
    {


        [Test]
        public void testCreatePost()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("shakirova139@gmail.com", "shakirova-love");
            app.Auth.Login(user);

            /*app.Navigation.OpenMenuOfEditPosts();*/
            /*PostData post = new PostData("NewTest", "NewTest");*/
            /*            IEnumerable<PostData> postDatas = PostCreationTest.PostDataFromXmlFile();
                        foreach (PostData data in postDatas)
                        {
                            *//*new PostData(data.Title, data.Description);*//*
                            PostCreationTest.TestMethod(new PostData(data.Title, data.Description));
                        }*/
           /* IEnumerable<PostData> postDatas = PostCreationTest.PostDataFromXmlFile();
            foreach (PostData data in postDatas)
            {
                *//*new PostData(data.Title, data.Description);*/
                /*PostCreationTest.TestMethod(new PostData(data.Title, data.Description));*//*
                app.Navigation.OpenMenuOfEditPosts();
                app.Post.CreatePost(new PostData(data.Title, data.Description));
            }
            app.Navigation.OpenPosts();*/
            /*PostData newPost = app.Post.GetCreatedPostData();
            Assert.AreEqual(post.Title, newPost.Title);*/
            /*app.Navigation.OpenMenuOfEditQuote();
            QuoteData quote = new QuoteData("NewQuote", "NewQuote");
            app.Quote.CreateQuote(quote);*/
            /* app.Navigation.OpenPosts();
             QuoteData quoteNew = new QuoteData("NewQuoteEdit", "NewQuoteEdit");
             app.Quote.EditQuote(quoteNew);
             app.Post.DeletePost();*/
        }

        public static IEnumerable<PostData> PostDataFromXmlFile()
        {
            return (List<PostData>)new XmlSerializer(typeof(List<PostData>))
                .Deserialize(new StreamReader(@"C:\Домашки\Тесты\FinalTest\TestTumblr\Generator\bin\Release\netcoreapp3.1\posts.xml"));
        }

        [Test, TestCaseSource("PostDataFromXmlFile")]
        public static void TestMethod(PostData post) { 
            app.Navigation.OpenMenuOfEditPosts();
            app.Post.CreatePost(new PostData(post.Title, post.Description));
            app.Navigation.OpenPosts();
        }

        /*        [Test]
                public void testEditPost()
                {
                    app.Navigation.OpenPosts();
                    PostData post = app.Post.GetCreatedPostData();
                    PostData postNew = new PostData("Edit", "Edit");
                    app.Post.EditPost(postNew);
                    app.Navigation.OpenPosts();
                    PostData editPost = app.Post.GetEditPostData(post, postNew);
                    PostData newPost = app.Post.GetCreatedPostData();
                    Assert.AreEqual(editPost.Title, newPost.Title);
                }

                [Test]
                public void testDeletePost()
                {
                    PostData post = app.Post.GetCreatedPostData();
                    app.Post.DeletePost();
                    PostData postLast = app.Post.GetCreatedPostData();
                    Assert.AreNotEqual(post.Title, postLast.Title);
                }*/
    }
}