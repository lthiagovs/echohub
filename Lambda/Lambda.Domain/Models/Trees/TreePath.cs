using Lambda.Domain.Interfaces;
using Lambda.Domain.Models.Attributes;

namespace Lambda.Domain.Models.Trees
{
    public class TreePath : IAttribute
    {

        public string Name { get; set; }

        public AttributeList AttributeList {get; set;}

        public TreePath(string Name)
        {

            this.Name = Name;
            this.AttributeList = new AttributeList();

        }

    }

}
