using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text_w;

    public string Name = "Arjan Manzano pogi";
    public int Age = 25;
    public int Health = 1500;
    public float Aura = 93199.9999f;
    public int rizz = 1220;
    public int armor = 31319;
    public int Speed = 50000;
    public int mana = 131310;
    public int PhysicalDamage = 9131;
    public int MagicalDamage = 301313;


    public void ButtonPressed()
    {
        text_w.text = $" Player One Stats: \r\n \r\n Name: {Name} \r\n Age: {25} \r\n Health: {Health} \r\n Aura: {Aura} \r\n Rizz: {rizz} \r\n Armor: {armor} \r\n Speed: {Speed} \r\n Mana: {mana} \r\n Physical Damage: {PhysicalDamage} \r\n Magical Damage; {MagicalDamage} ";
    }

}
