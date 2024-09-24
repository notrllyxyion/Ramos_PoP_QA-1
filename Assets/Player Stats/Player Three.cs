using UnityEngine;
using TMPro;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text_w;

    public string Name = "Jah-Rek Romeus Gayod panot";
    public int Age = 25;
    public int Health = 1500;
    public float Aura = -999999999.9999f;
    public int rizz = -13130000;
    public int armor = -9999;
    public int Speed =-44000;
    public int mana = 313100;
    public int PhysicalDamage = 9009;
    public int MagicalDamage = 3003;


    public void ButtonPressed()
    {
        text_w.text = $" Player One Stats: \r\n \r\n Name: {Name} \r\n Age: {25} \r\n Health: {Health} \r\n Aura: {Aura} \r\n Rizz: {rizz} \r\n Armor: {armor} \r\n Speed: {Speed} \r\n Mana: {mana} \r\n Physical Damage: {PhysicalDamage} \r\n Magical Damage; {MagicalDamage} ";
    }

}
