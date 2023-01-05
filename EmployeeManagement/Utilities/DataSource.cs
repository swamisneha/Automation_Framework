using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];           
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credential";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credential";

            string[] dataSet3 = new string[3];
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";
            dataSet3[2] = "Invalid credential";

            string[] dataSet4 = new string[3];
            dataSet4[0] = "jack";
            dataSet4[1] = "son";
            dataSet4[2] = "Invalid credential";


            object[] allDataSet = new object[4]; // Number of test cases
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;
            allDataSet[3] = dataSet4;
            return allDataSet;

        }

        public static object[] AddValidEmployeeTestData()
        {
            string[] dataSet1 = new string[6];
            dataSet1[0] = "Admin";
            dataSet1[1] = "admin123";
            dataSet1[2] = "John";
            dataSet1[3] = "G";
            dataSet1[4] = "Sick";
            dataSet1[5] = "John Sick";
           

            string[] dataSet2 = new string[6];
            dataSet2[0] = "Admin";
            dataSet2[1] = "admin123";
            dataSet2[2] = "Neena";
            dataSet2[3] = "M";
            dataSet2[4] = "Kochar";
            dataSet2[5] = "Neena Kockar";
          //  dataSet2[6] = "Neena Kockar";

            object[] allDataSet = new object[2]; // Number of test cases
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            return allDataSet;

        }
    }
}
