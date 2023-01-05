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

           // for(int r =2; r <= 4; r++)
           // {
            //    for(int c = 1; c <= 3; c++)
               // {
               //     string value = range.Cell(r,c).GetString();
                 //   Console.WriteLine(value);
              //  }
           // }
            
            for(int i= 2; i <= 4; i++)
            {
                for(int j = 1; j<=3; j++)
                {
                    if(i==2 && j == 1)
                    {
                        string value = range.Cell(i, j).GetString();
                        Console.WriteLine(value);
                    }
                }
            }

            book.Dispose();
        }
    }
}
