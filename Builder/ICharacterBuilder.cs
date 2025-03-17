using System.Collections.Generic;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder Reset();
        ICharacterBuilder SetType();
        ICharacterBuilder SetHeight();
        ICharacterBuilder SetBuild();
        ICharacterBuilder SetHairColor();
        ICharacterBuilder SetEyeColor();
        ICharacterBuilder AddClothing();
        ICharacterBuilder AddToInventory();
        Character Build();
    }
} 