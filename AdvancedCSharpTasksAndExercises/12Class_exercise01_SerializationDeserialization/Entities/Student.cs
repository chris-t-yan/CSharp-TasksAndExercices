using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _12Class_exercise01_SerializationDeserialization.Entities
{
    public class Student
    {
        [JsonProperty]
        public string FirstName { get; set; }
        [JsonProperty]
        public string LastName { get; set; }
        [JsonProperty]
        public int Age { get; set; }
        [JsonProperty]
        public string[] Pets {get; set;}

        [OnSerialized]
        internal void OnSerializedMethod(StreamingContext context)
        {
            FirstName = FirstName.ToLower();
            LastName = LastName.ToLower();
        }

        /*
         * {
         *      "FirstName": "John",
         *      "LastName": "Doe",
         *      "Age": "35",
         *      "Pets": ["Dog1", "Dog2", "Dog3"]
         * }
         */

        /*
         * ID, MenuName, URL, Parent, ISVisible
         * 1, 3, /, nullable, bool
         * 1, file, /file, NULL, TRUE
         * 2, open, /file/open, 1, TRUE
         */
}
}
