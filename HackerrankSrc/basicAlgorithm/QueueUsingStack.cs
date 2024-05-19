using System;
using System.Collections;
using System.Collections.Generic;

public class QueueUsingStack
{
    //https://stackoverflow.com/questions/69192/how-to-implement-a-queue-using-two-stacks#:~:text=Method%201%20(By%20making%20enQueue%20operation%20costly)&text=enQueue(q%2C%20x)%201,from%20stack1%20and%20return%20it.

    private Stack<char> _inbox = new Stack<char>();
    private Stack<char> _outbox = new Stack<char>();


    
    public void Enque(char c)
    {
        _inbox.Push(c);
    }

    public char Dequeue()
    {
        if(_outbox.Count == 0)
        {
            while (_inbox.Count > 0)
            {
                var item = _inbox.Pop();
                _outbox.Push(item);
            }
        }

        if(_outbox.Count == 0)
        {
            throw new Exception("Empty Queue");
        }

        return (char)_outbox.Pop();
    }

}

