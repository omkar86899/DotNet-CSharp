using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeDomGeneratorApp.View.GroupTag
{
    public class BodyTag : IGroup, IHTMLGenerator
    {
        private List<IHTMLGenerator> tags = new List<IHTMLGenerator>();
        public void AddChild(IHTMLGenerator tag)
        {
            tags.Add(tag);
        }

        public string GenerateHTML()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<body>");
            foreach (IHTMLGenerator tag in tags)
            {
                String html = "\t" + tag.GenerateHTML();
                html = html.Replace("\n", "\n\t");
                stringBuilder.AppendLine(html);
            }
            stringBuilder.AppendLine("</body>");
            return stringBuilder.ToString();
        }
    }
}
