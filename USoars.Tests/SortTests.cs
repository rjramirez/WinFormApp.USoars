using SortingApp.Models;

namespace USoars.Tests
{
    /// <summary>
    /// NUnit tests for sorting strategies.
    /// </summary>
    [TestFixture]
    public class SortTests
    {
        [Test]
        public void BubbleSort_SortsCorrectly()
        {
            var sorter = new BubbleSort();
            Assert.That(sorter.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void QuickSort_SortsCorrectly()
        {
            var sorter = new QuickSort();
            Assert.That(sorter.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void MergeSort_SortsCorrectly()
        {
            var sorter = new MergeSort();
            Assert.That(sorter.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void SortContext_UsesCorrectStrategy()
        {
            var context = new SortContext(new QuickSort());
            Assert.That(context.Sort("edcba"), Is.EqualTo("abcde"));
        }



        /*
         * Strategies Testing
         */
        [Test]
        public void SortContext_UsesCorrectStrategy_BubbleSort()
        {
            var context = new SortContext(new BubbleSort());
            Assert.That(context.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void SortContext_UsesCorrectStrategy_QuickSort()
        {
            var context = new SortContext(new QuickSort());
            Assert.That(context.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void SortContext_UsesCorrectStrategy_MergeSort()
        {
            var context = new SortContext(new MergeSort());
            Assert.That(context.Sort("edcba"), Is.EqualTo("abcde"));
        }

        [Test]
        public void SortContext_HandlesEmptyString()
        {
            var context = new SortContext(new BubbleSort());
            Assert.That(context.Sort(string.Empty), Is.EqualTo(string.Empty));
        }

        [Test]
        public void SortContext_HandlesSingleCharacter()
        {
            var context = new SortContext(new QuickSort());
            Assert.That(context.Sort("a"), Is.EqualTo("a"));
        }

        [Test]
        public void SortContext_HandlesAlreadySortedString()
        {
            var context = new SortContext(new MergeSort());
            Assert.That(context.Sort("abcde"), Is.EqualTo("abcde"));
        }
    }
}