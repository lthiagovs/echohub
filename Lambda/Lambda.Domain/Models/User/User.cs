using Lambda.Domain.Enum;
using Lambda.Domain.Interfaces;
using Lambda.Domain.Models.Attributes;

namespace Lambda.Domain.Models.User
{
    public class User : IAttribute
    {

        public string Name {  get; set; }

        public Rank Rank { get; private set; }

        public AttributeList AttributeList { get; set; }

        public User(string Name)
        {

            this.Name = Name;
            this.Rank = 0;
            AttributeList = new AttributeList();

        }


    }
}
