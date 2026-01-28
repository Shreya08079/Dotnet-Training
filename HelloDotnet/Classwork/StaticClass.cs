using System;
using System.Xml.Serialization;
namespace HelloDotnet
{
    public static class GU
    {
        public static int Rno ;

        static GU()
        {
            Rno = 101;
        }

        public static int GetRno()
        {
            return Rno;
        }
    }
}