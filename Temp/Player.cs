using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Player : TeamMember
    {
        #region variables
        // Player info
        private uint _number;
        private bool _isCaptain;
        
        // total goals
        private uint _total_goals;
        private uint _total_misses;
        private uint _total_attempts;

        // special goals
        private uint _total_7m_goals;
        private uint _total_7m_misses;
        private uint _total_7m_attempts;

        private uint _total_break_goals;
        private uint _total_break_misses;
        private uint _total_break_attempts;

        #endregion

        #region getters
        public uint getNumber() { return this._number; }
        public bool getIsCaptain() { return this._isCaptain; }

        public uint getTotalGoals() { return this._total_goals; }
        public uint getTotalAttempts() { return this._total_attempts; }
        public uint getTotal7mAttempts() { return this._total_7m_attempts; }
        public uint getTotal7mGoals() { return this._total_7m_goals; }
        public uint getTotalBreakAttempts() { return this._total_break_attempts; }
        public uint getTotalBreakGoals() { return this._total_break_goals; }


        // percentages
        public uint getScorePercentage() { return (this._total_goals * 100) / this._total_attempts; }
        public uint get7mPercentage() { return (this._total_7m_goals * 100) / this._total_7m_attempts; }
        public uint getbreakPercentage() { return (this._total_break_goals * 100) / this._total_break_attempts; }
        #endregion




    }
}
