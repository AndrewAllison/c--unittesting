using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{

    [TestFixture]
    class StackTests
    {
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNUllException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenObjectAdded_CountShouldEqualOne()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EmptyStack_ThrowINvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenStackHasValidObjects_ObjectIsReturned()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            Assert.That(stack.Count, Is.EqualTo(3));
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_ValidArg_RemoveObjectFromStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            Assert.That(stack.Count, Is.EqualTo(3));
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_EmptyStack_ThrowINvalidOperaionException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
