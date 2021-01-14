using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class Brand
    {
        string name;
        string slogan;
        string primaryColour;
        string secondaryColour;

        public string PrimaryColour
        {
            get
            {
                return primaryColour;

            }
        }

        public Brand()
        {
            name = string.Empty;
            slogan = name = string.Empty;
            primaryColour = name = string.Empty;
            secondaryColour = name = string.Empty;
        }

        public Brand(string pName, string pSlogan, string pPrimaryColour, string pSecondaryColour)
        {
            name = pName;
            slogan = pSlogan;
            primaryColour = pPrimaryColour;
            secondaryColour = pSecondaryColour;
        }
    }
}
