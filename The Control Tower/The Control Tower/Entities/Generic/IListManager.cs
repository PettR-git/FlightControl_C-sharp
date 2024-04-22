using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTS.Entities.Main
{
    interface IListManager<T>
    {
        //Handling list items
        bool addItem(T item);
        bool removeItem(T item);
        bool changeItem(T item, int index);
        T getListItemAt(int index);
        string[] getListToStrings();

        //Serializing data (List<T>) Binary, XML, or JSON
        void xmlSerialize(string fileName);
        bool xmlDeserialize(string fileName);
        bool jsonDeSerialize(string fileName, JsonSerializerSettings options);
        void jsonSerialize(string fileName, JsonSerializerSettings options);
        void binarySerialize(string fileName);
        bool binaryDeSerialize(string fileName);
    }
}
