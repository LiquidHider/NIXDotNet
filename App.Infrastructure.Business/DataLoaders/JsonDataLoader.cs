using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace App.Infrastructure.Business
{
    public class JsonDataLoader
    {
        public T Load<T>(string path) where T : class
        {
            T item;
            using (StreamReader sr = new StreamReader(path)) 
            {
                item = JsonSerializer.Deserialize<T>(sr.ReadToEnd());
            }
            return item;
        }
    }
}
