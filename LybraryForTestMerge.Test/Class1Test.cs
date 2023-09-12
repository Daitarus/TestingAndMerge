using NUnit.Framework;
using LibraryForTestAndMerge;

namespace LibraryForTestAndMergeTest
{
    public class Class1Test
    {
        [Test]
        public void Default_Index()
        {
            int excpectedIndex = 0;

            Class1 class1 = new Class1(0);
            int index = class1.Index;
            Assert.AreEqual(index, excpectedIndex);
        }

        [Test]
        public void AddValue_To_Default_Index()
        {
            int excpectedIndex = 10;

            Class1 class1 = new Class1(0);
            class1.AddValue(10);
            int index = class1.Index;
            Assert.AreEqual(index, excpectedIndex);
        }

        [Test]
        public void AddValue_To_NotDefault_Index()
        {
            int excpectedIndex = 12;

            Class1 class1 = new Class1(0);
            class1.AddValue(10);
            class1.AddValue(2);
            int index = class1.Index;
            Assert.AreEqual(index, excpectedIndex);
        }
    }
}