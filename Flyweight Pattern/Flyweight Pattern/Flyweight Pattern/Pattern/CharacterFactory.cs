using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern.Pattern
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> _character = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;

            if (_character.ContainsKey(key))
            {
                character = _character[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA();break;

                    case 'B': character = new CharacterB(); break;

                    case 'Z': character = new CharacterZ(); break;
                }
            }
            return character;

        }


    }
}
