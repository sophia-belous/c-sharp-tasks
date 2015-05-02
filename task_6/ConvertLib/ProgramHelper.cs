using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLib
{
    interface IConvertible
    {
        string ConvertToCSharp(string codeToConvert);
        string ConvertToVB(string codeToConvert);
    }

    interface ICodeChecker : IConvertible
    {
        bool CodeCheckSyntax(string codeToCheck, string language);
    }

    public class ProgramHelper: ProgramConverter, ICodeChecker
    {
        public ProgramHelper()
        {
            Console.WriteLine("Constructor ProgramHelper");
        }


        public bool CodeCheckSyntax(string inputCode, string language)
        {
            switch (language)
            {
                case "CSharp":
                    Console.WriteLine("This code is checked as CSharp: {0}\n", inputCode);
                    return true;

                case "VB":
                    Console.WriteLine("This code is checked as VB: {0}\n", inputCode);
                    return true;
                default:
                    return false;
            }
        }
    }

    public class ProgramConverter : IConvertible
    {
        public ProgramConverter()
        {
            Console.WriteLine("Constructor ProgramConverter");
        }


        public string ConvertToCSharp(string codeToConvert)
        {
            //Console.WriteLine("Converting the string to CSharp");

            return "Code is converted to CSharp!\n";
        }

        public string ConvertToVB(string codeToConvert)
        {
            //Console.WriteLine("Converting the string to CSharp");

            return "Code is converted to VB!\n";
        }
    }
}
