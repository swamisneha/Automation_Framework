using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Demo3Excel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook("C:\\AutomationTraining\\AutomationFramework\\EmployeeManagement\\Test Data\\Orange_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");
            IXLRange range = sheet.RangeUsed();

            //string value = range.Cell(1, 1).GetString();
            //Console.WriteLine(value);

            object[] allDataset = new object[2];

            for (int r = 2; r <= 4; r++)
            {
                string[] arr = new string[3];

                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                    arr[c-1] = value;
                }
                allDataset[r-2] = arr;
            }

            book.Dispose();
        }
         
    }
}
