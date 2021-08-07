using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeDomGeneratorApp.View.GroupTag
{
    public class HTMLTag : IGroup, IHTMLGenerator
    {
        private List<IHTMLGenerator> tags = new List<IHTMLGenerator>();
        public void AddChild(IHTMLGenerator tag)
        {
            tags.Add(tag);
        }

        public String GenerateHTML()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<html>");
            foreach(IHTMLGenerator tag in tags)
            {
                String html = "\t" + tag.GenerateHTML();
                html = html.Replace("\n", "\n\t");
                stringBuilder.AppendLine(html);
            }
            stringBuilder.AppendLine("</html>");
            return stringBuilder.ToString();
        }
    }
}
