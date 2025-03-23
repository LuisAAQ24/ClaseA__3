using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class EstructurasDeDatosTests
{
    // Pruebas para la Pila con Arreglo
    [TestMethod]
    public void TestPilaConArreglo_Apilar()
    {
        ArrayStack stack = new ArrayStack(5);
        stack.Push(10);
        Assert.AreEqual(10, stack.Top());
    }

    [TestMethod]
    public void TestPilaConArreglo_Desapilar()
    {
        ArrayStack stack = new ArrayStack(5);
        stack.Push(10);
        stack.Push(20);
        Assert.AreEqual(20, stack.Pop());
        Assert.AreEqual(10, stack.Top());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPilaConArreglo_DesapilarVacia()
    {
        ArrayStack stack = new ArrayStack(5);
        stack.Pop(); // Debería lanzar excepción
    }

    [TestMethod]
    public void TestPilaConArreglo_EstaVacia()
    {
        ArrayStack stack = new ArrayStack(5);
        Assert.IsTrue(stack.IsEmpty());
        stack.Push(10);
        Assert.IsFalse(stack.IsEmpty());
    }

    // Pruebas para la Pila con Lista Enlazada
    [TestMethod]
    public void TestPilaConListaEnlazada_Apilar()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(10);
        Assert.AreEqual(10, stack.Top());
    }

    [TestMethod]
    public void TestPilaConListaEnlazada_Desapilar()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(10);
        stack.Push(20);
        Assert.AreEqual(20, stack.Pop());
        Assert.AreEqual(10, stack.Top());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPilaConListaEnlazada_DesapilarVacia()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Pop(); // Debería lanzar excepción
    }

    [TestMethod]
    public void TestPilaConListaEnlazada_EstaVacia()
    {
        LinkedListStack stack = new LinkedListStack();
        Assert.IsTrue(stack.IsEmpty());
        stack.Push(10);
        Assert.IsFalse(stack.IsEmpty());
    }

    // Pruebas para la Cola con Arreglo
    [TestMethod]
    public void TestColaConArreglo_Encolar()
    {
        ArrayQueue queue = new ArrayQueue(5);
        queue.Enqueue(10);
        Assert.AreEqual(10, queue.Front());
    }

    [TestMethod]
    public void TestColaConArreglo_Desencolar()
    {
        ArrayQueue queue = new ArrayQueue(5);
        queue.Enqueue(10);
        queue.Enqueue(20);
        Assert.AreEqual(10, queue.Dequeue());
        Assert.AreEqual(20, queue.Front());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestColaConArreglo_DesencolarVacia()
    {
        ArrayQueue queue = new ArrayQueue(5);
        queue.Dequeue(); // Debería lanzar excepción
    }

    [TestMethod]
    public void TestColaConArreglo_EstaVacia()
    {
        ArrayQueue queue = new ArrayQueue(5);
        Assert.IsTrue(queue.IsEmpty());
        queue.Enqueue(10);
        Assert.IsFalse(queue.IsEmpty());
    }

    // Pruebas para la Cola con Lista Enlazada
    [TestMethod]
    public void TestColaConListaEnlazada_Encolar()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(10);
        Assert.AreEqual(10, queue.Front());
    }

    [TestMethod]
    public void TestColaConListaEnlazada_Desencolar()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        Assert.AreEqual(10, queue.Dequeue());
        Assert.AreEqual(20, queue.Front());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestColaConListaEnlazada_DesencolarVacia()
    {
        LinkedListQueue queue = new LinkedListQueue();
        queue.Dequeue(); // Debería lanzar excepción
    }

    [TestMethod]
    public void TestColaConListaEnlazada_EstaVacia()
    {
        LinkedListQueue queue = new LinkedListQueue();
        Assert.IsTrue(queue.IsEmpty());
        queue.Enqueue(10);
        Assert.IsFalse(queue.IsEmpty());
    }
}
