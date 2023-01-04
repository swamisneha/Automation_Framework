﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoTest
    {
        //This will deleted
        public static object[] DemoValidData()
        {
            //object a = 10; // boxing
            //int z = (int)a;//unboxing
            //object[] b = new string[] { "red", "green" };


            string[] dataSet1 = new string[2];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";

            string[] dataSet2 = new string[2];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";

            string[] dataSet3 = new string[2];
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";

            object[] allDataSet = new object[3]; // Number of test cases
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;
            return allDataSet;
        }

        [Test, TestCaseSource(nameof(DemoValidData))]

        public void DemoValidLogin(string username, string password)
        {
            Console.WriteLine("Hello" +username+password);
        }
    }
}
