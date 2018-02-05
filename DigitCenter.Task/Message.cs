using System;

namespace DigitCenter.Task
{
    class Message : EntryObject
    {
        public Message(String message) : base()
        {
            if (String.IsNullOrEmpty(message))
                throw new ArgumentNullException("Аргумент не может быть пуст");
            
            this.data = message;
        }
        
        public String Text
        {
            get { return data; }
        }

        public override string ToString()
        {
            return $"[{creationTime}][Message] {data}";
        }

        private String data;
    }
}
