using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace idev.Framework.Operations
{
    public class OperationResult<T>
    {
        public bool Success { get; private set; }
        public string OperationName { get; private set; }
        public string Message { get; private set; }
        public string ExMessage { get; private set; }
        public DateTime OperationDate { get; private set; }
        public HttpStatusCode Status { get; private set; }
        public virtual T Object { get; private set; }
        public virtual List<T> List { get; set; }

        public OperationResult(string OperationName)
        {
            Success = false;
            this.OperationName = OperationName;
            OperationDate = DateTime.Now;
        }

        public OperationResult<T> Succeed(string Message)
        {
            Success = true;
            this.Message = Message;
            Status = HttpStatusCode.OK;
            return this;
        }
        public OperationResult<T> Succeed(string Message, HttpStatusCode Status)
        {
            this.Status = Status;
            Success = true;
            this.Message = Message;
            return this;
        }
        public OperationResult<T> Succeed(string Message, T Object)
        {
            Success = true;
            this.Message = Message;
            Status = HttpStatusCode.OK;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Succeed(string Message, HttpStatusCode Status, T Object)
        {
            this.Status = Status;
            Success = true;
            this.Message = Message;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Failed(string Message)
        {
            Success = false;
            this.Message = Message;
            Status = HttpStatusCode.BadRequest;
            return this;
        }
        public OperationResult<T> Failed(string Message, T Object)
        {
            Success = false;
            this.Message = Message;
            Status = HttpStatusCode.BadRequest;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, T Object)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Failed(string Message, HttpStatusCode Status)
        {
            Success = false;
            this.Message = Message;
            this.Status = Status;
            return this;
        }
        public OperationResult<T> Failed(string Message, HttpStatusCode Status, T Object)
        {
            Success = false;
            this.Message = Message;
            this.Status = Status;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, HttpStatusCode Status)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, HttpStatusCode Status, T Object)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            this.Object = Object;
            return this;
        }
        public OperationResult<T> Succeed(string Message, List<T> List)
        {
            Success = true;
            this.Message = Message;
            Status = HttpStatusCode.OK;
            this.List = List;
            return this;
        }
        public OperationResult<T> Succeed(string Message, string ExMessage, List<T> List)
        {
            Success = true;
            this.Message = Message;
            this.ExMessage = ExMessage;
            Status = HttpStatusCode.OK;
            this.List = List;
            return this;
        }
        public OperationResult<T> Succeed(string Message, HttpStatusCode Status, List<T> List)
        {
            this.Status = Status;
            Success = true;
            this.Message = Message;
            this.List = List;
            return this;
        }
        public OperationResult<T> Succeed(string Message, T Object, List<T> List)
        {
            Success = true;
            this.Message = Message;
            Status = HttpStatusCode.OK;
            this.Object = Object;
            this.List = List;
            return this;
        }
        public OperationResult<T> Succeed(string Message, HttpStatusCode Status, T Object, List<T> List)
        {
            this.Status = Status;
            Success = true;
            this.Message = Message;
            this.Object = Object;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, List<T> List)
        {
            Success = false;
            this.Message = Message;
            Status = HttpStatusCode.BadRequest;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, T Object, List<T> List)
        {
            Success = false;
            this.Message = Message;
            Status = HttpStatusCode.BadRequest;
            this.Object = Object;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, T Object, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Object = Object;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, HttpStatusCode Status, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.Status = Status;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, HttpStatusCode Status, T Object, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.Status = Status;
            this.Object = Object;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, HttpStatusCode Status, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            this.List = List;
            return this;
        }
        public OperationResult<T> Failed(string Message, string ExMessage, HttpStatusCode Status, T Object, List<T> List)
        {
            Success = false;
            this.Message = Message;
            this.ExMessage = ExMessage;
            this.Status = Status;
            this.Object = Object;
            this.List = List;
            return this;
        }
    }
}
