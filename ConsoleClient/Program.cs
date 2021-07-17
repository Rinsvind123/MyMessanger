using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main()
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);

            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2021-07-17T18:29:35.4286738Z"}
            //RusAl < 17.07.2021 18:29:35 >: Privet
        }
    }
}
