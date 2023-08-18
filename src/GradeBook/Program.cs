using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {

            var book = new Book("Aodhan's Grade Book"); // Instanctiating Book obj
            book.addGrade(89.1);
            book.addGrade(90.5);
            book.addGrade(77.5);
            book.showStats();
        }
    }
}