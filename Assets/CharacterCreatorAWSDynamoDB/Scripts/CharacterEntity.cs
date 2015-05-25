using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace Assets.CharacterCreatorAWSDynamoDB.Scripts
{
    [DynamoDBTable("CharacterCreator")]
    public class CharacterEntity
    {
        [DynamoDBHashKey]   // Hash key.
        public string CharacterID { get; set; }

        [DynamoDBProperty]
        public string Name { get; set; }

        [DynamoDBProperty]
        public int Age { get; set; }

        [DynamoDBProperty]
        public int Strength { get; set; }

        [DynamoDBProperty]
        public int Dexterity { get; set; }

        [DynamoDBProperty]
        public int Intelligence { get; set; }

        [DynamoDBProperty]
        public string FaceSpriteName { get; set; }

        [DynamoDBProperty]
        public string BodySpriteName { get; set; }

        [DynamoDBProperty]
        public string ShirtSpriteName { get; set; }

        [DynamoDBProperty]
        public string HairSpriteName { get; set; }

        [DynamoDBProperty]
        public string PantsSpriteName { get; set; }

        [DynamoDBProperty]
        public string ShoesSpriteName { get; set; }
    }
}