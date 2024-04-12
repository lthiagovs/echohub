using Lambda.Domain.Enum;
using Lambda.Domain.Interfaces;

namespace Lambda.Domain.Models.Attributes
{
    public class AttributeList
    {

        public List<Attribute> Attributes { get; private set; }

        //Create a list with all atribute types
        public AttributeList()
        {
            Attributes = new List<Attribute>();

            foreach (AttributeType attType in System.Enum.GetValues(typeof(AttributeType)))
            {

                Attribute _newAttribute = new Attribute(attType, 0);
                Attributes.Add(_newAttribute);

            }

        }

        //Sum all atributes
        public void Append(IAttribute Atributable)
        {

            for (int i = 0; i < Attributes.Count(); i++)
            {

                Attributes[i].Value += Atributable.AttributeList.Attributes[i].Value;

            }

        }


    }

}
