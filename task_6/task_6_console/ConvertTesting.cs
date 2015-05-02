using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertLib;

namespace task_6_console
{
    class ConvertTesting
    {
        static void Test()
        {
            ProgramConverter[] arrayOfObj = new ProgramConverter[2];

            arrayOfObj[0] = new ProgramHelper();
            arrayOfObj[1] = new ProgramConverter();


            foreach (ProgramConverter text in arrayOfObj)
            {
                string VBcodeToConvert = text.ConvertToCSharp("VB-code to convert!");
                Console.WriteLine( VBcodeToConvert);

                ProgramHelper newTxt = text as ProgramHelper;

                if ( newTxt != null )
                    newTxt.CodeCheckSyntax(VBcodeToConvert, "VB");
                else
                    Console.WriteLine("This is not a VB ProgramHelper\n");

                string cSharpCode = text.ConvertToCSharp(VBcodeToConvert);
                Console.WriteLine( cSharpCode );

                if ( newTxt != null )
                    newTxt.CodeCheckSyntax(VBcodeToConvert, "CSharp");
                else
                    Console.WriteLine("This is not a CSharp ProgramHelper\n");
            }
        }
        static void Main()
        {
            Test();
        }
    }
}
