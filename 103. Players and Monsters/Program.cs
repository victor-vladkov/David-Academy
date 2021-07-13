using System;

namespace _103._Players_and_Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Hero
    {
        private int level;
        private string username;
        public Hero(string username, int level)
        {
            this.username = username;
            this.level = level;
        }
        public string Username
        {
            get {return this.username;}
            set {this.username = value;}
        }
        public int Level
        {
            get {return this.username;}
            set {this.username = value;}
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }    
    }
    public class Elf:Hero
    {
        public Elf(string name, int level):base(name, level)
        {}
    }
    public class Wizard:Hero
    {
        public Wizard(string name, int level):base(name, level)
        {}
    }
    public class Knight:Hero
    {
    public Knight(string name, int level):base(name, level)
        {}
    }
    public class MuseElf:Elf
    {
    public MuseElf(string name, int level):base(name, level)
        {}
    }
    public class DarkWizard:Wizard
    {
        public DarkWizard(string name, int level):base(name, level)
        {}
    }
    public class SoulMaster:DarkWizard
    {
        public SoulMaster(string name, int level):base(name, level)
        {}
    }
    public class DarkKnight:Knight
    {
        public DarkKnight(string name, int level):base(name, level)
        {}
    }
    public class BladeKnight:DarkKnight
    {
        public BladeKnight(string name, int level):base(name, level)
        {}
    }
}
