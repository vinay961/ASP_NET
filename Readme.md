# Asynchronous Programming
Asynchronous Programming allows a program to perform multiple tasks at once without blocking the execution of other operations.
In C#, we achieve async programming using:
- async and await keywords
- Task and `Task<T>` type

** A method that is async must have return type Task or `Task<T>`. **
** `await` pauses the execution but does not block the thread. **
** `await` must be used inside the async methods. **

1. Task.WhenAll() - Run multiple tasks in parallel
2. Use try-catch inside async methods to handle exceptions. 