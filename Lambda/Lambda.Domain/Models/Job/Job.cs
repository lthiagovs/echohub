using Lambda.Domain.Interfaces;
using Lambda.Domain.Models.Attributes;

namespace Lambda.Domain.Models.Job
{
    public class Job : IAttribute
    {

        public string Name { get; set; }

        public bool Completed { get; set; }
        public string Description { get; set; }

        public AttributeList AttributeList { get; set; }

        public Job(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.AttributeList = new AttributeList();
            this.Completed = false;
        }

    }

}
