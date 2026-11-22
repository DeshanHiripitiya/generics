var numbers = new MyStack<int>();
numbers.Push(1);
numbers.Push(2);
Console.WriteLine(numbers.Pop());   // 2

var words = new MyStack<string>();
words.Push("hello");
Console.WriteLine(words.Peek());    // hello
