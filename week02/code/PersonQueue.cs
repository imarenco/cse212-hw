/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _queue.Add(person);
    }

    public Person Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot dequeue from an empty queue.");

        int maxTurns = _queue.Max(p => p.Turns);
        int index = _queue.FindIndex(p => p.Turns == maxTurns);

        Person person = _queue[index];
        _queue.RemoveAt(index);

        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}