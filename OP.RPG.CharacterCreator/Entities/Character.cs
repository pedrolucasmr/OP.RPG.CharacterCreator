using OP.RPG.CharacterCreator.Enums;

namespace OP.RPG.CharacterCreator.Entities
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Level { get; set; }

        public string Proeficiency { get; set; }

        public ClassesEnum Class { get; set; }

        public string Race { get; set; }

        public string Profession { get; set; } 

        public Dictionary<AttributeKeysEnum, int> Attributes { get; set; }

        public Dictionary<AttributeKeysEnum, int> SaveThrows { get; set; }

        public int CR { get; set; }

        public int MaxHP { get; set; }

        public int CurrentHp { get; set; }

        public int TempHP { get; set; }

        public int CurrentTempHp { get; set; }

        public int HakiHP { get; set; }

        public int CurrentHakiHp { get; set; }

        public int Inititiative { get; set; }

        public int MoveSpeed { get; set; }

        public List<ClassCharacteritic> ClassCharacteritics { get; set; }

        public List<HakiCharacteritic> ClassCharacteristics { get; set; }

        public List<TrainingCharacteritic> TrainingCharacteritics { get; set; }

        public List<AkumaCharacteristc> AkumaCharacteritics { get; set; }

        public List<Characteritic> GeneralCharacteristics { get; set; }

        public List<Action> Actions { get; set; }

        public List<Action> BonusActions { get; set; }

        public List<Action> Reactions { get; set; }

        public bool IsLegendaryCreature { get; set; }

        public List<Action> LegendaryActions { get; set; }

        public bool IsMythicalCreature { get; set; }

        public List<Action> MythicalActions { get; set; }
    }
}
