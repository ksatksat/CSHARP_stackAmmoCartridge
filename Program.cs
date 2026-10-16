using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
namespace Cartridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is ammo cartridge made by using Stack<T> : ");

            NatoAmmo ordinaryNato = new NatoAmmo("Nato ammo", "Ordinary", 5.56f);
            NatoAmmo rubberNato = new NatoAmmo("Nato ammo", "Rubber", 5.56f);
            NatoAmmo armorPiercingNato = new NatoAmmo("Nato ammo", "Armor Piercing", 5.56f);
            NatoAmmo tracerNato = new NatoAmmo("Nato ammo", "Tracer", 5.56f);
            NatoAmmo explosiveNato = new NatoAmmo("Nato ammo", "Explosive", 5.56f);

            SovietAmmo ordinarySoviet = new SovietAmmo("Soviet ammo", "Ordinary", 7.62f);
            SovietAmmo rubberSoviet = new SovietAmmo("Soviet ammo", "Rubber", 7.62f);
            SovietAmmo armorPiercingSoviet = new SovietAmmo("Soviet ammo", "Armor Piercing", 7.62f);
            SovietAmmo tracerSoviet = new SovietAmmo("Soviet ammo", "Tracer", 7.62f);
            SovietAmmo explosiveSoviet = new SovietAmmo("Soviet ammo", "Explosive", 7.62f);

            Stack<Ammo> cartidge = new Stack<Ammo>();
            cartidge.Push(ordinaryNato);
            cartidge.Push(rubberNato);
            cartidge.Push(armorPiercingNato);
            cartidge.Push(tracerNato);
            cartidge.Push(explosiveNato);

            for (int b = 0; b < cartidge.Count; b++)
            {
                Ammo bullet = cartidge.ToArray()[b];
                Console.WriteLine(bullet.Shoot("AR-15"));
            }
            while (cartidge.Count > 0)
            {
                cartidge.Pop();
            }
            //cartidge.Pop();//removes element from Stack<T>
            //cartidge.Clear();//deletes all elements inside Stack<T>

            cartidge.Push(ordinarySoviet);
            cartidge.Push(rubberSoviet);
            cartidge.Push(armorPiercingSoviet);
            cartidge.Push(tracerSoviet);
            cartidge.Push(explosiveSoviet);

            foreach (var bullet in cartidge)
            {
                Console.WriteLine(bullet.Shoot("AK 47"));
            }
            //cartidge.Pop();//removes element from Stack<T>
        }
    }
    class Ammo
    {
        protected string Name { get; set; }
        protected string Type { get; set; }
        protected float CartigeFamily { get; set; }
        public Ammo(string name, string type, float cartigeFamily)
        {
            Name = name;
            Type = type;
            CartigeFamily = cartigeFamily;
        }
        public virtual string Shoot(string nameOfWeapon)
        {
            return nameOfWeapon + ", shoots with "
            + Name + ", with type " + Type
            + ", and " + CartigeFamily + " mm.";
        }
    }
    class NatoAmmo : Ammo
    {
        public NatoAmmo(string name, string type, float cartigeFamily)
        : base(name, type, cartigeFamily) { }
        public override string Shoot(string nameOfWeapon)
        {
            return "Nato ammo : " + base.Shoot(nameOfWeapon);
        }
    }
    class SovietAmmo : Ammo
    {
        public SovietAmmo(string name, string type, float cartigeFamily)
        : base(name, type, cartigeFamily) { }
        public override string Shoot(string nameOfWeapon)
        {
            return "Soviet ammo : " + base.Shoot(nameOfWeapon);
        }
    }
}