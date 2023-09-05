using Microsoft.AspNetCore.Mvc;
using System.IO;
using MySqlToOds.Models;
using unoidl.com.sun.star.beans;
using unoidl.com.sun.star.container;
using unoidl.com.sun.star.frame;
using unoidl.com.sun.star.lang;
using unoidl.com.sun.star.sheet;
using unoidl.com.sun.star.table;
using unoidl.com.sun.star.text;
using unoidl.com.sun.star.uno;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySqlToOds.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly StudentDataContext _studentDataContext;

        public StudentController(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        private const string filePath = @"file:///C:/Students.ods";

        internal XComponent OpenCalcSheet()
        {
            XComponentContext oStrap = uno.util.Bootstrap.bootstrap();
            XMultiServiceFactory oServMan = (XMultiServiceFactory)oStrap.getServiceManager();
            XComponentLoader desktop = (XComponentLoader)oServMan.createInstance("com.sun.star.frame.Desktop");
            string url = @"private:factory/scalc";
            PropertyValue[] loadProps = new PropertyValue[1];
            loadProps[0] = new PropertyValue();
            loadProps[0].Name = "Hidden";
            loadProps[0].Value = new uno.Any(true);
            XComponent document = desktop.loadComponentFromURL(url, "_blank", 0, loadProps);
            return document;
        }

        private void WriteToSheet(XComponent document)
        {
            XSpreadsheets oSheets = ((XSpreadsheetDocument)document).getSheets();
            XIndexAccess oSheetsIA = (XIndexAccess)oSheets;
            XSpreadsheet sheet = (XSpreadsheet)oSheetsIA.getByIndex(0).Value;
            List<StudentDatum> studentDataList = _studentDataContext.StudentData.ToList();
            int column = 0;
            int row = 0;
            XCell cell = sheet.getCellByPosition(0, 0);
            var propertyNames = typeof(StudentDatum).GetProperties()
                .Select(property => property.Name)
                .ToList();
            foreach (var propertyName in propertyNames)
            {
                cell = sheet.getCellByPosition(column++, 0);
                ((XText)cell).setString(propertyName);
                Console.WriteLine($"Column Name: {propertyName}");
            }
            foreach (StudentDatum student in studentDataList)
            {

                column = 0; // 起始欄
                // StudentId
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.StudentId.ToString());

                // School
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.School);

                // Sex
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Sex);

                // Age
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Age.ToString());

                // Address
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Address);

                // Famsize
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Famsize);

                // Pstatus
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Pstatus);

                // Medu
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Medu.ToString());

                // Fedu
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Fedu.ToString());

                // Mjob
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Mjob);

                // Fjob
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Fjob);

                // Reason
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Reason);

                // Guardian
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Guardian);

                // Traveltime
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Traveltime.ToString());

                // Studytime
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Studytime.ToString());

                // Failures
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Failures.ToString());

                // Schoolsup
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Schoolsup);

                // Famsup
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Famsup);

                // Paid
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Paid);

                // Activities
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Activities);

                // Nursery
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Nursery);

                // Higher
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Higher);

                // Internet
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Internet);

                // Romantic
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Romantic);

                // Famrel
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Famrel.ToString());

                // Freetime
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Freetime.ToString());

                // Goout
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Goout.ToString());

                // Dalc
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Dalc.ToString());

                // Walc
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Walc.ToString());

                // Health
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Health.ToString());

                // Absences
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.Absences.ToString());

                // G1
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.G1.ToString());

                // G2
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.G2.ToString());

                // G3
                cell = sheet.getCellByPosition(column++, row);
                ((XText)cell).setString(student.G3.ToString());

                row++; // 移至下一列
            }
        }

        private void SaveCalcSheet(XComponent oDoc)
        {
            PropertyValue[] propVals = new PropertyValue[1];
            propVals[0] = new PropertyValue();
            propVals[0].Name = "FilterName";
            propVals[0].Value = new uno.Any("calc8");
            ((XStorable)oDoc).storeToURL(filePath, propVals);
        }

        [HttpGet]
        [Route("download")]
        public IActionResult GenerateOds()
        {
            try
            {
                // 建立ODS文件
                XComponent document = OpenCalcSheet();

                // 將數據倒入文件中
                WriteToSheet(document);

                // 儲存文件
                SaveCalcSheet(document);

                // 回傳ODS檔案
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                string contentType = "application/vnd.oasis.opendocument.spreadsheet";
                string fileName = "Students.ods";
                return File(fileStream, contentType, fileName);
            }
            catch (System.Exception ex)
            {
                // 處理例外
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }




        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentDatum> Get()
        {
            return _studentDataContext.StudentData.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
