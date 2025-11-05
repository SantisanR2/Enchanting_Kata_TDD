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
}

public class Durance(IWeapon weapon)
{
    public void Enchant(string enchantment)
    {
        throw new NotImplementedException();
    }

    public string DescribeWeapon()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}