using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Enqueue and check if it's inserted in the last position.
    // Expected Result: state in order First,Second,Third as last item of queue.
    // Defect(s) Found: None
    public void TestInsertedOrder_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);              
        Assert.AreEqual(priorityQueue.ToString(), "[First (Pri:1), Second (Pri:1), Third (Pri:1)]");
    }

      [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: Get the item with more priority and first position.
    // Defect(s) Found:  None.
    public void TestDequeuePriority_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 10); 
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }


    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: Get the item with more priority.
    // Defect(s) Found:  None.
    public void TestDequeuePriority_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 20);
        priorityQueue.Enqueue("Third", 10); 

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Second", result); 
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found: None
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyDequeue_Throws()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }

    [TestMethod]
    // Scenario: ToString reflects the internal queue state correctly.
    // Expected Result: Formatted string with value and priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_ToString()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("One", 1);
        priorityQueue.Enqueue("Two", 2);

        var result = priorityQueue.ToString();

        Assert.AreEqual("[One (Pri:1), Two (Pri:2)]", result);
    }

    // Add more test cases as needed below.
}