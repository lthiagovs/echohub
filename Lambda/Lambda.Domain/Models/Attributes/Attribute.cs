using Lambda.Domain.Enum;

namespace Lambda.Domain.Models.Attributes
{
    public class Attribute
    {

        public AttributeType Type { get; private set; }

        public int Value { get; set; }

        public string Name { get; private set; }

        public Attribute(AttributeType Type, int Value)
        {
            this.Type = Type;
            this.Value = Value;
            Name = Type.ToString();

        }



    }

}
