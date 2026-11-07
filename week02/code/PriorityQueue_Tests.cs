using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and same priorities: Bob (1), Tim (1), Sue (1)
    // Requirements: 1. The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    //               3. If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.       
    // Expected Result: Bob, Tim, Sue
    // Defect(s) Found:  The expected result doesn't match the actual result. Expected:<Bob>. Actual:<Tim>. 
    public void TestPriorityEnqueueFunction()
    {

        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 1);

        string[] expectedResult = ["Bob", "Tim", "Sue"];

        int i = 0;
        while (i < 3)
        {

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], item);
            i++;
        }
    }

    [TestMethod]
    // Scenario:  Create a queue with the following items and priorities: Bob (1), Tim (5), Sue (3) and
    // and call Dequeue() once.
    // Requirements: 2. The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: Tim
    // Defect(s) Found:  None, test passed as expected.
    public void TestPriorityDequeueFunction()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var item = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", item);


    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario:  Create a empty queue and call Dequeue().
    // Requirements: 4. If the queue is empty, then an error exception shall be thrown. This exception should be an InvalidOperationException with a message of "The queue is empty."
    // Expected Result: Exception
    // Defect(s) Found:  None, test passed as expected.
    public void TestEmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
     
    
}