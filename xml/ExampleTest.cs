namespace SeleniumTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
//Метод который вам нужен чтобы распарсить Xml

        public static IEnumerable<GroupData> GroupDataFromXmlFile()
        {
            return (List<GroupData>) new XmlSerializer(typeof(List<GroupData>))
                .Deserialize(new StreamReader(@"groups.xml"));
        }


        [Test, TestCaseSource("GroupDataFromXmlFile")]
		// вы параметром передаете список тестовых данных, которые распарсятся с помощью указанного метода. Вы можете использовать другой тип файла, например json. 

        public void TestMethod(GroupData group)
		//теперь в параметр теста приходят тестовые данные, которые будут использоваться.
        {
            …
        }
    }
}
