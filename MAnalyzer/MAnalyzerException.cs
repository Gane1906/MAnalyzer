using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAnalyzer
{
    public class MAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,EMPTY_MOOD
        }
        public ExceptionType exceptionType;
        public MAnalyzerException(ExceptionType exceptionType,string message) :base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
