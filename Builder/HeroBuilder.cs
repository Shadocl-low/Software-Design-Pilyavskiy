using System.Collections.Generic;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public HeroBuilder()
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
            this._character.Height = 180;
            return this;
        }

        public ICharacterBuilder SetBuild()
        {
            this._character.Build = "Athletic";
            return this;
        }

        public ICharacterBuilder SetHairColor()
        {
            this._character.HairColor = "Blonde";
            return this;
        }

        public ICharacterBuilder SetEyeColor()
        {
            this._character.EyeColor = "Blue";
            return this;
        }

        public ICharacterBuilder AddClothing()
        {
            this._character.Clothing.Add("Shining Armor");
            this._character.Clothing.Add("Red Cape");
            return this;
        }

        public ICharacterBuilder AddToInventory()
        {
            this._character.Inventory.Add("Magic Sword");
            this._character.Inventory.Add("Shield");
            return this;
        }

        public ICharacterBuilder SetType()
        {
            this._character.IsHero = true;
            return this;
        }

        // Special methods for HeroBuilder
        public HeroBuilder AddGoodDeed(string deed)
        {
            this._character.GoodDeeds.Add(deed);
            return this;
        }

        public HeroBuilder SaveVillage(string villageName)
        {
            this._character.GoodDeeds.Add($"Saved the village of {villageName} from destruction");
            return this;
        }

        public HeroBuilder DefeatEvil(string evilType)
        {
            this._character.GoodDeeds.Add($"Defeated the {evilType}");
            return this;
        }

        public HeroBuilder HelpInnocent(string description)
        {
            this._character.GoodDeeds.Add($"Helped an innocent: {description}");
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