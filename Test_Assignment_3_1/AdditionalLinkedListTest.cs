using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3_1
{
    public class AdditionalLinkedListTest
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Creating a linkedlist instance
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        // Test appending multiple elements and then clearing the list.
        [Test]
        public void TestAppendAndClear()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            Assert.AreEqual(3, this.linkedList.Size());

            this.linkedList.Clear();

            Assert.True(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }

        // Test inserting nodes at the beginning of the list.
        [Test]
        public void TestInsertAtBeginning()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");

            this.linkedList.Insert("c", 0);


            Assert.AreEqual("c", this.linkedList.Retrieve(0));
            Assert.AreEqual("a", this.linkedList.Retrieve(1));
            Assert.AreEqual("b", this.linkedList.Retrieve(2));
        }

        // Test deleting the only node in the list.
        [Test]
        public void TestDeleteSingleElement()
        {
            this.linkedList.Append("a");

            this.linkedList.Delete(0);

            Assert.True(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }

        // Test replacing a node at the end of the list.
        [Test]
        public void TestReplaceLastNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");

            this.linkedList.Replace("d", 2);


            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            Assert.AreEqual("d", this.linkedList.Retrieve(2));
        }

        // Test retrieving a node from an empty list.
        [Test]
        public void TestRetrieveFromEmptyList()
        {
            Assert.AreEqual(null, this.linkedList.Retrieve(0));
        }
    }
}
