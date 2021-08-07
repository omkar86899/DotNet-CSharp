using System;
using System.Text;

namespace EmpoyeeDomGeneratorApp.View.IndividualTag
{
    public class PTag:IHTMLGenerator
    {
        private String _innerHTML;
        public PTag(String innerHTML)
        {
            _innerHTML = innerHTML;
        }

        public string GenerateHTML()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<p>");
            stringBuilder.Append(_innerHTML);
            stringBuilder.Append("</p>");
            return stringBuilder.ToString();
        }
    }
}
