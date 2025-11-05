using AwesomeAssertions;

namespace Enchanting;

public class EnchantingTest
{
    [Fact]
    public void WhenFireEnchant_PrefixInfernoAnd5FireDamage()
    {
        var baseWeapon = new BaseWeapon();
        var durance = new Durance(baseWeapon);
        
        durance.Enchant("fire");

        durance.DescribeWeapon().Should().Be("Inferno Dagger of the Nooblet\n5 - 10 attack damage\n1.2 attack speed\n+5 fire damage");
    }

    [Fact]
    public void WhenNoEnchant_BaseWeapon()
    {
        var baseWeapon = new BaseWeapon();
        var durance = new Durance(baseWeapon);
        
        durance.DescribeWeapon().Should().Be("Dagger of the Nooblet\n5 - 10 attack damage\n1.2 attack speed");
    }
}

public class Durance(IWeapon weapon)
{
    private bool _isFire;
    public void Enchant(string enchantment)
    {
        if (enchantment.Equals("fire")) _isFire = true;
    }

    public string DescribeWeapon()
    {
        return _isFire ? "Inferno Dagger of the Nooblet\n5 - 10 attack damage\n1.2 attack speed\n+5 fire damage" : weapon.Stats();
    }
}

public interface IWeapon
{
    string Stats();
}

public class BaseWeapon: IWeapon
{
    public string Stats()
    {
        return "Dagger of the Nooblet\n5 - 10 attack damage\n1.2 attack speed";
    }
}