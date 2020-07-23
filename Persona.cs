using System;

public class Persona {
    //Inicializamos las variables de la clase persona
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    //Metodo para hacer una copia superficial
    public Persona CopiaSuperficial()
    {
        return (Persona) this.MemberwiseClone();
        /*
        MemberwiseClone() es un metodo de C# 
        para realizar una copia superfical del objeto
        */

    }

    public Persona CopiaProfunda()
    {
        Persona clon = (Persona) this.MemberwiseClone();
        clon.IdInfo = new IdInfo(IdInfo.IdNumber);
        clon.Name = String.Copy(Name);
        return clon;
    }
}
