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
    }
}
