using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class TeamMember
    {
        #region variables
        // member info
        private string _name;
        private uint _weight;
        private uint _length;
        private uint _age;

        private bool _isActive;

        // cards
        private bool _hasYellowCard;
        private bool _hasRedCard;
        private bool _hasBlueCard;

        private uint _amount_suspension;
        private bool _suspension_Active;
        #endregion

        #region simple getters
        public string getName() { return this._name; }
        public uint getWeight() { return this._weight; }
        public uint getLength() { return this._length;  }
        public uint getAge() { return this._age; }

        public bool getIsActive() { return this._isActive;  }
        public bool getHasYellowCard() { return this._hasYellowCard;  }
        public bool getHasRedCard() { return this._hasRedCard; }
        public bool getHasBlueCard() { return this._hasBlueCard; }
        public uint getAmountOfSuspensions() { return this._amount_suspension; }
        public uint getSuspensionActive() { return this._suspension_Active; }
        #endregion

        #region setters
        // info
        public void SetName(string name)
        {
            if (name.Length >= 2 && name.Length <= 20)
            {
                this._name = name;
            }
        }
        public void setWeight(uint weight)
        {
            if (weight >= 40 && weight <= 200)
            {
                this._weight = weight;
            }
        }
        public void setLength(uint length)
        {
            if (length >= 100 && length <= 230)
            {
                this._length = length;
            }
        }
        public void setAge(uint age)
        {
            if(age >= 14 && age <= 50 )
            {
                this._age = age;
            }
        }

        //cards
        public void setYellowCard() { this._hasYellowCard = true; }
        public void resetYellowCard() { this._hasYellowCard = false; }
        public void setRedCard() { this._hasRedCard = true; }
        public void resetRedCard() { this._hasRedCard = false; }
        public void setBlueCard() { this._hasBlueCard = true; }
        public void resetBlueCard() { this._hasBlueCard = false; }
        
        //suspension
        public void addSuspension()
        {
            if(this._amount_suspension <= 2)
            {
                this._amount_suspension++;
            }
        }
        public void substrSuspension()
        {
            if(this._amount_suspension > 0)
            {
                this._amount_suspension--;
            }
        }
        public void resetSuspension()
        {
            this._amount_suspension = 0;
        }

        public void setSuspensionActive() { this._suspension_Active = true; }
        public void resetSuspensionActive() { this._suspension_Active = false; }

        #endregion
    }
}
