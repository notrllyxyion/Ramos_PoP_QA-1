using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text_w;

    public string Name = "Sir Maynard pogi";
    public int Age = 25;
    public int Health = 1500;
    public float Aura = 999999999.9999f;
    public int rizz = 1000000000;
    public int armor = 999999;
    public int Speed = 50000;
    public int mana = 1000000;
    public int PhysicalDamage = 90909;
    public int MagicalDamage = 3030303; 


    public void ButtonPressed()
    {
        text_w.text = $" Player One Stats: \r\n \r\n Name: {Name} \r\n Age: {25} \r\n Health: {Health} \r\n Aura: {Aura} \r\n Rizz: {rizz} \r\n Armor: {armor} \r\n Speed: {Speed} \r\n Mana: {mana} \r\n Physical Damage: {PhysicalDamage} \r\n Magical Damage; {MagicalDamage} ";
    }

}
   
