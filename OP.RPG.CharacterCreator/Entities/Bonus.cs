using OP.RPG.CharacterCreator.Enums;

namespace OP.RPG.CharacterCreator.Entities
{
    public class Bonus
    {
        public BonusKeysEnum Key { get; set; }

        public int? Value { get; set; }

        public string AttributeKey { get; set; }

        public int Level { get; set; }

        public int Multiplier { get; set; }
    }
}
