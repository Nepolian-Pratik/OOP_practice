using Warrior.Enums;
using Warrior.Equipments;

namespace Warrior
{
    class warrior
    {
        private int _startHealth;
        private int _health;
        private int _attack;
        private int _defence;
        private string _name;
        private bool _isAlive;

        public bool IsAlive { get
            {
                return _isAlive;
            } }

        private Weapon weapon;
        private Armor armor;

        private Faction faction;

        /*private int _speed;
        private int _luck;
        private int _level;
        private int _exp;
        private int _gold;
        private int _maxHealth;
        private int _maxAttack;
        private int _maxDefence;
        private int _maxSpeed;
        private int _maxLuck;
        private int _maxLevel;
        private int _maxExp;
        private int _maxGold;
        private int _minHealth;
        private int _minAttack;
        private int _minDefence;
        private int _minSpeed;
        private int _minLuck;
        private int _minLevel;
        private int _minExp;
        private int _minGold;*/
    }
}