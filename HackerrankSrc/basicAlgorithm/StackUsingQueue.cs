using System;
using System.Collections;

public class StackUsingQueue
{


    private Queue _q1 = new Queue();
    private Queue _q2 = new Queue();

    private Queue _popQ;
    private Queue _pushQ;

    public StackUsingQueue()
    {
        _pushQ = _q1;
        _popQ = _q2;
    }
    public void Push(char c)
    {
        _pushQ.Enqueue(c);

    }

    public char Pop()
    {
        while (_pushQ.Count > 1)
        {
            var temp =  _pushQ.Dequeue();
            _popQ.Enqueue(temp);
        }

        //switch
        var item = _pushQ.Dequeue(); 
        var t = _pushQ;
        _pushQ = _popQ;
        _popQ = t;

        return (char)item;
    }

}

