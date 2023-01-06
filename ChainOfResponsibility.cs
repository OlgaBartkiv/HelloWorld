using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public interface IHandler
    {
        void SetTheNextHandler(IHandler handler);
        void Process(Request request);
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    abstract class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public void SetTheNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void Process(Request request);
    }

    public class Request
    {
        public Customer Data { get; set; }
        public List<string> ValidationMessages;

        public Request()
        {
            ValidationMessages = new List<string>();
        }
    }

    class AgeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data.Age > 70 || request.Data.Age < 18)
            {
                request.ValidationMessages.Add("Invalid age range");
            }

            if (_nextHandler != null)
            {
                _nextHandler.Process(request);
            }
        }
    }

    class NameHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data.Name.Length > 15)
            {
                request.ValidationMessages.Add("Invalid name length");
            }

            if (_nextHandler != null)
            {
                _nextHandler.Process(request);
            }
        }
    }
}
