using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5_103022400129
{
    public class SimpleDatabase<T>
    {

        List<T> storedData;
        List<DateTime> inputDate;

        public SimpleDatabase()
        {
            this.storedData = new List<T>();
            this.inputDate = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputDate.Add(System.DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi " + storedData[i] + " yang disimpan pada waktu " + inputDate[i]);
            }
        }
    }

}
