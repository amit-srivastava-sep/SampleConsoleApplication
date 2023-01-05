using System;
using System.Collections.Generic;

namespace PrettyConsoleHelper.Tests
{

    public class MockPrettyConsole : IPrettyConsole
    {
        public MockPrettyConsole()
        {
            Options = new PrettyConsoleOptions();
        }

        public List<ConsoleKeyInfo> KeysToRead { get; set; } = new();

        public PrettyConsoleOptions Options { get; init; }
        public string ReturnValue { get; set; }

        public void LogError(string message, Exception ex = null)
        {
            return;
        }

        public void LogWarning(string message, Exception ex = null)
        {
            return;
        }

        public ConsoleKeyInfo ReadKey(bool dontShowKey)
        {
            var indexOfFirstItem = 0;
            var key = KeysToRead[indexOfFirstItem];
            KeysToRead.RemoveAt(indexOfFirstItem);
            return key;
        }

        public string ReadLine()
        {
            return ReturnValue;
        }

        public void Write(char value, int times, ConsoleColor color = ConsoleColor.White)
        {
            return;
        }

        public void Write(object value, ConsoleColor color)
        {
            return;
        }

        public void Write(string text, bool prompt)
        {
            return;
        }

        public void Write(int value, ConsoleColor color)
        {
            return;
        }

        public void Write(string text, ConsoleColor color, bool prompt)
        {
            return;

        }

        public void Write(int value)
        {
            return;
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }

        public void WriteLine(object value)
        {
            return;
        }

        public void WriteLine(object value, ConsoleColor color)
        {
            return;
        }

        public void WriteLine(string text)
        {
            return;
        }

        public void WriteLine(string text, ConsoleColor color)
        {
            return;
        }

        public void WriteLine(char value, int times, ConsoleColor color = ConsoleColor.White)
        {
            return;
        }
    }
}
