using System;

namespace LinqWithSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apply student structure to XML
            string studentsXML =
                @"<Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21</Age>
                            <University>University of Utah</University>
                        </Student>
                        <Student>
                            <Name>Rob</Name>
                            <Age>22</Age>
                            <University>Drake</University>
                        </Student>
                        <Student>
                            <Name>Jimbo</Name>
                            <Age>19</Age>
                            <University>Drake</University>
                        </Student>
                    </Students>";
        }
    }
}
