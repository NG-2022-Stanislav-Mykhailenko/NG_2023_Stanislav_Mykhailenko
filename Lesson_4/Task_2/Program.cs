using Open_Closed.Classes;

List<MagicType> magicTypes = new List<MagicType>()
{
    new MagicType("Fire Magic", 150),
    new MagicType("Water Magic", 50000000)
};

Magic magic = new Magic(magicTypes);

magic.CountYourMagic(150);
magic.CountYourMagic(50000000);
magic.CountYourMagic(12345);
