using System.Collections.Generic;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public EnemyBuilder()
        {
            this.Reset();
        }

        public ICharacterBuilder Reset()
        {
            this._character = new Character();
            return this;
        }

        public ICharacterBuilder SetHeight()
        {
            _character.Height = 190;
            return this;
        }

        public ICharacterBuilder SetBuild()
        {
            _character.Build = "Muscular";
            return this;
        }

        public ICharacterBuilder SetHairColor()
        {
            _character.HairColor = "Black";
            return this;
        }

        public ICharacterBuilder SetEyeColor()
        {
            _character.EyeColor = "Red";
            return this;
        }

        public ICharacterBuilder AddClothing()
        {
            _character.Clothing.Add("Dark Armor");
            _character.Clothing.Add("Black Cloak");
            return this;
        }

        public ICharacterBuilder AddToInventory()
        {
            _character.Inventory.Add("Dark Magic Staff");
            _character.Inventory.Add("Cursed Amulet");
            return this;
        }

        public ICharacterBuilder SetType()
        {
            _character.IsHero = false;
            return this;
        }

        // Special methods for EnemyBuilder
        public EnemyBuilder AddEvilDeed(string deed)
        {
            this._character.EvilDeeds.Add(deed);
            return this;
        }

        public EnemyBuilder DestroyVillage(string villageName)
        {
            this._character.EvilDeeds.Add($"Destroyed the village of {villageName}");
            return this;
        }

        public EnemyBuilder StealArtifact(string artifactName)
        {
            this._character.EvilDeeds.Add($"Stole the ancient artifact: {artifactName}");
            return this;
        }

        public EnemyBuilder CorruptInnocent(string description)
        {
            this._character.EvilDeeds.Add($"Corrupted an innocent: {description}");
            return this;
        }

        public Character Build()
        {
            Character result = this._character;
            this.Reset();
            return result;
        }
    }
} 